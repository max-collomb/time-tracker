using System.Globalization;
using System.Text.RegularExpressions;

namespace time_tracker
{
  public class Day
  {
    public static int WeekLoad = 2100; // 35h par défaut
    public DateTime Date { get; set; }
    public string SqlDate { get; set; }
    public List<Event> Checks { get; set; }
    public Annotation? Annotation { get; set; }
    public bool IsInProgress { get; set; }
    public int TimeChecked { get; set; }
    public int TimeOff {  get; set; }
    public Day(DateTime dateTime, List<Event>? checks = null, Annotation? annotation = null)
    {
      Date = dateTime;
      SqlDate = dateTime.Date.ToString("yyyy-MM-dd");
      Checks = [];
      Init(checks, annotation, DateTime.Now);
    }
    public Day(string date, string[] checks, string annotationType, string nowDate, string nowTime)
    {
      Date = DateTime.ParseExact(date, "yyyy-MM-dd", CultureInfo.InvariantCulture);
      SqlDate = date;
      Checks = [];
      List<Event> events = [];
      foreach (var check in checks)
        events.Add(new Event(0, date, check, "usr_check"));
      Annotation? annotation = null;
      if (!string.IsNullOrEmpty(annotationType))
        annotation = new Annotation(0, date, annotationType, "");
      DateTime now = DateTime.ParseExact(date + " " + nowTime, "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture);
      Init(events, annotation, now);
      IsInProgress = SqlDate == nowDate && Checks.Count % 2 == 1;
    }
    private void Init(List<Event>? checks, Annotation? annotation, DateTime now)
    {
      Checks = checks ?? DataBase.GetEvents("usr_check", SqlDate);
      Annotation = annotation ?? DataBase.GetAnnotation(SqlDate);
      IsInProgress = SqlDate == now.Date.ToString("yyyy-MM-dd") && Checks.Count % 2 == 1;
      TimeChecked = Checks.Count > 0 ? ChecksToTimes(now) : 0;
      TimeOff = 0;
      if (Annotation?.Type == "half_day_off")
        TimeOff = WeekLoad / 10;
      if (Annotation?.Type == "day_off")
        TimeOff = WeekLoad / 5;
    }
    private int ChecksToTimes(DateTime now)
    {
      Checks.Sort();
      int sum = 0;
      int i = 1;
      while (i < Checks.Count)
      {
        sum += TimeHelper.HourMinStrToMin(Checks[i].Time) - TimeHelper.HourMinStrToMin(Checks[i - 1].Time);
        i += 2;
      }
      if (i == Checks.Count && IsInProgress)
      {
        sum += now.Hour * 60 + now.Minute - TimeHelper.HourMinStrToMin(Checks[i - 1].Time);
      }
      return sum;
    }

    public void Refresh()
    {
      TimeChecked = Checks.Count > 0 ? ChecksToTimes(DateTime.Now) : 0;
    }

  }

  public static class TimeHelper
  {

    public static List<Day> GetDaysOfWeek(DateTime dateTime)
    {
      int diff = (7 + (dateTime.DayOfWeek - DayOfWeek.Monday)) % 7;
      DateTime monday = dateTime.AddDays(-1 * diff).Date;
      return [
        new Day(monday),
        new Day(monday.AddDays(1)),
        new Day(monday.AddDays(2)),
        new Day(monday.AddDays(3)),
        new Day(monday.AddDays(4)),
        new Day(monday.AddDays(5)),
        new Day(monday.AddDays(6))
      ];
    }

    public static int HourMinStrToMin(string hm)
    {
      Match match = new Regex(@"(\-?[0-9]{1,2})[:h]([0-9]{1,2})").Match(hm);
      if (match.Success)
      {
        int Hour = Int32.Parse(match.Groups[1].Value);
        int Minute = Int32.Parse(match.Groups[2].Value);
        return Hour * 60 + Minute;
      }
      return 0;
    }

    public static string MinToHourMinStr(int m)
    {
      return (m / 60).ToString("00") + ":" + (m % 60).ToString("00");
    }

    public static List<string> GetTargetSteps(
      List<Day> weekDays,
      int todayIdx,
      DateTime now,
      List<int> targets,
      List<int> pauses,
      bool isReminderEnabled,
      string reminder)
    {
      int count = weekDays[todayIdx].Checks.Count;
      bool isHalfDayOff = weekDays[todayIdx].Annotation?.Type == "half_day_off";
      List<string> steps = new();
      if (count == 0 || (count > 3 && count % 2 == 0))
        return steps;
      if (isHalfDayOff && count == 2)
        return steps;
      DateTime lastCheck = DateTime.ParseExact(weekDays[todayIdx].Checks[count - 1].Time, "HH:mm", CultureInfo.InvariantCulture);
      int target = 0;
      for (int i = 0; i <= todayIdx; i++)
      {
        target += targets[i] - weekDays[i].TimeChecked - weekDays[i].TimeOff;
      }
      if (lastCheck.Hour < 12 && pauses[todayIdx] > 0 && !isHalfDayOff)
      {
        // on ajoute la pause de midi
        string pauseStart = (isReminderEnabled && !string.IsNullOrEmpty(reminder)) ? reminder : (pauses[todayIdx] > 100 ? "12:00" : "12:15");
        target += pauses[todayIdx];
        steps.Add(pauseStart);
        steps.Add(DateTime.ParseExact(pauseStart, "HH:mm", CultureInfo.InvariantCulture).AddMinutes(pauses[todayIdx]).ToString("HH:mm"));
      }
      if (count % 2 == 1)
      {
        if (isReminderEnabled && !string.IsNullOrEmpty(reminder) && !steps.Contains(reminder))
          steps.Add(reminder);
        else
          steps.Add(now.AddMinutes(target).ToString("HH:mm"));
      }
      else if (lastCheck.Hour >= 12 && lastCheck.Hour < 14 && pauses[todayIdx] > 0 && !isHalfDayOff && target > 0)
      {
        if (isReminderEnabled && !string.IsNullOrEmpty(reminder))
        {
          steps.Add(reminder);
          steps.Add(DateTime.ParseExact(reminder, "HH:mm", CultureInfo.InvariantCulture).AddMinutes(target).ToString("HH:mm"));
        }
        else
        {
          steps.Add(lastCheck.AddMinutes(pauses[todayIdx]).ToString("HH:mm"));
          steps.Add(now.AddMinutes(target + pauses[todayIdx]).ToString("HH:mm"));
        }
      }
      return steps;
    }

  }
}

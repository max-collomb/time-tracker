using System.Text.RegularExpressions;

namespace time_tracker
{
  public class Day
  {
    public DateTime Date { get; set; }
    public string SqlDate { get; set; }
    public List<Event> Checks { get; set; }
    public bool IsInProgress { get; set; }
    public int TimeChecked { get; set; }
    public Day(DateTime dateTime, List<Event>? checks = null)
    {
      Date = dateTime.Date;
      SqlDate = dateTime.Date.ToString("yyyy-MM-dd");
      Checks = checks ?? DataBase.GetEvents("usr_check", SqlDate);
      IsInProgress = SqlDate == DateTime.Now.Date.ToString("yyyy-MM-dd") && Checks.Count % 2 == 1;
      TimeChecked = Checks.Count > 0 ? ChecksToTimes() : 0;
    }
    private int ChecksToTimes()
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
        sum += DateTime.Now.Hour * 60 + DateTime.Now.Minute - TimeHelper.HourMinStrToMin(Checks[i - 1].Time);
      }
      return sum;
    }

    public void Refresh()
    {
      TimeChecked = Checks.Count > 0 ? ChecksToTimes() : 0;
    }

  }

  internal static class TimeHelper
  {

    public static List<Day> GetDaysOfWeek(DateTime dateTime)
    {
      int diff = (7 + (dateTime.DayOfWeek - DayOfWeek.Monday)) % 7;
      DateTime monday = dateTime.AddDays(-1 * diff).Date;
      return [new Day(monday), new Day(monday.AddDays(1)), new Day(monday.AddDays(2)), new Day(monday.AddDays(3)), new Day(monday.AddDays(4))];
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
  }
}

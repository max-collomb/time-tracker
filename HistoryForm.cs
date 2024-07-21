using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace time_tracker
{
  public partial class HistoryForm : Form
  {
    public HistoryForm()
    {
      InitializeComponent();
      SetRangeToolStripMenuItem_Click(ThisWeekToolStripMenuItem, new EventArgs());
    }

    public void RefreshDataGridView()
    {
      EventsDataGridView.Rows.Clear();
      WeekDataGridView.Rows.Clear();
      List<Event> events = DataBase.GetEvents(FromDatePicker.Value.ToString("yyyy-MM-dd"), ToDatePicker.Value.ToString("yyyy-MM-dd"));
      Dictionary<string, int> timeByDate = new();
      List<Event> dateEvents = new();
      for (int i = 0, length = events.Count; i < length; i++)
      {
        Event e = events[i];
        EventsDataGridView.Rows.Add(new string[] { e.Date, e.Time, e.Type });
        dateEvents.Add(e);
        if (i == length - 1 || events[i + 1].Date != e.Date)
        {
          if (dateEvents.Count > 0)
          {
            Day day = new(DateTime.ParseExact(e.Date, "yyyy-MM-dd", CultureInfo.InvariantCulture), dateEvents);
            timeByDate.Add(e.Date, day.TimeChecked);
            dateEvents.Clear();
          }
        }
      }
      if (events.Count > 0)
      {
        DateTime startDate = DateTime.ParseExact(events[0].Date, "yyyy-MM-dd", CultureInfo.InvariantCulture);
        DateTime endDate = DateTime.ParseExact(events[events.Count - 1].Date, "yyyy-MM-dd", CultureInfo.InvariantCulture);
        DateTime startMonday = startDate.AddDays(-1 * ((7 + (startDate.DayOfWeek - DayOfWeek.Monday)) % 7)).Date;
        DateTime currentMonday = startMonday;
        while (currentMonday < endDate)
        {
          int timeChecked = 0;
          for (int i = 0; i < 5; i++)
          {
            string dayOfWeek = currentMonday.AddDays(i).Date.ToString("yyyy-MM-dd");
            if (timeByDate.ContainsKey(dayOfWeek))
              timeChecked += timeByDate[dayOfWeek];
          }
          WeekDataGridView.Rows.Add(new string[] {
            ISOWeek.GetWeekOfYear(currentMonday).ToString(),
            currentMonday.ToString("yyyy-MM-dd"),
            TimeHelper.MinToHourMinStr(timeChecked)
          });
          currentMonday = currentMonday.AddDays(7).Date;
        }
      }
    }

    private void SetRangeToolStripMenuItem_Click(object sender, EventArgs e)
    {
      DateTime start = DateTime.Now.Date;
      DateTime end = DateTime.Now.Date;
      if (sender == ThisDayToolStripMenuItem)
      {
        start = DateTime.Now.Date;
        end = DateTime.Now.Date;
      }
      else if (sender == LastDayToolStripMenuItem)
      {
        start = start.AddDays(-1).Date;
        if (start.DayOfWeek == DayOfWeek.Sunday)
          start = start.AddDays(-1).Date;
        if (start.DayOfWeek == DayOfWeek.Saturday)
          start = start.AddDays(-1).Date;
        end = start;
      }
      else if (sender == ThisWeekToolStripMenuItem)
      {
        int diff = (7 + (start.DayOfWeek - DayOfWeek.Monday)) % 7;
        start = start.AddDays(-1 * diff).Date;
        end = start.AddDays(6).Date;
      }
      else if (sender == LastWeekToolStripMenuItem)
      {
        int diff = (7 + (start.DayOfWeek - DayOfWeek.Monday)) % 7;
        start = start.AddDays(-1 * diff - 7).Date;
        end = start.AddDays(6).Date;
      }
      else if (sender == ThisMonthToolStripMenuItem)
      {
        start = new DateTime(start.Year, start.Month, 1).Date;
        end = start.AddMonths(1).AddDays(-1).Date;
      }
      else if (sender == LastMonthToolStripMenuItem)
      {
        start = new DateTime(start.Year, start.Month, 1).AddMonths(-1).Date;
        end = start.AddMonths(1).AddDays(-1).Date;
      }
      else if (sender == ThisYearToolStripMenuItem)
      {
        start = new DateTime(start.Year, 1, 1).Date;
        end = start.AddYears(1).AddDays(-1).Date;
      }
      else if (sender == LastYearToolStripMenuItem)
      {
        start = new DateTime(start.Year, 1, 1).AddYears(-1).Date;
        end = start.AddYears(1).AddDays(-1).Date;
      }
      else return;
      try
      {
        FromDatePicker.Value = start;
        ToDatePicker.Value = end;
        RefreshDataGridView();
      }
      catch { }
    }

    private void ApplyButton_Click(object sender, EventArgs e)
    {
      RefreshDataGridView();
    }
  }
}

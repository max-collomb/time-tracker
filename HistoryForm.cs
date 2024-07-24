using System.Diagnostics;
using System.Drawing.Drawing2D;
using System.Globalization;
using System.Windows.Controls;
using System.Windows.Forms;

namespace time_tracker
{

  public partial class HistoryForm : Form
  {

    static Dictionary<string, string> EventTypeDescriptions = new() {
      { "app_start", "Lancement de l'application" },
      { "usr_check", "Badgeage" },
      { "sys_wakeup", "Sortie de veille" },
      { "sys_sleep", "Mise en veille" },
      { "sys_logoff", "Déconnexion" },
      { "sys_shutdown", "Arrêt" },
      { "sess_lock", "Verrouillage session" },
      { "sess_unlock", "Déverrouillage session" },
    };
    public HistoryForm()
    {
      InitializeComponent();
      SelectRangeToolStripMenuItem_Click(ThisWeekToolStripMenuItem, new EventArgs());
    }

    public void RefreshEventDataGridView()
    {
      EventsDataGridView.Rows.Clear();
      List<Event> events = DataBase.GetEvents(null, FromDatePicker.Value.ToString("yyyy-MM-dd"), ToDatePicker.Value.ToString("yyyy-MM-dd"));
      for (int i = 0, length = events.Count; i < length; i++)
      {
        Event e = events[i];
        //EventsDataGridView.Rows.Add(new string[] { e.Id.ToString(), e.Date, e.Time, e.Type });
        EventsDataGridView.Rows.Insert(0, [
          e.Id.ToString("000000"),
          e.Date,
          e.Time,
          EventTypeDescriptions.TryGetValue(e.Type, out string? value) ? value + " (" + e.Type + ")" : e.Type]);
      }
    }

    public void RefreshWeekDataGridView()
    {
      WeekDataGridView.Rows.Clear();
      List<Event> events = DataBase.GetEvents("usr_check");
      Dictionary<string, int> timeByDate = new();
      List<Event> dateEvents = new();
      for (int i = 0, length = events.Count; i < length; i++)
      {
        Event e = events[i];
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
        while (currentMonday <= endDate)
        {
          int timeChecked = 0;
          for (int i = 0; i < 5; i++)
          {
            string dayOfWeek = currentMonday.AddDays(i).Date.ToString("yyyy-MM-dd");
            if (timeByDate.ContainsKey(dayOfWeek))
              timeChecked += timeByDate[dayOfWeek];
          }
          //WeekDataGridView.Rows.Add(new string[] {
          //  ISOWeek.GetWeekOfYear(currentMonday).ToString(),
          //  currentMonday.ToString("yyyy-MM-dd"),
          //  TimeHelper.MinToHourMinStr(timeChecked)
          //});
          WeekDataGridView.Rows.Insert(0, [
            currentMonday.Date.ToString("yy") + "_" + ISOWeek.GetWeekOfYear(currentMonday).ToString("00"),
            currentMonday.ToString("yyyy-MM-dd"),
            TimeHelper.MinToHourMinStr(timeChecked)
          ]);
          currentMonday = currentMonday.AddDays(7).Date;
        }
      }
    }

    private void ApplyButton_Click(object sender, EventArgs e)
    {
      RefreshEventDataGridView();
    }

    private void AddEventButton_Click(object sender, EventArgs e)
    {
      string date = DateTime.Now.ToString("yyyy-MM-dd");
      string time = DateTime.Now.ToString("HH:mm");
      if (EventsDataGridView.SelectedRows.Count > 0)
      {
        date = EventsDataGridView.SelectedRows[0].Cells[1].Value.ToString() ?? date;
        time = EventsDataGridView.SelectedRows[0].Cells[2].Value.ToString() ?? time;
      }
      using var eventForm = new EventForm(date, time, true);
      if (eventForm.ShowDialog(this) == DialogResult.OK)
      {
        DataBase.InsertEvent("usr_check", eventForm.Date, eventForm.Time);
        RefreshEventDataGridView();
      }
    }

    private void EditToolStripMenuItem_Click(object? sender, EventArgs e)
    {
      if (EventsDataGridView.SelectedRows.Count == 1)
      {
        var row = EventsDataGridView.Rows[EventsDataGridView.SelectedRows[0].Index];
        Event evt = new(
          Int64.Parse(row.Cells[0].Value.ToString() ?? "-1"),
          row.Cells[1].Value.ToString() ?? "",
          row.Cells[2].Value.ToString() ?? "",
          row.Cells[3].Value.ToString() ?? ""
        );
        if (evt.Type == "usr_check")
        {
          using (var eventForm = new EventForm(evt.Date, evt.Time, true))
          {
            if (eventForm.ShowDialog(this) == DialogResult.OK)
            {
              DataBase.UpdateEvent(evt, eventForm.Date, eventForm.Time);
              RefreshEventDataGridView();
            }
          }
        }
      }
    }

    private void EventsDataGridView_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
    {
      if (e.Button == MouseButtons.Right)
      {
        int rowSelected = e.RowIndex;
        if (e.RowIndex != -1)
        {
          EventsDataGridView.ClearSelection();
          EventsDataGridView.Rows[rowSelected].Selected = true;
          EditToolStripMenuItem.Enabled = EventsDataGridView.Rows[e.RowIndex].Cells[3].Value.ToString().Contains(" (usr_check)");
        }
      }
    }

    private void DeleteToolStripMenuItem_Click(object? sender, EventArgs e)
    {
      if (EventsDataGridView.SelectedRows.Count == 1)
      {
        DataBase.DeleteEvent(new(Int64.Parse(EventsDataGridView.Rows[EventsDataGridView.SelectedRows[0].Index].Cells[0].Value.ToString() ?? "-1"), "", "", ""));
        RefreshEventDataGridView();
      }
    }

    private void CloseButton_Click(object sender, EventArgs e)
    {
      Close();
    }

    private void TabControl_SelectedIndexChanged(object sender, EventArgs e)
    {
      if (TabControl.SelectedIndex == 1)
      {
        RefreshWeekDataGridView();
      }
    }

    private void HistoryForm_Load(object sender, EventArgs e)
    {
      LogLinkLabel.Text = $"time-tracker-{DateTime.Now.Year}.log";
      SqliteLinkLabel.Text = Program.DbFileName;
      foreach (DataGridViewColumn column in EventsDataGridView.Columns)
      {
        if (column.Index > 0)
          column.SortMode = DataGridViewColumnSortMode.NotSortable;
      }
    }

    private void LogLinkLabel_Click(object sender, EventArgs e)
    {
      //using Process fileopener = new Process();

      //fileopener.StartInfo.FileName = "notepad";
      //fileopener.StartInfo.Arguments = "\"" + Path.Combine(AppDomain.CurrentDomain.BaseDirectory, $"time-tracker-{DateTime.Now.Year}.log") + "\"";
      //fileopener.Start();
      Process.Start("notepad.exe", "\"" + Path.Combine(AppDomain.CurrentDomain.BaseDirectory, $"time-tracker-{DateTime.Now.Year}.log") + "\"");
    }

    private void SqliteLinkLabel_Click(object sender, EventArgs e)
    {
      //using Process fileopener = new Process();

      //fileopener.StartInfo.FileName = "explorer";
      //fileopener.StartInfo.Arguments = "/select \"" + Path.Join(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), Program.DbFileName) + "\"";
      //fileopener.Start();
      Process.Start("explorer.exe", "/select, \"" + Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), Program.DbFileName) + "\"");
    }

    private void EventsDataGridView_SelectionChanged(object sender, EventArgs e)
    {
      if (EventsDataGridView.SelectedRows.Count > 0)
      {
        EditToolStripMenuItem.Enabled = EventsDataGridView.SelectedRows[0].Cells[3].Value.ToString().Contains(" (usr_check)");
        DeleteToolStripMenuItem.Enabled = true;
      }
      else
      {
        EditToolStripMenuItem.Enabled = false;
        DeleteToolStripMenuItem.Enabled = false;
      }
    }

    private void SelectRangeToolStripMenuItem_Click(object sender, EventArgs e)
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
        RefreshEventDataGridView();
      }
      catch { }
    }
  }
}

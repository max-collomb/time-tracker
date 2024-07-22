using System.Globalization;
using System.Windows.Controls;

namespace time_tracker
{

  public partial class HistoryForm : Form
  {
    public HistoryForm()
    {
      InitializeComponent();
      SetRangeToolStripMenuItem_Click(ThisWeekToolStripMenuItem, new EventArgs());
    }

    public void RefreshEventDataGridView()
    {
      EventsDataGridView.Rows.Clear();
      List<Event> events = DataBase.GetEvents(null, FromDatePicker.Value.ToString("yyyy-MM-dd"), ToDatePicker.Value.ToString("yyyy-MM-dd"));
      for (int i = 0, length = events.Count; i < length; i++)
      {
        Event e = events[i];
        //EventsDataGridView.Rows.Add(new string[] { e.Id.ToString(), e.Date, e.Time, e.Type });
        EventsDataGridView.Rows.Insert(0, [e.Id.ToString(), e.Date, e.Time, e.Type]);
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
            ISOWeek.GetWeekOfYear(currentMonday).ToString(),
            currentMonday.ToString("yyyy-MM-dd"),
            TimeHelper.MinToHourMinStr(timeChecked)
          ]);
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
        RefreshEventDataGridView();
      }
      catch { }
    }

    private void ApplyButton_Click(object sender, EventArgs e)
    {
      RefreshEventDataGridView();
    }

    private void EventsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {
      var senderGrid = (DataGridView)sender;

      if ((senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn) && (e.RowIndex >= 0))
      {
        Event evt = new(
          Int64.Parse(senderGrid.Rows[e.RowIndex].Cells[0].Value.ToString() ?? "-1"),
          senderGrid.Rows[e.RowIndex].Cells[1].Value.ToString() ?? "",
          senderGrid.Rows[e.RowIndex].Cells[2].Value.ToString() ?? "",
          senderGrid.Rows[e.RowIndex].Cells[3].Value.ToString() ?? ""
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

    private void AddEventButton_Click(object sender, EventArgs e)
    {
      using (var eventForm = new EventForm(DateTime.Now.ToString("yyyy-MM-dd"), DateTime.Now.ToString("HH:mm"), true))
      {
        if (eventForm.ShowDialog(this) == DialogResult.OK)
        {
          DataBase.InsertEvent("usr_check", eventForm.Date, eventForm.Time);
          RefreshEventDataGridView();
        }
      }
    }

    private void EditToolStripMenuItem_Click(object sender, EventArgs e)
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
        }
      }
    }

    private void DeleteToolStripMenuItem_Click(object sender, EventArgs e)
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

    private void PredifinedButton_Paint(object sender, PaintEventArgs e)
    {
      if (button2.ContextMenuStrip != null)
      {
        int arrowX = button2.Width - Padding.Right - 14;
        int arrowY = (button2.Height / 2) - 1;

        Color color = Enabled ? ForeColor : SystemColors.ControlDark;
        using (Brush brush = new SolidBrush(color))
        {
          Point[] arrows = new Point[] { new Point(arrowX, arrowY), new Point(arrowX + 7, arrowY), new Point(arrowX + 3, arrowY + 4) };
          e.Graphics.FillPolygon(brush, arrows);
        }
      }
    }

    private void PredifinedButton_MouseDown(object sender, MouseEventArgs e)
    {
      if (button2.ContextMenuStrip != null && e.Button == MouseButtons.Left)
      {
        Point menuLocation = PointToClient(button2.PointToScreen(new Point(0, button2.Height)));
        button2.ContextMenuStrip.Show(this, menuLocation);
      }
    }

    private void TabControl_SelectedIndexChanged(object sender, EventArgs e)
    {
      if (TabControl.SelectedIndex == 0)
      {
        AddEventButton.Visible = true;
      }
      else
      {
        RefreshWeekDataGridView();
        AddEventButton.Visible = false;
      }
    }
  }
}

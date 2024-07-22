using Microsoft.Win32;
using Microsoft.WindowsAPICodePack.Taskbar;

namespace time_tracker
{
  public partial class MainForm : AnchoredForm
  {
    public List<Day> WeekDays { get; set; }
    public int TodayIdx { get; set; }
    public int HoveredDay { get; set; }
    public List<int> Targets { get; set; }
    public int WeekLoad { get; set; }
    public string CurrentTime { get; set; }
    public HistoryForm? HistoryForm { get; set; }
    public ThumbnailToolBarButton? ThumbnailButton { get; set; }
    public MainForm()
    {
      WeekDays = [];
      TodayIdx = -1;
      HoveredDay = -1;
      CurrentTime = "";
      Targets = [];
      DataBase.Initialize(Path.Join(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "time-tracker.sqlite"));
      InitializeComponent();
      LoadSettings();
      RefreshTimeData();
      SystemEvents.PowerModeChanged += OnPowerChange;
      SystemEvents.SessionEnding += OnSessionEnding;
    }

    private void OnPowerChange(Object sender, PowerModeChangedEventArgs e)
    {
      switch (e.Mode)
      {
        case PowerModes.Resume:
          DataBase.InsertEvent("sys_wakeup");
          break;
        case PowerModes.Suspend:
          DataBase.InsertEvent("sys_sleep");
          break;
      }
    }

    private void OnSessionEnding(Object sender, SessionEndingEventArgs e)
    {
      switch (e.Reason)
      {
        case SessionEndReasons.Logoff:
          DataBase.InsertEvent("sys_logoff");
          break;
        case SessionEndReasons.SystemShutdown:
          DataBase.InsertEvent("sys_shutdown");
          break;
      }
    }

    private void LoadSettings()
    {
      Targets = [
        Properties.Settings.Default.MondayTarget,
        Properties.Settings.Default.TuesdayTarget,
        Properties.Settings.Default.WednesdayTarget,
        Properties.Settings.Default.ThursdayTarget,
        Properties.Settings.Default.FridayTarget
        //TimeHelper.HourMinStrToMin(Properties.Settings.Default.MondayTarget),
        //TimeHelper.HourMinStrToMin(Properties.Settings.Default.TuesdayTarget),
        //TimeHelper.HourMinStrToMin(Properties.Settings.Default.WednesdayTarget),
        //TimeHelper.HourMinStrToMin(Properties.Settings.Default.ThursdayTarget),
        //TimeHelper.HourMinStrToMin(Properties.Settings.Default.FridayTarget)
      ];
      WeekLoad = Targets.Sum();
    }

    private void ClockInOutButton_Click(object? sender, EventArgs e)
    {
      DataBase.InsertEvent();
      RefreshTimeData();
    }

    private void ThumbnailButton_Click(object? sender, ThumbnailButtonClickedEventArgs e)
    {
      ClockInOutButton_Click(sender, new EventArgs());
    }

    private void MainForm_Load(object sender, EventArgs e)
    {
      DataBase.InsertEvent("sys_appstart");
      Rectangle bounds = new(Properties.Settings.Default.WindowPosition, Size);
      if (Screen.AllScreens.Any(screen => screen.WorkingArea.IntersectsWith(bounds)))
      {
        StartPosition = FormStartPosition.Manual;
        DesktopLocation = Properties.Settings.Default.WindowPosition;
      }
      if (TaskbarManager.IsPlatformSupported)
      {
        ThumbnailButton = new((WeekDays.Count > 0 && TodayIdx >= 0 && WeekDays[TodayIdx].IsInProgress) ? Properties.Resources.pause1 : Properties.Resources.play1, "");
        ThumbnailButton.Click += new EventHandler<ThumbnailButtonClickedEventArgs>(ThumbnailButton_Click);
        TaskbarManager.Instance.ThumbnailToolBars?.AddButtons(this.Handle, ThumbnailButton);
      }
    }

    private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
    {
      DataBase.CloseConnection();
      Properties.Settings.Default.WindowPosition = DesktopBounds.Location;
      Properties.Settings.Default.Save();
    }

    private void SecondTimer_Tick(object sender, EventArgs e)
    {
      string currentTime = DateTime.Now.Hour.ToString("00") + ":" + DateTime.Now.Minute.ToString("00");
      Text = currentTime + ":" + DateTime.Now.Second.ToString("00");
      if (currentTime != CurrentTime && TodayIdx >= 0)
      {
        CurrentTime = currentTime;
        WeekDays[TodayIdx].Refresh();
        DayValueLabel.Text = TimeHelper.MinToHourMinStr(WeekDays[TodayIdx].TimeChecked);
        MainFormToolTip.SetToolTip(DayValueLabel, DayValueLabel.Text + " / " + TimeHelper.MinToHourMinStr(Targets[TodayIdx]));
        int sum = 0;
        for (int i = 0; i <= TodayIdx; i++)
          sum += WeekDays[i].TimeChecked;
        WeekValueLabel.Text = TimeHelper.MinToHourMinStr(sum);
        MainFormToolTip.SetToolTip(WeekValueLabel, WeekValueLabel.Text + " / " + TimeHelper.MinToHourMinStr(WeekLoad));
        ChartPictureBox.Refresh();
      }

      //if (reminderEnabled && reminder != null && DateTime.Now.Hour == reminder.Hour && DateTime.Now.Minute == reminder.Minute)
      //{
      //    reminder = null;
      //    reminderEnabled = false;
      //    reminderDropDownBtn.BackgroundImage = global::kelio_client.Properties.Resources.notif_disabled;
      //    BeepBeep();
      //    if (MainForm.ActiveForm == null)
      //        FlashWindowUtil.FlashWindowEx(this.Handle);
      //}
      //if (date != DateTime.Now.DayOfYear)
      //{
      //    _ = Consult();
      //}

    }

    private void RefreshTimeData()
    {
      WeekDays = TimeHelper.GetDaysOfWeek(DateTime.Now);
      TodayIdx = -1;
      for (int i = 0; i < WeekDays.Count; i++)
        if (WeekDays[i].SqlDate == DateTime.Now.Date.ToString("yyyy-MM-dd"))
          TodayIdx = i;
      ClockInOutButton.Image = (WeekDays[TodayIdx].IsInProgress) ? Properties.Resources.pause : Properties.Resources.play;
      if (ThumbnailButton != null)
        ThumbnailButton.Icon = (WeekDays[TodayIdx].IsInProgress) ? Properties.Resources.pause1 : Properties.Resources.play1;

      CenterFlowLayoutPanel.Controls.Clear();
      bool isOut = false;
      foreach (Event check in WeekDays[TodayIdx].Checks)
      {
        Label checkLabel = new();
        checkLabel.Text = check.Time;
        checkLabel.AutoSize = true;
        checkLabel.Margin = new Padding(0, 0, 0, 0);
        checkLabel.ForeColor = isOut ? Color.Orange : Color.MediumTurquoise;
        checkLabel.ContextMenuStrip = CheckContextMenuStrip;
        checkLabel.DataContext = check;
        CenterFlowLayoutPanel.Controls.Add(checkLabel);
        isOut = !isOut;
      }

      CurrentTime = string.Empty;
      SecondTimer_Tick(new object(), new EventArgs());
      ChartPictureBox.Refresh();
    }

    private void ChartPictureBox_Paint(object sender, PaintEventArgs e)
    {
      string[] days = ["Lu", "Ma", "Me", "Je", "Ve"];
      int maxDone = 600;
      int margin = 10;
      int padding = 8;
      int chartWidth = 180;
      int chartHeight = 140;
      int labelHeight = 20;
      int barWidth = (chartWidth - margin) / 5;
      int barHeight = chartHeight - labelHeight - margin;
      Graphics g = e.Graphics;
      g.Clear(this.BackColor);
      Pen targetPen = new(Color.FromArgb(100, 187, 205), 1);
      Pen borderPen = new(Color.FromArgb(21, 29, 39));
      SolidBrush fillBrush = new(Color.FromArgb(37, 70, 77));
      for (int i = 0; i < 5; i++)
      {
        if (WeekDays[i].TimeChecked > 0)
        {
          int doneHeight = Math.Min(barHeight * WeekDays[i].TimeChecked / maxDone, barHeight);
          g.FillRectangle(fillBrush, new RectangleF(margin + i * barWidth + padding, labelHeight + barHeight - doneHeight, barWidth - 2 * padding, doneHeight));
        }
        g.DrawString(days[i], this.Font, fillBrush, margin + padding + i * barWidth, 2);
        g.DrawRectangle(borderPen, new RectangleF(margin + i * barWidth, 0, barWidth, barHeight + labelHeight));
        int targetHeight = barHeight * Targets[i] / maxDone;
        g.DrawLine(targetPen, margin + i * barWidth, labelHeight + barHeight - targetHeight, margin + (i + 1) * barWidth, labelHeight + barHeight - targetHeight);
      }
    }

    private void ChartPictureBox_MouseLeave(object sender, EventArgs e)
    {
      HoveredDay = -1;
      MainFormToolTip.SetToolTip(ChartPictureBox, string.Empty);
    }

    private void ChartPictureBox_MouseMove(object sender, MouseEventArgs e)
    {
      int margin = 10;
      int chartWidth = 180;
      int barWidth = (chartWidth - margin) / 5;

      int day = -1;
      string tooltipContent = string.Empty;

      if (e.X >= margin)
      {
        day = (e.X - margin) / barWidth;
        if (day >= 0 && day < 5)
        {
          tooltipContent = WeekDays[day].Date.ToString("ddd dd/MM");
          if (WeekDays[day].TimeChecked > 0)
            tooltipContent += "\n" + TimeHelper.MinToHourMinStr(WeekDays[day].TimeChecked) + " / " + TimeHelper.MinToHourMinStr(Targets[day]);
          if (WeekDays[day].Checks.Count > 0)
          {
            tooltipContent += "\n";
            int i = 0;
            foreach (Event check in WeekDays[day].Checks)
            {
              tooltipContent += (i % 2 == 0 ? "\n[" : "| ") + check.Time + (i % 2 == 0 ? " " : "]");
              i++;
            }
            if (WeekDays[day].IsInProgress && i % 2 == 1)
              tooltipContent += "| --:--]";
          }
        }
      }
      if (day != HoveredDay)
      {
        HoveredDay = day;
        MainFormToolTip.SetToolTip(ChartPictureBox, tooltipContent);
      }
    }

    private void DeleteToolStripMenuItem_Click(object sender, EventArgs e)
    {
      Event? check = (Event?)(((ContextMenuStrip?)((ToolStripMenuItem)sender).Owner)?.SourceControl)?.DataContext;
      if (check != null)
      {
        DataBase.DeleteEvent(check);
        RefreshTimeData();
      }
    }

    private void EditToolStripMenuItem_Click(object sender, EventArgs e)
    {
      Event? check = (Event?)(((ContextMenuStrip?)((ToolStripMenuItem)sender).Owner)?.SourceControl)?.DataContext;
      if (check != null)
      {
        using (var eventForm = new EventForm(check.Date, check.Time, false))
        {
          if (eventForm.ShowDialog(this) == DialogResult.OK)
          {
            DataBase.UpdateEvent(check, eventForm.Date, eventForm.Time);
            RefreshTimeData();
          }
        }
      }

    }

    private void OptionsButton_Click(object sender, EventArgs e)
    {
      using (SettingsForm settingsForm = new SettingsForm())
      {
        settingsForm.ShowDialog(this);
        LoadSettings();
        RefreshTimeData();
      }
    }

    void HistoryForm_Closed(object? sender, FormClosedEventArgs e)
    {
      HistoryForm = null;
      RefreshTimeData();
    }

    private void DetailsButton_Click(object sender, EventArgs e)
    {
      HistoryForm ??= new HistoryForm();
      HistoryForm.FormClosed += new FormClosedEventHandler(HistoryForm_Closed);
      HistoryForm.Show();
    }

  }
}

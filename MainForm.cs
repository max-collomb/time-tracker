using Microsoft.Win32;
using Microsoft.WindowsAPICodePack.Taskbar;
using System.Drawing.Drawing2D;
using System.Globalization;

namespace time_tracker
{
  public partial class MainForm : AnchoredForm
  {
    public List<Day> WeekDays { get; set; }
    public int TodayIdx { get; set; }
    public int HoveredDay { get; set; }
    public List<int> Targets { get; set; }
    public List<int> Pauses { get; set; }
    public int WeekLoad { get; set; }
    public int CurrentDate { get; set; }
    public string CurrentTime { get; set; }
    public bool? IsInProgress { get; set; }
    public HistoryForm? HistoryForm { get; set; }
    public ThumbnailToolBarButton? ThumbnailButton { get; set; }
    public int DayContextMenu { get; set; }
    public bool AutoCreateReminder { get; set; }
    public bool IsReminderEnabled { get; set; }
    public string Reminder { get; set; }
    public MainForm()
    {
      WeekDays = [];
      TodayIdx = -1;
      HoveredDay = -1;
      CurrentTime = "";
      CurrentDate = -1;
      IsInProgress = null;
      IsReminderEnabled = false;
      Reminder = string.Empty;
      AutoCreateReminder = Properties.Settings.Default.AutoReminder;
      Targets = [];
      Pauses = [];
      string dbFileName = Path.Join(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), Program.DbFileName);
      bool openSettingsForm = !File.Exists(dbFileName);
      DataBase.Initialize(dbFileName);
      InitializeComponent();
      DataBase.InsertDaysOff();
      LoadSettings();
      RefreshTimeData();
      SystemEvents.PowerModeChanged += OnPowerChange;
      SystemEvents.SessionEnding += OnSessionEnding;
      SystemEvents.SessionSwitch += OnSessionSwitch;
      if (openSettingsForm)
        OptionsButton_Click(OptionsButton, new EventArgs());
    }

    protected override void WndProc(ref Message m)
    {
      if (m.Msg == NativeMethods.WM_SHOWME)
      {
        if (WindowState == FormWindowState.Minimized)
          WindowState = FormWindowState.Normal;
        bool top = TopMost; // get our current "TopMost" value (ours will always be false though)
        TopMost = true; // make our form jump to the top of everything
        TopMost = top; // set it back to whatever it was
      }
      base.WndProc(ref m);
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

    private void OnSessionSwitch(Object sender, SessionSwitchEventArgs e)
    {
      switch (e.Reason)
      {
        case SessionSwitchReason.SessionLock:
          DataBase.InsertEvent("sess_lock");
          break;
        case SessionSwitchReason.SessionUnlock:
          DataBase.InsertEvent("sess_unlock");
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
        Properties.Settings.Default.FridayTarget,
        0,
        0,
      ];
      Pauses = [
        Properties.Settings.Default.MondayPause,
        Properties.Settings.Default.TuesdayPause,
        Properties.Settings.Default.WednesdayPause,
        Properties.Settings.Default.ThursdayPause,
        Properties.Settings.Default.FridayPause,
        0,
        0,
      ];
      WeekLoad = Targets.Sum();
      Day.WeekLoad = WeekLoad;
    }

    private void ClockInOutButton_Click(object? sender, EventArgs e)
    {
      System.Media.SoundPlayer player = new()
      {
        Stream = (WeekDays[TodayIdx].Checks.Count % 2 == 0) ? Properties.Resources.on : Properties.Resources.off
      };
      player.Play();
      DataBase.InsertEvent();
      AutoCreateReminder = Properties.Settings.Default.AutoReminder;
      RefreshTimeData();
      if (WeekDays[TodayIdx].Checks.Count == 1) // seulement au premier badgeage du jour
      {
        Tuple<int, string, string> previousDayDetails = DataBase.GetPreviousDayChecks(DateTime.Now);
        Annotation? annotation = DataBase.GetAnnotation(previousDayDetails.Item3);
        if ((previousDayDetails.Item1 > 0) && ((previousDayDetails.Item1 < 4 && annotation == null) || previousDayDetails.Item1 % 2 == 1))
        {
          MessageBox.Show(
            "Le nombre de badgeages est incorrect pour le " + DateTime.ParseExact(previousDayDetails.Item3, "yyyy-MM-dd", CultureInfo.InvariantCulture).ToString("dddd dd/MM/yyyy") + "\n" +
            previousDayDetails.Item1.ToString() + " badgeage" + (previousDayDetails.Item1 > 1 ? "s" : "") + " : " + previousDayDetails.Item2 + "\n\n" +
            "Corrigez la situation dans la fenêtre d'historique",
            "Anomalie détectée",
            MessageBoxButtons.OK
          );
        }
      }
    }

    private void ThumbnailButton_Click(object? sender, ThumbnailButtonClickedEventArgs e)
    {
      ClockInOutButton_Click(sender, new EventArgs());
    }

    private void MainForm_Load(object sender, EventArgs e)
    {
      DataBase.InsertEvent("app_start");
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
      if (CurrentDate != DateTime.Now.DayOfYear)
      {
        AutoCreateReminder = Properties.Settings.Default.AutoReminder;
        DataBase.InsertDaysOff();
        RefreshTimeData();
        return;
      }
      if (currentTime != CurrentTime && TodayIdx >= 0)
      {
        CurrentTime = currentTime;
        WeekDays[TodayIdx].Refresh();
        DayValueLabel.Text = TimeHelper.MinToHourMinStr(WeekDays[TodayIdx].TimeChecked + WeekDays[TodayIdx].TimeOff);
        MainFormToolTip.SetToolTip(DayValueLabel, DayValueLabel.Text + " / " + TimeHelper.MinToHourMinStr(Targets[TodayIdx]));
        int sum = 0;
        for (int i = 0; i <= TodayIdx; i++)
          sum += WeekDays[i].TimeChecked + WeekDays[i].TimeOff;
        for (int i = TodayIdx + 1; i < WeekDays.Count; i++)
          sum += WeekDays[i].TimeOff;
        WeekValueLabel.Text = TimeHelper.MinToHourMinStr(sum);
        MainFormToolTip.SetToolTip(WeekValueLabel, WeekValueLabel.Text + " / " + TimeHelper.MinToHourMinStr(WeekLoad));
        ChartPictureBox.Refresh();

        if (IsReminderEnabled && Reminder != null && DateTime.Now.ToString("HH:mm") == Reminder)
        {
          Reminder = string.Empty;
          IsReminderEnabled = false;
          RefreshTimeData();
          BeepBeep();
          if (TaskbarManager.IsPlatformSupported && MainForm.ActiveForm == null)
          {
            TaskbarManager.Instance.SetOverlayIcon(Properties.Resources.alert, "Il est temps de badger");
          }
        }
      }
    }

    private void BeepBeep()
    {
      System.Media.SoundPlayer player = new()
      {
        Stream = Properties.Resources.notif
      };
      player.Play();
    }

    private void RefreshTimeData()
    {
      WeekDays = TimeHelper.GetDaysOfWeek(DateTime.Now);
      TodayIdx = -1;
      for (int i = 0; i < WeekDays.Count; i++)
        if (WeekDays[i].SqlDate == DateTime.Now.Date.ToString("yyyy-MM-dd"))
          TodayIdx = i;
      if (IsInProgress != WeekDays[TodayIdx].IsInProgress)
      {
        IsInProgress = WeekDays[TodayIdx].IsInProgress;
        ClockInOutButton.Image = IsInProgress == true ? Properties.Resources.pause : Properties.Resources.play;
        if (TaskbarManager.IsPlatformSupported && ThumbnailButton != null)
          try
          {
            ThumbnailButton.Icon = IsInProgress == true ? Properties.Resources.pause1 : Properties.Resources.play1;
          }
          catch { }
      }

      CenterFlowLayoutPanel.Controls.Clear();
      bool isOut = false;
      foreach (Event check in WeekDays[TodayIdx].Checks)
      {
        Label checkLabel = new()
        {
          Text = check.Time,
          AutoSize = true,
          Margin = new Padding(0, 0, 0, 0),
          ForeColor = isOut ? Color.Orange : Color.MediumTurquoise,
          ContextMenuStrip = CheckContextMenuStrip,
          DataContext = check
        };
        checkLabel.DoubleClick += CheckLabelDoubleClick;
        CenterFlowLayoutPanel.Controls.Add(checkLabel);
        MainFormToolTip.SetToolTip(checkLabel, (isOut ? "Sortie" : "Entrée") + "\n(Double-clic ou menu contextuel pour modifier)");
        isOut = !isOut;
      }
      if (Properties.Settings.Default.AutoReminder)
      {
        List<string> targetSteps = GetTargetSteps();
        bool first = true;
        foreach (string step in targetSteps)
        {
          if (first && Reminder == string.Empty && AutoCreateReminder)
          {
            Reminder = step;
            IsReminderEnabled = true;
            AutoCreateReminder = false;
          }
          string labelText = step;
          if (Reminder == step)
            labelText = char.ConvertFromUtf32(int.Parse(IsReminderEnabled ? "1F514" : "1F515", System.Globalization.NumberStyles.HexNumber)) + step;
          Label stepLabel = new()
          {
            Text = labelText,
            AutoSize = true,
            Margin = new Padding(0, 0, 0, 0),
            ForeColor = Color.FromArgb(96, 96, 96),
            DataContext = step
          };
          if (first)
          {
            stepLabel.DoubleClick += ReminderLabelDoubleClick;
            MainFormToolTip.SetToolTip(stepLabel, "Double-clic pour modifier le rappel");
          }
          CenterFlowLayoutPanel.Controls.Add(stepLabel);
          first = false;
        }
      }
      CurrentTime = string.Empty;
      CurrentDate = DateTime.Now.DayOfYear;
      SecondTimer_Tick(new object(), new EventArgs());
      ChartPictureBox.Refresh();
    }

    private List<string> GetTargetSteps()
    {
      int count = WeekDays[TodayIdx].Checks.Count;
      bool isHalfDayOff = WeekDays[TodayIdx].Annotation?.Type == "half_day_off";
      List<string> steps = new();
      if (count == 0 || (count > 3 && count % 2 == 0))
        return steps;
      if (isHalfDayOff && count == 2)
        return steps;
      DateTime lastCheck = DateTime.ParseExact(WeekDays[TodayIdx].Checks[count - 1].Time, "HH:mm", CultureInfo.InvariantCulture);
      int target = 0;
      for (int i = 0; i <= TodayIdx; i++)
      {
        target += Targets[i] - WeekDays[i].TimeChecked - WeekDays[i].TimeOff;
      }
      if (lastCheck.Hour < 12 && Pauses[TodayIdx] > 0 && !isHalfDayOff)
      {
        // on ajoute la pause de midi
        string pauseStart = (IsReminderEnabled && !string.IsNullOrEmpty(Reminder)) ? Reminder : (Pauses[TodayIdx] > 100 ? "12:00" : "12:15");
        target += Pauses[TodayIdx];
        steps.Add(pauseStart);
        steps.Add(DateTime.ParseExact(pauseStart, "HH:mm", CultureInfo.InvariantCulture).AddMinutes(Pauses[TodayIdx]).ToString("HH:mm"));
      }
      if (count % 2 == 1)
      {
        if (IsReminderEnabled && !string.IsNullOrEmpty (Reminder))
          steps.Add(Reminder);
        else if (target > 0)
          steps.Add(DateTime.Now.AddMinutes(target).ToString("HH:mm"));
      }
      else if (lastCheck.Hour >= 12 && lastCheck.Hour < 14 && Pauses[TodayIdx] > 0 && !isHalfDayOff && target > 0)
      {
        steps.Add(lastCheck.AddMinutes(Pauses[TodayIdx]).ToString("HH:mm"));
        steps.Add(DateTime.Now.AddMinutes(target + Pauses[TodayIdx]).ToString("HH:mm"));
      }
      return steps;
    }

    private void ChartPictureBox_Paint(object sender, PaintEventArgs e)
    {
      string[] days = ["Lu", "Ma", "Me", "Je", "Ve", "Sa", "Di"];
      int maxDone = 600;
      int margin = 10;
      int padding = 8;
      int chartWidth = ChartPictureBox.Width - 1;
      int chartHeight = ChartPictureBox.Height;
      int labelHeight = 20;
      int barWidth = (chartWidth - margin) / Math.Max(5, TodayIdx + 1);
      int barHeight = chartHeight - labelHeight - margin;
      Graphics g = e.Graphics;
      g.Clear(this.BackColor);
      Pen targetPen = new(Color.FromArgb(100, 187, 205), 1);
      Pen borderPen = new(Color.FromArgb(21, 29, 39));
      SolidBrush fillBrush = new(Color.FromArgb(37, 70, 77));
      SolidBrush fillBrushError = new(Color.FromArgb(77, 37, 37));
      HatchBrush hatchBrush = new(HatchStyle.WideUpwardDiagonal, Color.FromArgb(37, 70, 77), BackColor);
      SolidBrush fillBrushHl = new(Color.FromArgb(100, 187, 205));
      for (int i = 0; i < Math.Max(5, TodayIdx + 1); i++)
      {
        int offHeight = 0;
        if (WeekDays[i].TimeOff > 0)
        {
          offHeight = Math.Min(barHeight * WeekDays[i].TimeOff / maxDone, barHeight);
          g.FillRectangle(hatchBrush, new RectangleF(margin + i * barWidth + padding, labelHeight + barHeight - offHeight, barWidth - 2 * padding, offHeight));
        }
        if (WeekDays[i].TimeChecked > 0)
        {
          bool hasAnomaly = (i != TodayIdx) && (WeekDays[i].Checks.Count > 0) && ((WeekDays[i].Checks.Count < 4 && WeekDays[i].Annotation == null) || WeekDays[i].Checks.Count % 2 == 1);
          int doneHeight = Math.Min(barHeight * WeekDays[i].TimeChecked / maxDone, barHeight);
          g.FillRectangle(
            hasAnomaly ? fillBrushError : fillBrush,
            new RectangleF(
              margin + i * barWidth + padding,
              labelHeight + barHeight - doneHeight - offHeight,
              barWidth - 2 * padding,
              doneHeight
            )
          );
        }
        g.DrawString(days[i], this.Font, i == TodayIdx ? fillBrushHl : fillBrush, new RectangleF(margin + i * barWidth, 2, barWidth, barHeight), new StringFormat() { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Near });
        //margin + padding + i * barWidth, 2);
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
      int chartWidth = ChartPictureBox.Width - 1;
      int barWidth = (chartWidth - margin) / Math.Max(5, TodayIdx + 1);

      int day = -1;
      string tooltipContent = string.Empty;

      if (e.X >= margin)
      {
        day = (e.X - margin) / barWidth;
        if (day >= 0 && day < WeekDays.Count)
        {
          tooltipContent = WeekDays[day].Date.ToString("ddd dd/MM");
          if (WeekDays[day].TimeChecked + WeekDays[day].TimeOff > 0)
            tooltipContent += "\n" + TimeHelper.MinToHourMinStr(WeekDays[day].TimeChecked + WeekDays[day].TimeOff) + " / " + TimeHelper.MinToHourMinStr(Targets[day]);
          bool hasAnomaly = (day != TodayIdx) && (WeekDays[day].Checks.Count > 0) && ((WeekDays[day].Checks.Count < 4 && WeekDays[day].Annotation == null) || WeekDays[day].Checks.Count % 2 == 1);
          if (hasAnomaly)
          {
            tooltipContent += "\n\nANOMALIE : " + WeekDays[day].Checks.Count + " badgeage" + (WeekDays[day].Checks.Count > 1 ? "s" : "") +
              "\n(nombre pair " + char.ConvertFromUtf32(int.Parse("2265", System.Globalization.NumberStyles.HexNumber)) + " 4 attendu)";
          }
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

    private void CheckLabelDoubleClick(object? sender, EventArgs e)
    {
      Event? check = (Event?)((Label?)sender)?.DataContext;
      if (check != null)
      {
        using var eventForm = new EventForm(check.Date, check.Time, false);
        if (eventForm.ShowDialog(this) == DialogResult.OK)
        {
          DataBase.UpdateEvent(check, eventForm.Date, eventForm.Time);
          RefreshTimeData();
        }
      }
    }

    private void ReminderLabelDoubleClick(object? sender, EventArgs e)
    {
      string? time = (string?)((Label?)sender)?.DataContext;
      if (!string.IsNullOrEmpty(time))
      {
        using ReminderForm reminderForm = new(time);
        reminderForm.ShowDialog(this);
        Reminder = reminderForm.IsEnabled ? reminderForm.Time : string.Empty;
        IsReminderEnabled = reminderForm.IsEnabled;
        RefreshTimeData();
      }
    }

    private void OptionsButton_Click(object sender, EventArgs e)
    {
      using SettingsForm settingsForm = new();
      settingsForm.ShowDialog(this);
      LoadSettings();
      RefreshTimeData();
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

    private void ChartPictureBox_MouseDown(object sender, MouseEventArgs e)
    {
      if (e.Button == MouseButtons.Right)
      {
        DayContextMenu = -1;
        int margin = 10;
        int chartWidth = ChartPictureBox.Width - 1;
        int barWidth = (chartWidth - margin) / Math.Max(5, TodayIdx + 1);

        int day = -1;
        string tooltipContent = string.Empty;

        if (e.X >= margin)
        {
          day = (e.X - margin) / barWidth;
          if (day >= 0 && day < WeekDays.Count)
          {
            DayContextMenu = day;
            DayDateToolStripMenuItem.Text = WeekDays[day].Date.ToString("dddd dd/MM");
            DayHalfOffToolStripMenuItem.Checked = WeekDays[day].Annotation?.Type == "half_day_off";
            DayOffToolStripMenuItem.Checked = WeekDays[day].Annotation?.Type == "day_off";
          }
        }
      }
    }

    private void DayOffToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (DayContextMenu >= 0 && DayContextMenu < WeekDays.Count)
      {
        string type = (sender == DayHalfOffToolStripMenuItem) ? "half_day_off" : "day_off";
        if (WeekDays[DayContextMenu].Annotation?.Type == type)
          DataBase.DeleteAnnotation(WeekDays[DayContextMenu].Annotation!);
        else
        {
          if (WeekDays[DayContextMenu].Annotation != null)
            DataBase.UpdateAnnotation(WeekDays[DayContextMenu].Annotation!, WeekDays[DayContextMenu].Annotation!.Date, type, "");
          else
            DataBase.InsertAnnotation(WeekDays[DayContextMenu].SqlDate, type, "");
        }
        RefreshTimeData();
      }
    }

    private void MainForm_KeyDown(object sender, KeyEventArgs e)
    {
      if (e.KeyCode == Keys.F5)
      {
        RefreshTimeData();
      }
    }

    private void ToggleReminderToolStripMenuItem_Click(object sender, EventArgs e)
    {
      IsReminderEnabled = !IsReminderEnabled;
      RefreshTimeData();
    }

    private void MainForm_Activated(object sender, EventArgs e)
    {
      if (TaskbarManager.IsPlatformSupported)
      {
        TaskbarManager.Instance.SetOverlayIcon(null, "");
      }
    }
  }
}

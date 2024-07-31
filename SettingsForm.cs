using Microsoft.Win32;
using System.Diagnostics;

namespace time_tracker
{
  public partial class SettingsForm : Form
  {
    public SettingsForm()
    {
      InitializeComponent();
    }

    private void SettingsForm_Load(object sender, EventArgs e)
    {
      RegistryKey? rkApp = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
      MondayMaskedTextBox.Text = TimeHelper.MinToHourMinStr(Properties.Settings.Default.MondayTarget);
      TuesdayMaskedTextBox.Text = TimeHelper.MinToHourMinStr(Properties.Settings.Default.TuesdayTarget);
      WednesdayMaskedTextBox.Text = TimeHelper.MinToHourMinStr(Properties.Settings.Default.WednesdayTarget);
      ThursdayMaskedTextBox.Text = TimeHelper.MinToHourMinStr(Properties.Settings.Default.ThursdayTarget);
      FridayMaskedTextBox.Text = TimeHelper.MinToHourMinStr(Properties.Settings.Default.FridayTarget);
      MondayPauseUpDown.Value = Properties.Settings.Default.MondayPause;
      TuesdayPauseUpDown.Value = Properties.Settings.Default.TuesdayPause;
      WednesdayPauseUpDown.Value = Properties.Settings.Default.WednesdayPause;
      ThursdayPauseUpDown.Value = Properties.Settings.Default.ThursdayPause;
      FridayPauseUpDown.Value = Properties.Settings.Default.FridayPause;
      AutoReminderCheckBox.Checked = Properties.Settings.Default.AutoReminder;
      AutoStartCheckBox.Checked = rkApp?.GetValue("TimeTracker") != null;
    }

    private void SaveButton_Click(object sender, EventArgs e)
    {
      RegistryKey? rkApp = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
      Properties.Settings.Default.MondayTarget = TimeHelper.HourMinStrToMin(MondayMaskedTextBox.Text);
      Properties.Settings.Default.TuesdayTarget = TimeHelper.HourMinStrToMin(TuesdayMaskedTextBox.Text);
      Properties.Settings.Default.WednesdayTarget = TimeHelper.HourMinStrToMin(WednesdayMaskedTextBox.Text);
      Properties.Settings.Default.ThursdayTarget = TimeHelper.HourMinStrToMin(ThursdayMaskedTextBox.Text);
      Properties.Settings.Default.FridayTarget = TimeHelper.HourMinStrToMin(FridayMaskedTextBox.Text);
      Properties.Settings.Default.MondayPause = (int)MondayPauseUpDown.Value;
      Properties.Settings.Default.TuesdayPause = (int)TuesdayPauseUpDown.Value;
      Properties.Settings.Default.WednesdayPause = (int)WednesdayPauseUpDown.Value;
      Properties.Settings.Default.ThursdayPause = (int)ThursdayPauseUpDown.Value;
      Properties.Settings.Default.FridayPause = (int)FridayPauseUpDown.Value;
      Properties.Settings.Default.AutoReminder = AutoReminderCheckBox.Checked;
#if !DEBUG
      if (rkApp != null)
        if (AutoStartCheckBox.Checked)
          rkApp.SetValue("TimeTracker", Application.ExecutablePath);
        else
          rkApp.DeleteValue("TimeTracker", false);
#endif
    }

    private void AutoReminderCheckBox_Click(object sender, EventArgs e)
    {

    }

    private void GithubLinkLabel_Click(object sender, EventArgs e)
    {
      Process.Start(new ProcessStartInfo { FileName = "https://github.com/max-collomb/time-tracker", UseShellExecute = true });
    }

  }
}

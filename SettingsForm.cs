using Microsoft.Win32;

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
      Properties.Settings.Default.AutoReminder = AutoReminderCheckBox.Checked;
#if !DEBUG
      if (rkApp != null)
        if (AutoStartCheckBox.Checked)
          rkApp.SetValue("TimeTracker", Application.ExecutablePath);
        else
          rkApp.DeleteValue("TimeTracker", false);
#endif
    }
  }
}

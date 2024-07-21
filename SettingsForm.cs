using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
      MondayTimeUpDdown.Value = Properties.Settings.Default.MondayTarget;
      TuesdayTimeUpDdown.Value = Properties.Settings.Default.TuesdayTarget;
      WednesdayTimeUpDdown.Value = Properties.Settings.Default.WednesdayTarget;
      ThursdayTimeUpDdown.Value = Properties.Settings.Default.ThursdayTarget;
      FridayTimeUpDdown.Value = Properties.Settings.Default.FridayTarget;
      AutoReminderCheckBox.Checked = Properties.Settings.Default.AutoReminder;
    }

    private void SaveButton_Click(object sender, EventArgs e)
    {
      Properties.Settings.Default.MondayTarget = (int) MondayTimeUpDdown.Value;
      Properties.Settings.Default.TuesdayTarget = (int) TuesdayTimeUpDdown.Value;
      Properties.Settings.Default.WednesdayTarget = (int) WednesdayTimeUpDdown.Value;
      Properties.Settings.Default.ThursdayTarget = (int) ThursdayTimeUpDdown.Value;
      Properties.Settings.Default.FridayTarget = (int) FridayTimeUpDdown.Value;
      Properties.Settings.Default.AutoReminder = AutoReminderCheckBox.Checked;
    }
  }
}

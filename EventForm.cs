using System.Globalization;

namespace time_tracker
{
  public partial class EventForm : Form
  {
    public string Date { get; set; }
    public string Time { get; set; }

    public EventForm(string date, string time, bool dateEnabled)
    {
      Date = date;
      Time = time;
      InitializeComponent();
      DatePicker.Enabled = dateEnabled;
      DatePicker.Value = DateTime.ParseExact(Date, "yyyy-MM-dd", CultureInfo.InvariantCulture);
      TimeMaskedTextBox.Text = Time;
    }

    private void EventForm_Load(object sender, EventArgs e)
    {
      ActiveControl = TimeMaskedTextBox;
    }

    private void SaveButton_Click(object sender, EventArgs e)
    {
      Date = DatePicker.Value.ToString("yyyy-MM-dd");
      Time = TimeMaskedTextBox.Text;
    }

    private void TimeMaskedTextBox_KeyDown(object sender, KeyEventArgs e)
    {
      int delta = 0;
      if (e.KeyCode == Keys.Up || e.KeyCode == Keys.Add)
        delta = 1;
      else if (e.KeyCode == Keys.Down || e.KeyCode == Keys.Subtract)
        delta = -1;
      if (e.Shift)
        delta *= 5;
      else if (e.Control)
        delta *= 15;
      if (delta != 0)
        try
        {
          e.Handled = true;
          TimeMaskedTextBox.Text = DateTime.ParseExact(TimeMaskedTextBox.Text, "HH:mm", CultureInfo.InvariantCulture)
                                           .AddMinutes(delta).ToString("HH:mm");
        }
        catch { }
    }

    private void TimeMaskedTextBox_Enter(object sender, EventArgs e)
    {
      BeginInvoke((Action)delegate { ((MaskedTextBox)sender).SelectAll(); });
    }
  }
}

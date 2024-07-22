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
      TimePicker.Value = DateTime.ParseExact(Time, "HH:mm", CultureInfo.InvariantCulture);
    }

    private void EventForm_Load(object sender, EventArgs e)
    {
    }

    private void SaveButton_Click(object sender, EventArgs e)
    {
      Date = DatePicker.Value.ToString("yyyy-MM-dd");
      Time = TimePicker.Value.ToString("HH:mm");
    }
  }
}

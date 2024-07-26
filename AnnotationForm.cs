using System.Globalization;

namespace time_tracker
{
  public partial class AnnotationForm : Form
  {
    public string Date { get; set; }
    public bool IsHalfDay { get; set; }
    public string Description { get; set; }

    public AnnotationForm(string date, bool isHalfDay, string description)
    {
      Date = date;
      IsHalfDay = isHalfDay;
      Description = description;
      InitializeComponent();
      DatePicker.Value = DateTime.ParseExact(Date, "yyyy-MM-dd", CultureInfo.InvariantCulture);
      FullDayRadioButton.Checked = !IsHalfDay;
      HalfDayRadioButton.Checked = IsHalfDay;
      DescriptionTextBox.Text = Description;
    }

    private void EventForm_Load(object sender, EventArgs e)
    {
    }

    private void SaveButton_Click(object sender, EventArgs e)
    {
      Date = DatePicker.Value.ToString("yyyy-MM-dd");
      IsHalfDay = HalfDayRadioButton.Checked;
      Description = DescriptionTextBox.Text;
    }

  }
}

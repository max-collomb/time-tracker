using System.Globalization;

namespace time_tracker
{
  public partial class ReminderForm : Form
  {
    public string Time { get; set; }
    public bool IsEnabled { get; set; }

    public ReminderForm(string time)
    {
      Time = time;
      InitializeComponent();
      TimeMaskedTextBox.Text = Time;
      IsEnabled = false;
    }

    public void ShowDebug(string debugInfo) {
      ClientSize = new Size(576, 448);
      DebugRichTextBox.Visible = true;
      DebugRichTextBox.Height = 400;
      DebugRichTextBox.WordWrap = false;
      DebugRichTextBox.Text = debugInfo;
    }

    private void EventForm_Load(object sender, EventArgs e)
    {
      ActiveControl = TimeMaskedTextBox;
    }

    private void SaveButton_Click(object sender, EventArgs e)
    {
      Time = TimeMaskedTextBox.Text;
      IsEnabled = true;
    }

    private void CancelFormButton_Click(object sender, EventArgs e)
    {
      Time = TimeMaskedTextBox.Text;
      IsEnabled = false;
    }

    private void TimeMaskedTextBox_KeyDown(object sender, KeyEventArgs e)
    {
      if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Escape)
      {
        Time = TimeMaskedTextBox.Text;
        IsEnabled = e.KeyCode == Keys.Enter;
        Close();
        return;
      }
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

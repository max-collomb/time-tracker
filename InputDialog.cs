using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace time_tracker
{
  internal static class InputDialog
  {
    // https://stackoverflow.com/a/17546909/1767942
    public static DialogResult Show(ref string input)
    {
      Size size = new(200, 70);
      Form inputBox = new()
      {
        FormBorderStyle = FormBorderStyle.FixedDialog,
        ClientSize = size,
        Text = "Modifier",
        StartPosition = FormStartPosition.CenterParent,
      };

      TextBox textBox = new()
      {
        Size = new(size.Width - 10, 23),
        Location = new(5, 5),
        Text = input,
        BorderStyle = BorderStyle.FixedSingle,
        BackColor = Color.Black,
        ForeColor = Color.White,
      };
      inputBox.Controls.Add(textBox);

      Button okButton = new()
      {
        DialogResult = DialogResult.OK,
        Name = "okButton",
        Size = new(75, 23),
        Text = "&OK",
        Location = new(size.Width - 80, 39),
        ForeColor = SystemColors.ActiveCaption,
      };
      inputBox.Controls.Add(okButton);

      Button cancelButton = new()
      {
        DialogResult = DialogResult.Cancel,
        Name = "cancelButton",
        Size = new(75, 23),
        Text = "&Annuler",
        Location = new(size.Width - 80 - 80, 39),
        ForeColor = SystemColors.ActiveCaption,
      };
      inputBox.Controls.Add(cancelButton);

      inputBox.AcceptButton = okButton;
      inputBox.CancelButton = cancelButton;

      DialogResult result = inputBox.ShowDialog();
      input = textBox.Text;
      return result;
    }
  }
}

namespace time_tracker
{
  partial class ReminderForm
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      TimeMaskedTextBox = new MaskedTextBox();
      CancelFormButton = new Button();
      SaveButton = new Button();
      SpacePanel = new Panel();
      SuspendLayout();
      // 
      // TimeMaskedTextBox
      // 
      TimeMaskedTextBox.BorderStyle = BorderStyle.FixedSingle;
      TimeMaskedTextBox.Dock = DockStyle.Left;
      TimeMaskedTextBox.Location = new Point(10, 10);
      TimeMaskedTextBox.Mask = "00:00";
      TimeMaskedTextBox.Name = "TimeMaskedTextBox";
      TimeMaskedTextBox.Size = new Size(78, 23);
      TimeMaskedTextBox.TabIndex = 2;
      TimeMaskedTextBox.ValidatingType = typeof(DateTime);
      TimeMaskedTextBox.Enter += TimeMaskedTextBox_Enter;
      TimeMaskedTextBox.KeyDown += TimeMaskedTextBox_KeyDown;
      // 
      // CancelFormButton
      // 
      CancelFormButton.DialogResult = DialogResult.Cancel;
      CancelFormButton.Dock = DockStyle.Right;
      CancelFormButton.FlatAppearance.BorderColor = SystemColors.ButtonShadow;
      CancelFormButton.FlatStyle = FlatStyle.Flat;
      CancelFormButton.ForeColor = Color.FromArgb(192, 0, 0);
      CancelFormButton.Location = new Point(108, 10);
      CancelFormButton.Name = "CancelFormButton";
      CancelFormButton.Size = new Size(74, 28);
      CancelFormButton.TabIndex = 4;
      CancelFormButton.Text = "Supprimer";
      CancelFormButton.UseVisualStyleBackColor = true;
      CancelFormButton.Click += CancelFormButton_Click;
      // 
      // SaveButton
      // 
      SaveButton.DialogResult = DialogResult.OK;
      SaveButton.Dock = DockStyle.Right;
      SaveButton.FlatAppearance.BorderColor = SystemColors.ButtonShadow;
      SaveButton.FlatStyle = FlatStyle.Flat;
      SaveButton.ForeColor = Color.Green;
      SaveButton.Location = new Point(192, 10);
      SaveButton.Name = "SaveButton";
      SaveButton.Size = new Size(74, 28);
      SaveButton.TabIndex = 5;
      SaveButton.Text = "Valider";
      SaveButton.UseVisualStyleBackColor = true;
      SaveButton.Click += SaveButton_Click;
      // 
      // SpacePanel
      // 
      SpacePanel.Dock = DockStyle.Right;
      SpacePanel.Location = new Point(182, 10);
      SpacePanel.Name = "SpacePanel";
      SpacePanel.Size = new Size(10, 28);
      SpacePanel.TabIndex = 6;
      // 
      // ReminderForm
      // 
      AutoScaleDimensions = new SizeF(7F, 15F);
      AutoScaleMode = AutoScaleMode.Font;
      ClientSize = new Size(276, 48);
      Controls.Add(CancelFormButton);
      Controls.Add(SpacePanel);
      Controls.Add(SaveButton);
      Controls.Add(TimeMaskedTextBox);
      FormBorderStyle = FormBorderStyle.FixedSingle;
      MaximizeBox = false;
      MinimizeBox = false;
      Name = "ReminderForm";
      Padding = new Padding(10);
      ShowIcon = false;
      ShowInTaskbar = false;
      StartPosition = FormStartPosition.CenterParent;
      Text = "Rappel";
      Load += EventForm_Load;
      ResumeLayout(false);
      PerformLayout();
    }

    #endregion
    private Button SaveButton;
    private Button CancelFormButton;
    private MaskedTextBox TimeMaskedTextBox;
    private Panel SpacePanel;
  }
}
namespace time_tracker
{
  partial class AnnotationForm
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
      BottomPanel = new Panel();
      CancelFormButton = new Button();
      MarginPanel = new Panel();
      SaveButton = new Button();
      DatePicker = new DateTimePicker();
      DateLabel = new Label();
      FullDayRadioButton = new RadioButton();
      HalfDayRadioButton = new RadioButton();
      DescriptionLabel = new Label();
      DescriptionTextBox = new TextBox();
      BottomPanel.SuspendLayout();
      SuspendLayout();
      // 
      // BottomPanel
      // 
      BottomPanel.Controls.Add(CancelFormButton);
      BottomPanel.Controls.Add(MarginPanel);
      BottomPanel.Controls.Add(SaveButton);
      BottomPanel.Dock = DockStyle.Bottom;
      BottomPanel.Location = new Point(10, 110);
      BottomPanel.Name = "BottomPanel";
      BottomPanel.Size = new Size(259, 30);
      BottomPanel.TabIndex = 6;
      // 
      // CancelFormButton
      // 
      CancelFormButton.DialogResult = DialogResult.Cancel;
      CancelFormButton.Dock = DockStyle.Right;
      CancelFormButton.FlatAppearance.BorderColor = SystemColors.ButtonShadow;
      CancelFormButton.FlatStyle = FlatStyle.Flat;
      CancelFormButton.Location = new Point(99, 0);
      CancelFormButton.Name = "CancelFormButton";
      CancelFormButton.Size = new Size(75, 30);
      CancelFormButton.TabIndex = 3;
      CancelFormButton.Text = "Annuler";
      CancelFormButton.UseVisualStyleBackColor = true;
      // 
      // MarginPanel
      // 
      MarginPanel.Dock = DockStyle.Right;
      MarginPanel.Location = new Point(174, 0);
      MarginPanel.Name = "MarginPanel";
      MarginPanel.Size = new Size(10, 30);
      MarginPanel.TabIndex = 1;
      // 
      // SaveButton
      // 
      SaveButton.DialogResult = DialogResult.OK;
      SaveButton.Dock = DockStyle.Right;
      SaveButton.FlatAppearance.BorderColor = SystemColors.ButtonShadow;
      SaveButton.FlatStyle = FlatStyle.Flat;
      SaveButton.Location = new Point(184, 0);
      SaveButton.Name = "SaveButton";
      SaveButton.Size = new Size(75, 30);
      SaveButton.TabIndex = 2;
      SaveButton.Text = "Enregistrer";
      SaveButton.UseVisualStyleBackColor = true;
      SaveButton.Click += SaveButton_Click;
      // 
      // DatePicker
      // 
      DatePicker.Format = DateTimePickerFormat.Custom;
      DatePicker.Location = new Point(83, 13);
      DatePicker.Margin = new Padding(0, 3, 5, 3);
      DatePicker.Name = "DatePicker";
      DatePicker.Size = new Size(173, 23);
      DatePicker.TabIndex = 1;
      // 
      // DateLabel
      // 
      DateLabel.AutoSize = true;
      DateLabel.Location = new Point(10, 19);
      DateLabel.Name = "DateLabel";
      DateLabel.Size = new Size(31, 15);
      DateLabel.TabIndex = 7;
      DateLabel.Text = "Date";
      // 
      // FullDayRadioButton
      // 
      FullDayRadioButton.AutoSize = true;
      FullDayRadioButton.Checked = true;
      FullDayRadioButton.Location = new Point(85, 42);
      FullDayRadioButton.Name = "FullDayRadioButton";
      FullDayRadioButton.Size = new Size(66, 19);
      FullDayRadioButton.TabIndex = 8;
      FullDayRadioButton.TabStop = true;
      FullDayRadioButton.Text = "Journée";
      FullDayRadioButton.UseVisualStyleBackColor = true;
      // 
      // HalfDayRadioButton
      // 
      HalfDayRadioButton.AutoSize = true;
      HalfDayRadioButton.Location = new Point(158, 42);
      HalfDayRadioButton.Name = "HalfDayRadioButton";
      HalfDayRadioButton.Size = new Size(98, 19);
      HalfDayRadioButton.TabIndex = 9;
      HalfDayRadioButton.Text = "Demi-journée";
      HalfDayRadioButton.UseVisualStyleBackColor = true;
      // 
      // DescriptionLabel
      // 
      DescriptionLabel.AutoSize = true;
      DescriptionLabel.Location = new Point(10, 70);
      DescriptionLabel.Name = "DescriptionLabel";
      DescriptionLabel.Size = new Size(67, 15);
      DescriptionLabel.TabIndex = 10;
      DescriptionLabel.Text = "Description";
      // 
      // DescriptionTextBox
      // 
      DescriptionTextBox.BorderStyle = BorderStyle.FixedSingle;
      DescriptionTextBox.Location = new Point(83, 67);
      DescriptionTextBox.Name = "DescriptionTextBox";
      DescriptionTextBox.Size = new Size(173, 23);
      DescriptionTextBox.TabIndex = 11;
      // 
      // AnnotationForm
      // 
      AcceptButton = SaveButton;
      AutoScaleDimensions = new SizeF(7F, 15F);
      AutoScaleMode = AutoScaleMode.Font;
      CancelButton = CancelFormButton;
      ClientSize = new Size(279, 150);
      Controls.Add(DescriptionTextBox);
      Controls.Add(DescriptionLabel);
      Controls.Add(HalfDayRadioButton);
      Controls.Add(FullDayRadioButton);
      Controls.Add(DateLabel);
      Controls.Add(DatePicker);
      Controls.Add(BottomPanel);
      FormBorderStyle = FormBorderStyle.FixedSingle;
      MaximizeBox = false;
      MinimizeBox = false;
      Name = "AnnotationForm";
      Padding = new Padding(10);
      ShowIcon = false;
      ShowInTaskbar = false;
      StartPosition = FormStartPosition.CenterParent;
      Text = "Jour chômé";
      Load += EventForm_Load;
      BottomPanel.ResumeLayout(false);
      ResumeLayout(false);
      PerformLayout();
    }

    #endregion
    private Panel BottomPanel;
    private Button CancelFormButton;
    private Panel MarginPanel;
    private Button SaveButton;
    private DateTimePicker DatePicker;
    private Label DateLabel;
    private RadioButton FullDayRadioButton;
    private RadioButton HalfDayRadioButton;
    private Label DescriptionLabel;
    private TextBox DescriptionTextBox;
  }
}
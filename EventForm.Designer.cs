namespace time_tracker
{
  partial class EventForm
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
      TableLayoutPanel = new TableLayoutPanel();
      TimePicker = new DateTimePicker();
      DatePicker = new DateTimePicker();
      BottomPanel.SuspendLayout();
      TableLayoutPanel.SuspendLayout();
      SuspendLayout();
      // 
      // BottomPanel
      // 
      BottomPanel.Controls.Add(CancelFormButton);
      BottomPanel.Controls.Add(MarginPanel);
      BottomPanel.Controls.Add(SaveButton);
      BottomPanel.Dock = DockStyle.Bottom;
      BottomPanel.Location = new Point(10, 55);
      BottomPanel.Name = "BottomPanel";
      BottomPanel.Size = new Size(194, 30);
      BottomPanel.TabIndex = 6;
      // 
      // CancelFormButton
      // 
      CancelFormButton.DialogResult = DialogResult.Cancel;
      CancelFormButton.Dock = DockStyle.Right;
      CancelFormButton.FlatAppearance.BorderColor = SystemColors.ButtonShadow;
      CancelFormButton.FlatStyle = FlatStyle.Flat;
      CancelFormButton.ForeColor = Color.Transparent;
      CancelFormButton.Location = new Point(34, 0);
      CancelFormButton.Name = "CancelFormButton";
      CancelFormButton.Size = new Size(75, 30);
      CancelFormButton.TabIndex = 2;
      CancelFormButton.Text = "Annuler";
      CancelFormButton.UseVisualStyleBackColor = true;
      // 
      // MarginPanel
      // 
      MarginPanel.Dock = DockStyle.Right;
      MarginPanel.Location = new Point(109, 0);
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
      SaveButton.ForeColor = Color.Transparent;
      SaveButton.Location = new Point(119, 0);
      SaveButton.Name = "SaveButton";
      SaveButton.Size = new Size(75, 30);
      SaveButton.TabIndex = 0;
      SaveButton.Text = "Enregistrer";
      SaveButton.UseVisualStyleBackColor = true;
      SaveButton.Click += SaveButton_Click;
      // 
      // TableLayoutPanel
      // 
      TableLayoutPanel.ColumnCount = 2;
      TableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 110F));
      TableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 80F));
      TableLayoutPanel.ColumnStyles.Add(new ColumnStyle());
      TableLayoutPanel.Controls.Add(TimePicker, 0, 0);
      TableLayoutPanel.Controls.Add(DatePicker, 0, 0);
      TableLayoutPanel.Dock = DockStyle.Fill;
      TableLayoutPanel.Location = new Point(10, 10);
      TableLayoutPanel.Margin = new Padding(0);
      TableLayoutPanel.Name = "TableLayoutPanel";
      TableLayoutPanel.RowCount = 1;
      TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
      TableLayoutPanel.Size = new Size(194, 45);
      TableLayoutPanel.TabIndex = 7;
      // 
      // TimePicker
      // 
      TimePicker.CustomFormat = "HH:mm";
      TimePicker.Dock = DockStyle.Fill;
      TimePicker.Format = DateTimePickerFormat.Custom;
      TimePicker.Location = new Point(115, 3);
      TimePicker.Margin = new Padding(5, 3, 0, 3);
      TimePicker.Name = "TimePicker";
      TimePicker.ShowUpDown = true;
      TimePicker.Size = new Size(79, 23);
      TimePicker.TabIndex = 2;
      // 
      // DatePicker
      // 
      DatePicker.Dock = DockStyle.Fill;
      DatePicker.Enabled = false;
      DatePicker.Format = DateTimePickerFormat.Custom;
      DatePicker.Location = new Point(0, 3);
      DatePicker.Margin = new Padding(0, 3, 5, 3);
      DatePicker.Name = "DatePicker";
      DatePicker.Size = new Size(105, 23);
      DatePicker.TabIndex = 1;
      // 
      // EventForm
      // 
      AutoScaleDimensions = new SizeF(7F, 15F);
      AutoScaleMode = AutoScaleMode.Font;
      BackColor = Color.FromArgb(34, 34, 34);
      ClientSize = new Size(214, 95);
      Controls.Add(TableLayoutPanel);
      Controls.Add(BottomPanel);
      ForeColor = Color.White;
      FormBorderStyle = FormBorderStyle.FixedSingle;
      Name = "EventForm";
      Padding = new Padding(10);
      StartPosition = FormStartPosition.CenterParent;
      Text = "Evénément";
      Load += EventForm_Load;
      BottomPanel.ResumeLayout(false);
      TableLayoutPanel.ResumeLayout(false);
      ResumeLayout(false);
    }

    #endregion
    private Panel BottomPanel;
    private Button CancelFormButton;
    private Panel MarginPanel;
    private Button SaveButton;
    private TableLayoutPanel TableLayoutPanel;
    private DateTimePicker TimePicker;
    private DateTimePicker DatePicker;
  }
}
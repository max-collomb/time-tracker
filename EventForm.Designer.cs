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
      DatePicker = new DateTimePicker();
      TimeMaskedTextBox = new MaskedTextBox();
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
      CancelFormButton.Location = new Point(34, 0);
      CancelFormButton.Name = "CancelFormButton";
      CancelFormButton.Size = new Size(75, 30);
      CancelFormButton.TabIndex = 3;
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
      SaveButton.Location = new Point(119, 0);
      SaveButton.Name = "SaveButton";
      SaveButton.Size = new Size(75, 30);
      SaveButton.TabIndex = 2;
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
      TableLayoutPanel.Controls.Add(DatePicker, 0, 0);
      TableLayoutPanel.Controls.Add(TimeMaskedTextBox, 1, 0);
      TableLayoutPanel.Dock = DockStyle.Fill;
      TableLayoutPanel.Location = new Point(10, 10);
      TableLayoutPanel.Margin = new Padding(0);
      TableLayoutPanel.Name = "TableLayoutPanel";
      TableLayoutPanel.RowCount = 1;
      TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
      TableLayoutPanel.Size = new Size(194, 45);
      TableLayoutPanel.TabIndex = 7;
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
      // TimeMaskedTextBox
      // 
      TimeMaskedTextBox.BorderStyle = BorderStyle.FixedSingle;
      TimeMaskedTextBox.Location = new Point(113, 3);
      TimeMaskedTextBox.Mask = "00:00";
      TimeMaskedTextBox.Name = "TimeMaskedTextBox";
      TimeMaskedTextBox.Size = new Size(78, 23);
      TimeMaskedTextBox.TabIndex = 2;
      TimeMaskedTextBox.ValidatingType = typeof(DateTime);
      TimeMaskedTextBox.KeyDown += TimeMaskedTextBox_KeyDown;
      // 
      // EventForm
      // 
      AcceptButton = SaveButton;
      AutoScaleDimensions = new SizeF(7F, 15F);
      AutoScaleMode = AutoScaleMode.Font;
      CancelButton = CancelFormButton;
      ClientSize = new Size(214, 95);
      Controls.Add(TableLayoutPanel);
      Controls.Add(BottomPanel);
      FormBorderStyle = FormBorderStyle.FixedSingle;
      MaximizeBox = false;
      MinimizeBox = false;
      Name = "EventForm";
      Padding = new Padding(10);
      ShowIcon = false;
      ShowInTaskbar = false;
      StartPosition = FormStartPosition.CenterParent;
      Text = "Evénément";
      Load += EventForm_Load;
      BottomPanel.ResumeLayout(false);
      TableLayoutPanel.ResumeLayout(false);
      TableLayoutPanel.PerformLayout();
      ResumeLayout(false);
    }

    #endregion
    private Panel BottomPanel;
    private Button CancelFormButton;
    private Panel MarginPanel;
    private Button SaveButton;
    private TableLayoutPanel TableLayoutPanel;
    private DateTimePicker DatePicker;
    private MaskedTextBox TimeMaskedTextBox;
  }
}
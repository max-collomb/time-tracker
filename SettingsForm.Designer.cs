namespace time_tracker
{
  partial class SettingsForm
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
      TimeSectionLabel = new Label();
      TimeTableLayoutPanel = new TableLayoutPanel();
      MondayTimeLabel = new Label();
      TuesdayTimeLabel = new Label();
      WednesdayTimeLabel = new Label();
      ThursdayTimeLabel = new Label();
      FridayTimeLabel = new Label();
      MondayTimeUpDdown = new NumericUpDown();
      TuesdayTimeUpDdown = new NumericUpDown();
      WednesdayTimeUpDdown = new NumericUpDown();
      ThursdayTimeUpDdown = new NumericUpDown();
      FridayTimeUpDdown = new NumericUpDown();
      PauseTableLayoutPanel = new TableLayoutPanel();
      MondayPauseLabel = new Label();
      TuesdayPauseLabel = new Label();
      WednesdayPauseLabel = new Label();
      ThursdayPauseLabel = new Label();
      FridayPauseLabel = new Label();
      MondayPauseUpDown = new NumericUpDown();
      TuesdayPauseUpDown = new NumericUpDown();
      WednesdayPauseUpDown = new NumericUpDown();
      ThursdayPauseUpDown = new NumericUpDown();
      FridayPauseUpDown = new NumericUpDown();
      PauseSectionLabel = new Label();
      AutoReminderCheckBox = new CheckBox();
      BottomPanel = new Panel();
      CancelFormButton = new Button();
      MarginPanel = new Panel();
      SaveButton = new Button();
      ProductNameLabel = new Label();
      TimeTableLayoutPanel.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)MondayTimeUpDdown).BeginInit();
      ((System.ComponentModel.ISupportInitialize)TuesdayTimeUpDdown).BeginInit();
      ((System.ComponentModel.ISupportInitialize)WednesdayTimeUpDdown).BeginInit();
      ((System.ComponentModel.ISupportInitialize)ThursdayTimeUpDdown).BeginInit();
      ((System.ComponentModel.ISupportInitialize)FridayTimeUpDdown).BeginInit();
      PauseTableLayoutPanel.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)MondayPauseUpDown).BeginInit();
      ((System.ComponentModel.ISupportInitialize)TuesdayPauseUpDown).BeginInit();
      ((System.ComponentModel.ISupportInitialize)WednesdayPauseUpDown).BeginInit();
      ((System.ComponentModel.ISupportInitialize)ThursdayPauseUpDown).BeginInit();
      ((System.ComponentModel.ISupportInitialize)FridayPauseUpDown).BeginInit();
      BottomPanel.SuspendLayout();
      SuspendLayout();
      // 
      // TtimeSectionLabel
      // 
      TimeSectionLabel.AutoSize = true;
      TimeSectionLabel.Dock = DockStyle.Top;
      TimeSectionLabel.ForeColor = Color.White;
      TimeSectionLabel.Location = new Point(10, 10);
      TimeSectionLabel.Margin = new Padding(0);
      TimeSectionLabel.Name = "TtimeSectionLabel";
      TimeSectionLabel.Padding = new Padding(0, 0, 0, 5);
      TimeSectionLabel.Size = new Size(216, 20);
      TimeSectionLabel.TabIndex = 0;
      TimeSectionLabel.Text = "Temps de travail théorique (en minutes)";
      // 
      // TimeTableLayoutPanel
      // 
      TimeTableLayoutPanel.ColumnCount = 5;
      TimeTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
      TimeTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
      TimeTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
      TimeTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
      TimeTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
      TimeTableLayoutPanel.Controls.Add(MondayTimeLabel, 0, 0);
      TimeTableLayoutPanel.Controls.Add(TuesdayTimeLabel, 1, 0);
      TimeTableLayoutPanel.Controls.Add(WednesdayTimeLabel, 2, 0);
      TimeTableLayoutPanel.Controls.Add(ThursdayTimeLabel, 3, 0);
      TimeTableLayoutPanel.Controls.Add(FridayTimeLabel, 4, 0);
      TimeTableLayoutPanel.Controls.Add(MondayTimeUpDdown, 0, 1);
      TimeTableLayoutPanel.Controls.Add(TuesdayTimeUpDdown, 1, 1);
      TimeTableLayoutPanel.Controls.Add(WednesdayTimeUpDdown, 2, 1);
      TimeTableLayoutPanel.Controls.Add(ThursdayTimeUpDdown, 3, 1);
      TimeTableLayoutPanel.Controls.Add(FridayTimeUpDdown, 4, 1);
      TimeTableLayoutPanel.Dock = DockStyle.Top;
      TimeTableLayoutPanel.Location = new Point(10, 30);
      TimeTableLayoutPanel.Name = "TimeTableLayoutPanel";
      TimeTableLayoutPanel.RowCount = 2;
      TimeTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
      TimeTableLayoutPanel.RowStyles.Add(new RowStyle());
      TimeTableLayoutPanel.Size = new Size(336, 50);
      TimeTableLayoutPanel.TabIndex = 1;
      // 
      // MondayTimeLabel
      // 
      MondayTimeLabel.AutoSize = true;
      MondayTimeLabel.ForeColor = Color.White;
      MondayTimeLabel.Location = new Point(0, 0);
      MondayTimeLabel.Margin = new Padding(0);
      MondayTimeLabel.Name = "MondayTimeLabel";
      MondayTimeLabel.Size = new Size(37, 15);
      MondayTimeLabel.TabIndex = 0;
      MondayTimeLabel.Text = "Lundi";
      // 
      // TuesdayTimeLabel
      // 
      TuesdayTimeLabel.AutoSize = true;
      TuesdayTimeLabel.ForeColor = Color.White;
      TuesdayTimeLabel.Location = new Point(67, 0);
      TuesdayTimeLabel.Margin = new Padding(0);
      TuesdayTimeLabel.Name = "TuesdayTimeLabel";
      TuesdayTimeLabel.Size = new Size(38, 15);
      TuesdayTimeLabel.TabIndex = 1;
      TuesdayTimeLabel.Text = "Mardi";
      // 
      // WednesdayTimeLabel
      // 
      WednesdayTimeLabel.AutoSize = true;
      WednesdayTimeLabel.ForeColor = Color.White;
      WednesdayTimeLabel.Location = new Point(134, 0);
      WednesdayTimeLabel.Margin = new Padding(0);
      WednesdayTimeLabel.Name = "WednesdayTimeLabel";
      WednesdayTimeLabel.Size = new Size(54, 15);
      WednesdayTimeLabel.TabIndex = 2;
      WednesdayTimeLabel.Text = "Mercredi";
      // 
      // ThursdayTimeLabel
      // 
      ThursdayTimeLabel.AutoSize = true;
      ThursdayTimeLabel.ForeColor = Color.White;
      ThursdayTimeLabel.Location = new Point(201, 0);
      ThursdayTimeLabel.Margin = new Padding(0);
      ThursdayTimeLabel.Name = "ThursdayTimeLabel";
      ThursdayTimeLabel.Size = new Size(34, 15);
      ThursdayTimeLabel.TabIndex = 3;
      ThursdayTimeLabel.Text = "Jeudi";
      // 
      // FridayTimeLabel
      // 
      FridayTimeLabel.AutoSize = true;
      FridayTimeLabel.ForeColor = Color.White;
      FridayTimeLabel.Location = new Point(268, 0);
      FridayTimeLabel.Margin = new Padding(0);
      FridayTimeLabel.Name = "FridayTimeLabel";
      FridayTimeLabel.Size = new Size(53, 15);
      FridayTimeLabel.TabIndex = 4;
      FridayTimeLabel.Text = "Vendredi";
      // 
      // MondayTimeUpDdown
      // 
      MondayTimeUpDdown.BackColor = Color.FromArgb(51, 51, 51);
      MondayTimeUpDdown.BorderStyle = BorderStyle.FixedSingle;
      MondayTimeUpDdown.ForeColor = Color.Silver;
      MondayTimeUpDdown.Location = new Point(3, 23);
      MondayTimeUpDdown.Maximum = new decimal(new int[] { 600, 0, 0, 0 });
      MondayTimeUpDdown.Minimum = new decimal(new int[] { 240, 0, 0, 0 });
      MondayTimeUpDdown.Name = "MondayTimeUpDdown";
      MondayTimeUpDdown.Size = new Size(61, 23);
      MondayTimeUpDdown.TabIndex = 5;
      MondayTimeUpDdown.Value = new decimal(new int[] { 420, 0, 0, 0 });
      // 
      // TuesdayTimeUpDdown
      // 
      TuesdayTimeUpDdown.BackColor = Color.FromArgb(51, 51, 51);
      TuesdayTimeUpDdown.BorderStyle = BorderStyle.FixedSingle;
      TuesdayTimeUpDdown.ForeColor = Color.Silver;
      TuesdayTimeUpDdown.Location = new Point(70, 23);
      TuesdayTimeUpDdown.Maximum = new decimal(new int[] { 600, 0, 0, 0 });
      TuesdayTimeUpDdown.Minimum = new decimal(new int[] { 240, 0, 0, 0 });
      TuesdayTimeUpDdown.Name = "TuesdayTimeUpDdown";
      TuesdayTimeUpDdown.Size = new Size(61, 23);
      TuesdayTimeUpDdown.TabIndex = 6;
      TuesdayTimeUpDdown.Value = new decimal(new int[] { 420, 0, 0, 0 });
      // 
      // WednesdayTimeUpDdown
      // 
      WednesdayTimeUpDdown.BackColor = Color.FromArgb(51, 51, 51);
      WednesdayTimeUpDdown.BorderStyle = BorderStyle.FixedSingle;
      WednesdayTimeUpDdown.ForeColor = Color.Silver;
      WednesdayTimeUpDdown.Location = new Point(137, 23);
      WednesdayTimeUpDdown.Maximum = new decimal(new int[] { 600, 0, 0, 0 });
      WednesdayTimeUpDdown.Minimum = new decimal(new int[] { 240, 0, 0, 0 });
      WednesdayTimeUpDdown.Name = "WednesdayTimeUpDdown";
      WednesdayTimeUpDdown.Size = new Size(61, 23);
      WednesdayTimeUpDdown.TabIndex = 7;
      WednesdayTimeUpDdown.Value = new decimal(new int[] { 420, 0, 0, 0 });
      // 
      // ThursdayTimeUpDdown
      // 
      ThursdayTimeUpDdown.BackColor = Color.FromArgb(51, 51, 51);
      ThursdayTimeUpDdown.BorderStyle = BorderStyle.FixedSingle;
      ThursdayTimeUpDdown.ForeColor = Color.Silver;
      ThursdayTimeUpDdown.Location = new Point(204, 23);
      ThursdayTimeUpDdown.Maximum = new decimal(new int[] { 600, 0, 0, 0 });
      ThursdayTimeUpDdown.Minimum = new decimal(new int[] { 240, 0, 0, 0 });
      ThursdayTimeUpDdown.Name = "ThursdayTimeUpDdown";
      ThursdayTimeUpDdown.Size = new Size(61, 23);
      ThursdayTimeUpDdown.TabIndex = 8;
      ThursdayTimeUpDdown.Value = new decimal(new int[] { 420, 0, 0, 0 });
      // 
      // FridayTimeUpDdown
      // 
      FridayTimeUpDdown.BackColor = Color.FromArgb(51, 51, 51);
      FridayTimeUpDdown.BorderStyle = BorderStyle.FixedSingle;
      FridayTimeUpDdown.ForeColor = Color.Silver;
      FridayTimeUpDdown.Location = new Point(271, 23);
      FridayTimeUpDdown.Maximum = new decimal(new int[] { 600, 0, 0, 0 });
      FridayTimeUpDdown.Minimum = new decimal(new int[] { 240, 0, 0, 0 });
      FridayTimeUpDdown.Name = "FridayTimeUpDdown";
      FridayTimeUpDdown.Size = new Size(62, 23);
      FridayTimeUpDdown.TabIndex = 9;
      FridayTimeUpDdown.Value = new decimal(new int[] { 420, 0, 0, 0 });
      // 
      // PauseTableLayoutPanel
      // 
      PauseTableLayoutPanel.ColumnCount = 5;
      PauseTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
      PauseTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
      PauseTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
      PauseTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
      PauseTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
      PauseTableLayoutPanel.Controls.Add(MondayPauseLabel, 0, 0);
      PauseTableLayoutPanel.Controls.Add(TuesdayPauseLabel, 1, 0);
      PauseTableLayoutPanel.Controls.Add(WednesdayPauseLabel, 2, 0);
      PauseTableLayoutPanel.Controls.Add(ThursdayPauseLabel, 3, 0);
      PauseTableLayoutPanel.Controls.Add(FridayPauseLabel, 4, 0);
      PauseTableLayoutPanel.Controls.Add(MondayPauseUpDown, 0, 1);
      PauseTableLayoutPanel.Controls.Add(TuesdayPauseUpDown, 1, 1);
      PauseTableLayoutPanel.Controls.Add(WednesdayPauseUpDown, 2, 1);
      PauseTableLayoutPanel.Controls.Add(ThursdayPauseUpDown, 3, 1);
      PauseTableLayoutPanel.Controls.Add(FridayPauseUpDown, 4, 1);
      PauseTableLayoutPanel.Dock = DockStyle.Top;
      PauseTableLayoutPanel.Location = new Point(10, 115);
      PauseTableLayoutPanel.Name = "PauseTableLayoutPanel";
      PauseTableLayoutPanel.RowCount = 2;
      PauseTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
      PauseTableLayoutPanel.RowStyles.Add(new RowStyle());
      PauseTableLayoutPanel.Size = new Size(336, 50);
      PauseTableLayoutPanel.TabIndex = 2;
      // 
      // MondayPauseLabel
      // 
      MondayPauseLabel.AutoSize = true;
      MondayPauseLabel.ForeColor = Color.White;
      MondayPauseLabel.Location = new Point(0, 0);
      MondayPauseLabel.Margin = new Padding(0);
      MondayPauseLabel.Name = "MondayPauseLabel";
      MondayPauseLabel.Size = new Size(37, 15);
      MondayPauseLabel.TabIndex = 0;
      MondayPauseLabel.Text = "Lundi";
      // 
      // TuesdayPauseLabel
      // 
      TuesdayPauseLabel.AutoSize = true;
      TuesdayPauseLabel.ForeColor = Color.White;
      TuesdayPauseLabel.Location = new Point(67, 0);
      TuesdayPauseLabel.Margin = new Padding(0);
      TuesdayPauseLabel.Name = "TuesdayPauseLabel";
      TuesdayPauseLabel.Size = new Size(38, 15);
      TuesdayPauseLabel.TabIndex = 1;
      TuesdayPauseLabel.Text = "Mardi";
      // 
      // WednesdayPauseLabel
      // 
      WednesdayPauseLabel.AutoSize = true;
      WednesdayPauseLabel.ForeColor = Color.White;
      WednesdayPauseLabel.Location = new Point(134, 0);
      WednesdayPauseLabel.Margin = new Padding(0);
      WednesdayPauseLabel.Name = "WednesdayPauseLabel";
      WednesdayPauseLabel.Size = new Size(54, 15);
      WednesdayPauseLabel.TabIndex = 2;
      WednesdayPauseLabel.Text = "Mercredi";
      // 
      // ThursdayPauseLabel
      // 
      ThursdayPauseLabel.AutoSize = true;
      ThursdayPauseLabel.ForeColor = Color.White;
      ThursdayPauseLabel.Location = new Point(201, 0);
      ThursdayPauseLabel.Margin = new Padding(0);
      ThursdayPauseLabel.Name = "ThursdayPauseLabel";
      ThursdayPauseLabel.Size = new Size(34, 15);
      ThursdayPauseLabel.TabIndex = 3;
      ThursdayPauseLabel.Text = "Jeudi";
      // 
      // FridayPauseLabel
      // 
      FridayPauseLabel.AutoSize = true;
      FridayPauseLabel.ForeColor = Color.White;
      FridayPauseLabel.Location = new Point(268, 0);
      FridayPauseLabel.Margin = new Padding(0);
      FridayPauseLabel.Name = "FridayPauseLabel";
      FridayPauseLabel.Size = new Size(53, 15);
      FridayPauseLabel.TabIndex = 4;
      FridayPauseLabel.Text = "Vendredi";
      // 
      // MondayPauseUpDown
      // 
      MondayPauseUpDown.BackColor = Color.FromArgb(51, 51, 51);
      MondayPauseUpDown.BorderStyle = BorderStyle.FixedSingle;
      MondayPauseUpDown.Enabled = false;
      MondayPauseUpDown.ForeColor = Color.Silver;
      MondayPauseUpDown.Location = new Point(3, 23);
      MondayPauseUpDown.Maximum = new decimal(new int[] { 120, 0, 0, 0 });
      MondayPauseUpDown.Minimum = new decimal(new int[] { 45, 0, 0, 0 });
      MondayPauseUpDown.Name = "MondayPauseUpDown";
      MondayPauseUpDown.Size = new Size(61, 23);
      MondayPauseUpDown.TabIndex = 5;
      MondayPauseUpDown.Value = new decimal(new int[] { 60, 0, 0, 0 });
      // 
      // TuesdayPauseUpDown
      // 
      TuesdayPauseUpDown.BackColor = Color.FromArgb(51, 51, 51);
      TuesdayPauseUpDown.BorderStyle = BorderStyle.FixedSingle;
      TuesdayPauseUpDown.Enabled = false;
      TuesdayPauseUpDown.ForeColor = Color.Silver;
      TuesdayPauseUpDown.Location = new Point(70, 23);
      TuesdayPauseUpDown.Maximum = new decimal(new int[] { 120, 0, 0, 0 });
      TuesdayPauseUpDown.Minimum = new decimal(new int[] { 45, 0, 0, 0 });
      TuesdayPauseUpDown.Name = "TuesdayPauseUpDown";
      TuesdayPauseUpDown.Size = new Size(61, 23);
      TuesdayPauseUpDown.TabIndex = 6;
      TuesdayPauseUpDown.Value = new decimal(new int[] { 60, 0, 0, 0 });
      // 
      // WednesdayPauseUpDown
      // 
      WednesdayPauseUpDown.BackColor = Color.FromArgb(51, 51, 51);
      WednesdayPauseUpDown.BorderStyle = BorderStyle.FixedSingle;
      WednesdayPauseUpDown.Enabled = false;
      WednesdayPauseUpDown.ForeColor = Color.Silver;
      WednesdayPauseUpDown.Location = new Point(137, 23);
      WednesdayPauseUpDown.Maximum = new decimal(new int[] { 120, 0, 0, 0 });
      WednesdayPauseUpDown.Minimum = new decimal(new int[] { 45, 0, 0, 0 });
      WednesdayPauseUpDown.Name = "WednesdayPauseUpDown";
      WednesdayPauseUpDown.Size = new Size(61, 23);
      WednesdayPauseUpDown.TabIndex = 7;
      WednesdayPauseUpDown.Value = new decimal(new int[] { 60, 0, 0, 0 });
      // 
      // ThursdayPauseUpDown
      // 
      ThursdayPauseUpDown.BackColor = Color.FromArgb(51, 51, 51);
      ThursdayPauseUpDown.BorderStyle = BorderStyle.FixedSingle;
      ThursdayPauseUpDown.Enabled = false;
      ThursdayPauseUpDown.ForeColor = Color.Silver;
      ThursdayPauseUpDown.Location = new Point(204, 23);
      ThursdayPauseUpDown.Maximum = new decimal(new int[] { 120, 0, 0, 0 });
      ThursdayPauseUpDown.Minimum = new decimal(new int[] { 45, 0, 0, 0 });
      ThursdayPauseUpDown.Name = "ThursdayPauseUpDown";
      ThursdayPauseUpDown.Size = new Size(61, 23);
      ThursdayPauseUpDown.TabIndex = 8;
      ThursdayPauseUpDown.Value = new decimal(new int[] { 60, 0, 0, 0 });
      // 
      // FridayPauseUpDown
      // 
      FridayPauseUpDown.BackColor = Color.FromArgb(51, 51, 51);
      FridayPauseUpDown.BorderStyle = BorderStyle.FixedSingle;
      FridayPauseUpDown.Enabled = false;
      FridayPauseUpDown.ForeColor = Color.Silver;
      FridayPauseUpDown.Location = new Point(271, 23);
      FridayPauseUpDown.Maximum = new decimal(new int[] { 120, 0, 0, 0 });
      FridayPauseUpDown.Minimum = new decimal(new int[] { 45, 0, 0, 0 });
      FridayPauseUpDown.Name = "FridayPauseUpDown";
      FridayPauseUpDown.Size = new Size(62, 23);
      FridayPauseUpDown.TabIndex = 9;
      FridayPauseUpDown.Value = new decimal(new int[] { 120, 0, 0, 0 });
      // 
      // PauseSectionLabel
      // 
      PauseSectionLabel.AutoSize = true;
      PauseSectionLabel.Dock = DockStyle.Top;
      PauseSectionLabel.ForeColor = Color.White;
      PauseSectionLabel.Location = new Point(10, 80);
      PauseSectionLabel.Margin = new Padding(0);
      PauseSectionLabel.Name = "PauseSectionLabel";
      PauseSectionLabel.Padding = new Padding(0, 15, 0, 5);
      PauseSectionLabel.Size = new Size(215, 35);
      PauseSectionLabel.TabIndex = 3;
      PauseSectionLabel.Text = "Temps de pause théorique (en minutes)";
      // 
      // AutoReminderCheckBox
      // 
      AutoReminderCheckBox.AutoSize = true;
      AutoReminderCheckBox.Dock = DockStyle.Top;
      AutoReminderCheckBox.FlatAppearance.BorderColor = Color.White;
      AutoReminderCheckBox.FlatStyle = FlatStyle.Flat;
      AutoReminderCheckBox.Location = new Point(10, 165);
      AutoReminderCheckBox.Name = "AutoReminderCheckBox";
      AutoReminderCheckBox.Padding = new Padding(0, 15, 0, 0);
      AutoReminderCheckBox.Size = new Size(336, 34);
      AutoReminderCheckBox.TabIndex = 4;
      AutoReminderCheckBox.Text = "Activer automatiquement les rappels";
      AutoReminderCheckBox.UseVisualStyleBackColor = true;
      AutoReminderCheckBox.Visible = false;
      // 
      // BottomPanel
      // 
      BottomPanel.Controls.Add(CancelFormButton);
      BottomPanel.Controls.Add(MarginPanel);
      BottomPanel.Controls.Add(SaveButton);
      BottomPanel.Dock = DockStyle.Bottom;
      BottomPanel.Location = new Point(10, 249);
      BottomPanel.Name = "BottomPanel";
      BottomPanel.Size = new Size(336, 30);
      BottomPanel.TabIndex = 5;
      // 
      // CancelButton
      // 
      CancelFormButton.DialogResult = DialogResult.Cancel;
      CancelFormButton.Dock = DockStyle.Right;
      CancelFormButton.FlatAppearance.BorderColor = SystemColors.ButtonShadow;
      CancelFormButton.FlatStyle = FlatStyle.Flat;
      CancelFormButton.ForeColor = Color.Transparent;
      CancelFormButton.Location = new Point(176, 0);
      CancelFormButton.Name = "CancelButton";
      CancelFormButton.Size = new Size(75, 30);
      CancelFormButton.TabIndex = 2;
      CancelFormButton.Text = "Annuler";
      CancelFormButton.UseVisualStyleBackColor = true;
      // 
      // MarginPanel
      // 
      MarginPanel.Dock = DockStyle.Right;
      MarginPanel.Location = new Point(251, 0);
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
      SaveButton.Location = new Point(261, 0);
      SaveButton.Name = "SaveButton";
      SaveButton.Size = new Size(75, 30);
      SaveButton.TabIndex = 0;
      SaveButton.Text = "Enregistrer";
      SaveButton.UseVisualStyleBackColor = true;
      SaveButton.Click += SaveButton_Click;
      // 
      // ProductNameLabel
      // 
      ProductNameLabel.Dock = DockStyle.Bottom;
      ProductNameLabel.ForeColor = Color.DimGray;
      ProductNameLabel.Location = new Point(10, 224);
      ProductNameLabel.Name = "ProductNameLabel";
      ProductNameLabel.Padding = new Padding(0, 0, 0, 10);
      ProductNameLabel.Size = new Size(336, 25);
      ProductNameLabel.TabIndex = 6;
      ProductNameLabel.Text = "Time Tracker v0.1";
      ProductNameLabel.TextAlign = ContentAlignment.TopRight;
      // 
      // SettingsForm
      // 
      AutoScaleDimensions = new SizeF(7F, 15F);
      AutoScaleMode = AutoScaleMode.Font;
      BackColor = Color.FromArgb(34, 34, 34);
      ClientSize = new Size(356, 289);
      Controls.Add(ProductNameLabel);
      Controls.Add(BottomPanel);
      Controls.Add(AutoReminderCheckBox);
      Controls.Add(PauseTableLayoutPanel);
      Controls.Add(PauseSectionLabel);
      Controls.Add(TimeTableLayoutPanel);
      Controls.Add(TimeSectionLabel);
      ForeColor = Color.White;
      FormBorderStyle = FormBorderStyle.FixedSingle;
      Name = "SettingsForm";
      Padding = new Padding(10);
      StartPosition = FormStartPosition.CenterParent;
      Text = "Options";
      Load += SettingsForm_Load;
      TimeTableLayoutPanel.ResumeLayout(false);
      TimeTableLayoutPanel.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)MondayTimeUpDdown).EndInit();
      ((System.ComponentModel.ISupportInitialize)TuesdayTimeUpDdown).EndInit();
      ((System.ComponentModel.ISupportInitialize)WednesdayTimeUpDdown).EndInit();
      ((System.ComponentModel.ISupportInitialize)ThursdayTimeUpDdown).EndInit();
      ((System.ComponentModel.ISupportInitialize)FridayTimeUpDdown).EndInit();
      PauseTableLayoutPanel.ResumeLayout(false);
      PauseTableLayoutPanel.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)MondayPauseUpDown).EndInit();
      ((System.ComponentModel.ISupportInitialize)TuesdayPauseUpDown).EndInit();
      ((System.ComponentModel.ISupportInitialize)WednesdayPauseUpDown).EndInit();
      ((System.ComponentModel.ISupportInitialize)ThursdayPauseUpDown).EndInit();
      ((System.ComponentModel.ISupportInitialize)FridayPauseUpDown).EndInit();
      BottomPanel.ResumeLayout(false);
      ResumeLayout(false);
      PerformLayout();
    }

    #endregion

    private Label TimeSectionLabel;
    private TableLayoutPanel TimeTableLayoutPanel;
    private Label MondayTimeLabel;
    private Label TuesdayTimeLabel;
    private Label WednesdayTimeLabel;
    private Label ThursdayTimeLabel;
    private Label FridayTimeLabel;
    private NumericUpDown MondayTimeUpDdown;
    private NumericUpDown TuesdayTimeUpDdown;
    private NumericUpDown WednesdayTimeUpDdown;
    private NumericUpDown ThursdayTimeUpDdown;
    private NumericUpDown FridayTimeUpDdown;
    private TableLayoutPanel PauseTableLayoutPanel;
    private Label MondayPauseLabel;
    private Label TuesdayPauseLabel;
    private Label WednesdayPauseLabel;
    private Label ThursdayPauseLabel;
    private Label FridayPauseLabel;
    private NumericUpDown MondayPauseUpDown;
    private NumericUpDown TuesdayPauseUpDown;
    private NumericUpDown WednesdayPauseUpDown;
    private NumericUpDown ThursdayPauseUpDown;
    private NumericUpDown FridayPauseUpDown;
    private Label PauseSectionLabel;
    private CheckBox AutoReminderCheckBox;
    private Panel BottomPanel;
    private Label ProductNameLabel;
    private Button CancelFormButton;
    private Panel MarginPanel;
    private Button SaveButton;
  }
}
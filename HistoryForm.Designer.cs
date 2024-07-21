namespace time_tracker
{
  partial class HistoryForm
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
      DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
      TopPanel = new Panel();
      ApplyButton = new Button();
      ToDatePicker = new DateTimePicker();
      ToLabel = new Label();
      FromLabel = new Label();
      FromDatePicker = new DateTimePicker();
      EventsDataGridView = new DataGridView();
      Date = new DataGridViewTextBoxColumn();
      Time = new DataGridViewTextBoxColumn();
      Type = new DataGridViewTextBoxColumn();
      Edit = new DataGridViewButtonColumn();
      TabControl = new TabControl();
      RawEventsTabPage = new TabPage();
      WeeklySummaryTabPage = new TabPage();
      WeekDataGridView = new DataGridView();
      WeekNumber = new DataGridViewTextBoxColumn();
      DateStart = new DataGridViewTextBoxColumn();
      TotalTime = new DataGridViewTextBoxColumn();
      MenuStrip = new MenuStrip();
      AddToolStripMenuItem = new ToolStripMenuItem();
      AddEventToolStripMenuItem1 = new ToolStripMenuItem();
      périodesPrédéfiniesToolStripMenuItem = new ToolStripMenuItem();
      ThisDayToolStripMenuItem = new ToolStripMenuItem();
      LastDayToolStripMenuItem = new ToolStripMenuItem();
      toolStripSeparator1 = new ToolStripSeparator();
      ThisWeekToolStripMenuItem = new ToolStripMenuItem();
      LastWeekToolStripMenuItem = new ToolStripMenuItem();
      toolStripSeparator2 = new ToolStripSeparator();
      ThisMonthToolStripMenuItem = new ToolStripMenuItem();
      LastMonthToolStripMenuItem = new ToolStripMenuItem();
      toolStripSeparator3 = new ToolStripSeparator();
      ThisYearToolStripMenuItem = new ToolStripMenuItem();
      LastYearToolStripMenuItem = new ToolStripMenuItem();
      TopPanel.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)EventsDataGridView).BeginInit();
      TabControl.SuspendLayout();
      RawEventsTabPage.SuspendLayout();
      WeeklySummaryTabPage.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)WeekDataGridView).BeginInit();
      MenuStrip.SuspendLayout();
      SuspendLayout();
      // 
      // TopPanel
      // 
      TopPanel.Controls.Add(ApplyButton);
      TopPanel.Controls.Add(ToDatePicker);
      TopPanel.Controls.Add(ToLabel);
      TopPanel.Controls.Add(FromLabel);
      TopPanel.Controls.Add(FromDatePicker);
      TopPanel.Dock = DockStyle.Top;
      TopPanel.Location = new Point(0, 24);
      TopPanel.Name = "TopPanel";
      TopPanel.Size = new Size(468, 46);
      TopPanel.TabIndex = 0;
      // 
      // ApplyButton
      // 
      ApplyButton.BackColor = Color.FromArgb(34, 34, 34);
      ApplyButton.FlatAppearance.BorderColor = SystemColors.ButtonShadow;
      ApplyButton.FlatStyle = FlatStyle.Flat;
      ApplyButton.Location = new Point(300, 11);
      ApplyButton.Name = "ApplyButton";
      ApplyButton.Size = new Size(75, 25);
      ApplyButton.TabIndex = 4;
      ApplyButton.Text = "Appliquer";
      ApplyButton.UseVisualStyleBackColor = false;
      ApplyButton.Click += ApplyButton_Click;
      // 
      // ToDatePicker
      // 
      ToDatePicker.Format = DateTimePickerFormat.Short;
      ToDatePicker.Location = new Point(176, 12);
      ToDatePicker.MaxDate = new DateTime(2050, 12, 31, 0, 0, 0, 0);
      ToDatePicker.MinDate = new DateTime(2023, 1, 1, 0, 0, 0, 0);
      ToDatePicker.Name = "ToDatePicker";
      ToDatePicker.Size = new Size(105, 23);
      ToDatePicker.TabIndex = 3;
      // 
      // ToLabel
      // 
      ToLabel.Location = new Point(157, 12);
      ToLabel.Name = "ToLabel";
      ToLabel.Size = new Size(13, 23);
      ToLabel.TabIndex = 2;
      ToLabel.Text = "à";
      ToLabel.TextAlign = ContentAlignment.MiddleLeft;
      // 
      // FromLabel
      // 
      FromLabel.Location = new Point(12, 12);
      FromLabel.Name = "FromLabel";
      FromLabel.Size = new Size(28, 23);
      FromLabel.TabIndex = 1;
      FromLabel.Text = "De";
      FromLabel.TextAlign = ContentAlignment.MiddleLeft;
      // 
      // FromDatePicker
      // 
      FromDatePicker.Format = DateTimePickerFormat.Short;
      FromDatePicker.Location = new Point(46, 12);
      FromDatePicker.MaxDate = new DateTime(2050, 12, 31, 0, 0, 0, 0);
      FromDatePicker.MinDate = new DateTime(2023, 1, 1, 0, 0, 0, 0);
      FromDatePicker.Name = "FromDatePicker";
      FromDatePicker.Size = new Size(105, 23);
      FromDatePicker.TabIndex = 0;
      // 
      // EventsDataGridView
      // 
      EventsDataGridView.AllowUserToAddRows = false;
      EventsDataGridView.AllowUserToDeleteRows = false;
      EventsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      EventsDataGridView.Columns.AddRange(new DataGridViewColumn[] { Date, Time, Type, Edit });
      EventsDataGridView.Dock = DockStyle.Fill;
      EventsDataGridView.Location = new Point(3, 3);
      EventsDataGridView.Name = "EventsDataGridView";
      EventsDataGridView.ReadOnly = true;
      EventsDataGridView.RowHeadersVisible = false;
      EventsDataGridView.Size = new Size(454, 418);
      EventsDataGridView.TabIndex = 1;
      // 
      // Date
      // 
      Date.HeaderText = "Date";
      Date.Name = "Date";
      Date.ReadOnly = true;
      Date.Width = 75;
      // 
      // Time
      // 
      Time.HeaderText = "Heure";
      Time.Name = "Time";
      Time.ReadOnly = true;
      Time.Width = 50;
      // 
      // Type
      // 
      Type.HeaderText = "Type";
      Type.Name = "Type";
      Type.ReadOnly = true;
      Type.Width = 150;
      // 
      // Edit
      // 
      dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
      dataGridViewCellStyle1.BackColor = Color.FromArgb(34, 34, 34);
      dataGridViewCellStyle1.ForeColor = Color.White;
      Edit.DefaultCellStyle = dataGridViewCellStyle1;
      Edit.FlatStyle = FlatStyle.Flat;
      Edit.HeaderText = "";
      Edit.Name = "Edit";
      Edit.ReadOnly = true;
      Edit.Text = "Modifier";
      Edit.UseColumnTextForButtonValue = true;
      Edit.Width = 75;
      // 
      // TabControl
      // 
      TabControl.Controls.Add(RawEventsTabPage);
      TabControl.Controls.Add(WeeklySummaryTabPage);
      TabControl.Dock = DockStyle.Fill;
      TabControl.Location = new Point(0, 70);
      TabControl.Name = "TabControl";
      TabControl.SelectedIndex = 0;
      TabControl.Size = new Size(468, 452);
      TabControl.TabIndex = 2;
      // 
      // RawEventsTabPage
      // 
      RawEventsTabPage.Controls.Add(EventsDataGridView);
      RawEventsTabPage.Location = new Point(4, 24);
      RawEventsTabPage.Name = "RawEventsTabPage";
      RawEventsTabPage.Padding = new Padding(3);
      RawEventsTabPage.Size = new Size(460, 424);
      RawEventsTabPage.TabIndex = 0;
      RawEventsTabPage.Text = "Evénements";
      RawEventsTabPage.UseVisualStyleBackColor = true;
      // 
      // WeeklySummaryTabPage
      // 
      WeeklySummaryTabPage.Controls.Add(WeekDataGridView);
      WeeklySummaryTabPage.Location = new Point(4, 24);
      WeeklySummaryTabPage.Name = "WeeklySummaryTabPage";
      WeeklySummaryTabPage.Padding = new Padding(3);
      WeeklySummaryTabPage.Size = new Size(460, 424);
      WeeklySummaryTabPage.TabIndex = 1;
      WeeklySummaryTabPage.Text = "Résumés hebdomadaires";
      WeeklySummaryTabPage.UseVisualStyleBackColor = true;
      // 
      // WeekDataGridView
      // 
      WeekDataGridView.AllowUserToAddRows = false;
      WeekDataGridView.AllowUserToDeleteRows = false;
      WeekDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      WeekDataGridView.Columns.AddRange(new DataGridViewColumn[] { WeekNumber, DateStart, TotalTime });
      WeekDataGridView.Dock = DockStyle.Fill;
      WeekDataGridView.Location = new Point(3, 3);
      WeekDataGridView.Name = "WeekDataGridView";
      WeekDataGridView.ReadOnly = true;
      WeekDataGridView.RowHeadersVisible = false;
      WeekDataGridView.Size = new Size(454, 418);
      WeekDataGridView.TabIndex = 0;
      // 
      // WeekNumber
      // 
      WeekNumber.HeaderText = "#";
      WeekNumber.Name = "WeekNumber";
      WeekNumber.ReadOnly = true;
      WeekNumber.Width = 25;
      // 
      // DateStart
      // 
      DateStart.HeaderText = "Date";
      DateStart.Name = "DateStart";
      DateStart.ReadOnly = true;
      DateStart.Width = 75;
      // 
      // TotalTime
      // 
      TotalTime.HeaderText = "Temps total";
      TotalTime.Name = "TotalTime";
      TotalTime.ReadOnly = true;
      // 
      // MenuStrip
      // 
      MenuStrip.Items.AddRange(new ToolStripItem[] { AddToolStripMenuItem, périodesPrédéfiniesToolStripMenuItem });
      MenuStrip.Location = new Point(0, 0);
      MenuStrip.Name = "MenuStrip";
      MenuStrip.Size = new Size(468, 24);
      MenuStrip.TabIndex = 2;
      MenuStrip.Text = "menuStrip1";
      // 
      // AddToolStripMenuItem
      // 
      AddToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { AddEventToolStripMenuItem1 });
      AddToolStripMenuItem.Name = "AddToolStripMenuItem";
      AddToolStripMenuItem.Size = new Size(58, 20);
      AddToolStripMenuItem.Text = "Ajouter";
      // 
      // AddEventToolStripMenuItem1
      // 
      AddEventToolStripMenuItem1.Name = "AddEventToolStripMenuItem1";
      AddEventToolStripMenuItem1.Size = new Size(113, 22);
      AddEventToolStripMenuItem1.Text = "Ajouter";
      // 
      // périodesPrédéfiniesToolStripMenuItem
      // 
      périodesPrédéfiniesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { ThisDayToolStripMenuItem, LastDayToolStripMenuItem, toolStripSeparator1, ThisWeekToolStripMenuItem, LastWeekToolStripMenuItem, toolStripSeparator2, ThisMonthToolStripMenuItem, LastMonthToolStripMenuItem, toolStripSeparator3, ThisYearToolStripMenuItem, LastYearToolStripMenuItem });
      périodesPrédéfiniesToolStripMenuItem.Name = "périodesPrédéfiniesToolStripMenuItem";
      périodesPrédéfiniesToolStripMenuItem.Size = new Size(125, 20);
      périodesPrédéfiniesToolStripMenuItem.Text = "Périodes prédéfinies";
      // 
      // ThisDayToolStripMenuItem
      // 
      ThisDayToolStripMenuItem.Name = "ThisDayToolStripMenuItem";
      ThisDayToolStripMenuItem.Size = new Size(179, 22);
      ThisDayToolStripMenuItem.Text = "Ajourd'hui";
      ThisDayToolStripMenuItem.Click += SetRangeToolStripMenuItem_Click;
      // 
      // LastDayToolStripMenuItem
      // 
      LastDayToolStripMenuItem.Name = "LastDayToolStripMenuItem";
      LastDayToolStripMenuItem.Size = new Size(179, 22);
      LastDayToolStripMenuItem.Text = "Dernier jour ouvré";
      LastDayToolStripMenuItem.Click += SetRangeToolStripMenuItem_Click;
      // 
      // toolStripSeparator1
      // 
      toolStripSeparator1.Name = "toolStripSeparator1";
      toolStripSeparator1.Size = new Size(176, 6);
      // 
      // ThisWeekToolStripMenuItem
      // 
      ThisWeekToolStripMenuItem.Name = "ThisWeekToolStripMenuItem";
      ThisWeekToolStripMenuItem.Size = new Size(179, 22);
      ThisWeekToolStripMenuItem.Text = "Cette semaine";
      ThisWeekToolStripMenuItem.Click += SetRangeToolStripMenuItem_Click;
      // 
      // LastWeekToolStripMenuItem
      // 
      LastWeekToolStripMenuItem.Name = "LastWeekToolStripMenuItem";
      LastWeekToolStripMenuItem.Size = new Size(179, 22);
      LastWeekToolStripMenuItem.Text = "La semaine dernière";
      LastWeekToolStripMenuItem.Click += SetRangeToolStripMenuItem_Click;
      // 
      // toolStripSeparator2
      // 
      toolStripSeparator2.Name = "toolStripSeparator2";
      toolStripSeparator2.Size = new Size(176, 6);
      // 
      // ThisMonthToolStripMenuItem
      // 
      ThisMonthToolStripMenuItem.Name = "ThisMonthToolStripMenuItem";
      ThisMonthToolStripMenuItem.Size = new Size(179, 22);
      ThisMonthToolStripMenuItem.Text = "Ce mois-ci";
      ThisMonthToolStripMenuItem.Click += SetRangeToolStripMenuItem_Click;
      // 
      // LastMonthToolStripMenuItem
      // 
      LastMonthToolStripMenuItem.Name = "LastMonthToolStripMenuItem";
      LastMonthToolStripMenuItem.Size = new Size(179, 22);
      LastMonthToolStripMenuItem.Text = "Le mois dernier";
      LastMonthToolStripMenuItem.Click += SetRangeToolStripMenuItem_Click;
      // 
      // toolStripSeparator3
      // 
      toolStripSeparator3.Name = "toolStripSeparator3";
      toolStripSeparator3.Size = new Size(176, 6);
      // 
      // ThisYearToolStripMenuItem
      // 
      ThisYearToolStripMenuItem.Name = "ThisYearToolStripMenuItem";
      ThisYearToolStripMenuItem.Size = new Size(179, 22);
      ThisYearToolStripMenuItem.Text = "Cette année";
      ThisYearToolStripMenuItem.Click += SetRangeToolStripMenuItem_Click;
      // 
      // LastYearToolStripMenuItem
      // 
      LastYearToolStripMenuItem.Name = "LastYearToolStripMenuItem";
      LastYearToolStripMenuItem.Size = new Size(179, 22);
      LastYearToolStripMenuItem.Text = "L'année dernière";
      LastYearToolStripMenuItem.Click += SetRangeToolStripMenuItem_Click;
      // 
      // HistoryForm
      // 
      AutoScaleDimensions = new SizeF(7F, 15F);
      AutoScaleMode = AutoScaleMode.Font;
      ClientSize = new Size(468, 522);
      Controls.Add(TabControl);
      Controls.Add(TopPanel);
      Controls.Add(MenuStrip);
      FormBorderStyle = FormBorderStyle.SizableToolWindow;
      MainMenuStrip = MenuStrip;
      Name = "HistoryForm";
      Text = "Historique";
      TopPanel.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)EventsDataGridView).EndInit();
      TabControl.ResumeLayout(false);
      RawEventsTabPage.ResumeLayout(false);
      WeeklySummaryTabPage.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)WeekDataGridView).EndInit();
      MenuStrip.ResumeLayout(false);
      MenuStrip.PerformLayout();
      ResumeLayout(false);
      PerformLayout();
    }

    #endregion

    private Panel TopPanel;
    private DateTimePicker ToDatePicker;
    private Label ToLabel;
    private Label FromLabel;
    private DateTimePicker FromDatePicker;
    private DataGridView EventsDataGridView;
    private TabControl TabControl;
    private TabPage RawEventsTabPage;
    private TabPage WeeklySummaryTabPage;
    private DataGridViewTextBoxColumn Date;
    private DataGridViewTextBoxColumn Time;
    private DataGridViewTextBoxColumn Type;
    private DataGridViewButtonColumn Edit;
    private Button ApplyButton;
    private MenuStrip MenuStrip;
    private ToolStripMenuItem AddToolStripMenuItem;
    private ToolStripMenuItem AddEventToolStripMenuItem1;
    private ToolStripMenuItem périodesPrédéfiniesToolStripMenuItem;
    private ToolStripMenuItem ThisDayToolStripMenuItem;
    private ToolStripMenuItem LastDayToolStripMenuItem;
    private ToolStripMenuItem ThisWeekToolStripMenuItem;
    private ToolStripMenuItem LastWeekToolStripMenuItem;
    private ToolStripMenuItem ThisMonthToolStripMenuItem;
    private ToolStripMenuItem LastMonthToolStripMenuItem;
    private ToolStripMenuItem ThisYearToolStripMenuItem;
    private ToolStripMenuItem LastYearToolStripMenuItem;
    private ToolStripSeparator toolStripSeparator1;
    private ToolStripSeparator toolStripSeparator2;
    private ToolStripSeparator toolStripSeparator3;
    private DataGridView WeekDataGridView;
    private DataGridViewTextBoxColumn WeekNumber;
    private DataGridViewTextBoxColumn DateStart;
    private DataGridViewTextBoxColumn TotalTime;
  }
}
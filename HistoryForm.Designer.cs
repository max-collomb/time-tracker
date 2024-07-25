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
      components = new System.ComponentModel.Container();
      EventsDataGridView = new DataGridView();
      Id = new DataGridViewTextBoxColumn();
      Date = new DataGridViewTextBoxColumn();
      Time = new DataGridViewTextBoxColumn();
      Type = new DataGridViewTextBoxColumn();
      EventContextMenuStrip = new ContextMenuStrip(components);
      EditToolStripMenuItem = new ToolStripMenuItem();
      DeleteToolStripMenuItem = new ToolStripMenuItem();
      TabControl = new TabControl();
      RawEventsTabPage = new TabPage();
      TopPanel = new Panel();
      ApplyButton = new Button();
      panel1 = new Panel();
      ToDatePicker = new DateTimePicker();
      ToLabel = new Label();
      FromDatePicker = new DateTimePicker();
      FromLabel = new Label();
      EventToolStrip = new ToolStrip();
      AddEventToolStripButton = new ToolStripButton();
      EditEventToolStripButton = new ToolStripButton();
      DeleteEventToolStripButton = new ToolStripButton();
      toolStripSeparator4 = new ToolStripSeparator();
      ToolStripDropDownButton = new ToolStripDropDownButton();
      ThisDayToolStripMenuItem = new ToolStripMenuItem();
      LastDayToolStripMenuItem = new ToolStripMenuItem();
      toolStripSeparator5 = new ToolStripSeparator();
      ThisWeekToolStripMenuItem = new ToolStripMenuItem();
      LastWeekToolStripMenuItem = new ToolStripMenuItem();
      toolStripSeparator6 = new ToolStripSeparator();
      ThisMonthToolStripMenuItem = new ToolStripMenuItem();
      LastMonthToolStripMenuItem = new ToolStripMenuItem();
      toolStripSeparator7 = new ToolStripSeparator();
      ThisYearToolStripMenuItem = new ToolStripMenuItem();
      LastYearToolStripMenuItem = new ToolStripMenuItem();
      DaysOffTabPage = new TabPage();
      DaysOffDataGridView = new DataGridView();
      AnnotationId = new DataGridViewTextBoxColumn();
      AnnotationDate = new DataGridViewTextBoxColumn();
      AnnotationType = new DataGridViewTextBoxColumn();
      AnnotationDescription = new DataGridViewTextBoxColumn();
      AnnotationToolStrip = new ToolStrip();
      AddAnnotationToolStripButton = new ToolStripButton();
      EditAnnotationToolStripButton = new ToolStripButton();
      DeleteAnnotationToolStripButton = new ToolStripButton();
      WeeklySummaryTabPage = new TabPage();
      WeekDataGridView = new DataGridView();
      WeekNumber = new DataGridViewTextBoxColumn();
      DateStart = new DataGridViewTextBoxColumn();
      CheckedTime = new DataGridViewTextBoxColumn();
      OffTime = new DataGridViewTextBoxColumn();
      TotalTime = new DataGridViewTextBoxColumn();
      ajourdhuiToolStripMenuItem = new ToolStripMenuItem();
      BottomPanel = new Panel();
      SqliteLinkLabel = new LinkLabel();
      LogLinkLabel = new LinkLabel();
      CloseButton = new Button();
      ((System.ComponentModel.ISupportInitialize)EventsDataGridView).BeginInit();
      EventContextMenuStrip.SuspendLayout();
      TabControl.SuspendLayout();
      RawEventsTabPage.SuspendLayout();
      TopPanel.SuspendLayout();
      EventToolStrip.SuspendLayout();
      DaysOffTabPage.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)DaysOffDataGridView).BeginInit();
      AnnotationToolStrip.SuspendLayout();
      WeeklySummaryTabPage.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)WeekDataGridView).BeginInit();
      BottomPanel.SuspendLayout();
      SuspendLayout();
      // 
      // EventsDataGridView
      // 
      EventsDataGridView.AllowUserToAddRows = false;
      EventsDataGridView.AllowUserToDeleteRows = false;
      EventsDataGridView.AllowUserToResizeColumns = false;
      EventsDataGridView.AllowUserToResizeRows = false;
      EventsDataGridView.BackgroundColor = SystemColors.Control;
      EventsDataGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
      EventsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      EventsDataGridView.Columns.AddRange(new DataGridViewColumn[] { Id, Date, Time, Type });
      EventsDataGridView.ContextMenuStrip = EventContextMenuStrip;
      EventsDataGridView.Dock = DockStyle.Fill;
      EventsDataGridView.Location = new Point(3, 71);
      EventsDataGridView.MultiSelect = false;
      EventsDataGridView.Name = "EventsDataGridView";
      EventsDataGridView.ReadOnly = true;
      EventsDataGridView.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
      EventsDataGridView.RowHeadersVisible = false;
      EventsDataGridView.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
      EventsDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
      EventsDataGridView.Size = new Size(550, 486);
      EventsDataGridView.TabIndex = 1;
      EventsDataGridView.CellFormatting += EventsDataGridView_CellFormatting;
      EventsDataGridView.CellMouseDown += EventsDataGridView_CellMouseDown;
      EventsDataGridView.SelectionChanged += EventsDataGridView_SelectionChanged;
      // 
      // Id
      // 
      Id.HeaderText = "Id";
      Id.Name = "Id";
      Id.ReadOnly = true;
      Id.Width = 45;
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
      Time.Width = 75;
      // 
      // Type
      // 
      Type.HeaderText = "Type";
      Type.Name = "Type";
      Type.ReadOnly = true;
      Type.Width = 300;
      // 
      // EventContextMenuStrip
      // 
      EventContextMenuStrip.Items.AddRange(new ToolStripItem[] { EditToolStripMenuItem, DeleteToolStripMenuItem });
      EventContextMenuStrip.Name = "contextMenuStrip1";
      EventContextMenuStrip.RenderMode = ToolStripRenderMode.System;
      EventContextMenuStrip.Size = new Size(130, 48);
      // 
      // EditToolStripMenuItem
      // 
      EditToolStripMenuItem.Name = "EditToolStripMenuItem";
      EditToolStripMenuItem.Size = new Size(129, 22);
      EditToolStripMenuItem.Text = "Modifier";
      EditToolStripMenuItem.Click += EditToolStripMenuItem_Click;
      // 
      // DeleteToolStripMenuItem
      // 
      DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem";
      DeleteToolStripMenuItem.Size = new Size(129, 22);
      DeleteToolStripMenuItem.Text = "Supprimer";
      DeleteToolStripMenuItem.Click += DeleteToolStripMenuItem_Click;
      // 
      // TabControl
      // 
      TabControl.Controls.Add(RawEventsTabPage);
      TabControl.Controls.Add(DaysOffTabPage);
      TabControl.Controls.Add(WeeklySummaryTabPage);
      TabControl.Dock = DockStyle.Fill;
      TabControl.Location = new Point(0, 0);
      TabControl.Multiline = true;
      TabControl.Name = "TabControl";
      TabControl.SelectedIndex = 0;
      TabControl.Size = new Size(564, 588);
      TabControl.TabIndex = 2;
      TabControl.SelectedIndexChanged += TabControl_SelectedIndexChanged;
      // 
      // RawEventsTabPage
      // 
      RawEventsTabPage.Controls.Add(EventsDataGridView);
      RawEventsTabPage.Controls.Add(TopPanel);
      RawEventsTabPage.Controls.Add(EventToolStrip);
      RawEventsTabPage.Location = new Point(4, 24);
      RawEventsTabPage.Name = "RawEventsTabPage";
      RawEventsTabPage.Padding = new Padding(3);
      RawEventsTabPage.Size = new Size(556, 560);
      RawEventsTabPage.TabIndex = 0;
      RawEventsTabPage.Text = "Evénements";
      RawEventsTabPage.UseVisualStyleBackColor = true;
      // 
      // TopPanel
      // 
      TopPanel.Controls.Add(ApplyButton);
      TopPanel.Controls.Add(panel1);
      TopPanel.Controls.Add(ToDatePicker);
      TopPanel.Controls.Add(ToLabel);
      TopPanel.Controls.Add(FromDatePicker);
      TopPanel.Controls.Add(FromLabel);
      TopPanel.Dock = DockStyle.Top;
      TopPanel.Location = new Point(3, 28);
      TopPanel.Name = "TopPanel";
      TopPanel.Padding = new Padding(0, 9, 0, 9);
      TopPanel.Size = new Size(550, 43);
      TopPanel.TabIndex = 2;
      // 
      // ApplyButton
      // 
      ApplyButton.Dock = DockStyle.Left;
      ApplyButton.FlatStyle = FlatStyle.Flat;
      ApplyButton.Location = new Point(254, 9);
      ApplyButton.Name = "ApplyButton";
      ApplyButton.Size = new Size(75, 25);
      ApplyButton.TabIndex = 4;
      ApplyButton.Text = "Appliquer";
      ApplyButton.Click += ApplyButton_Click;
      // 
      // panel1
      // 
      panel1.Dock = DockStyle.Left;
      panel1.Location = new Point(244, 9);
      panel1.Name = "panel1";
      panel1.Size = new Size(10, 25);
      panel1.TabIndex = 5;
      // 
      // ToDatePicker
      // 
      ToDatePicker.Dock = DockStyle.Left;
      ToDatePicker.Format = DateTimePickerFormat.Short;
      ToDatePicker.Location = new Point(139, 9);
      ToDatePicker.MaxDate = new DateTime(2050, 12, 31, 0, 0, 0, 0);
      ToDatePicker.MinDate = new DateTime(2023, 1, 1, 0, 0, 0, 0);
      ToDatePicker.Name = "ToDatePicker";
      ToDatePicker.Size = new Size(105, 23);
      ToDatePicker.TabIndex = 3;
      // 
      // ToLabel
      // 
      ToLabel.AutoSize = true;
      ToLabel.Dock = DockStyle.Left;
      ToLabel.Location = new Point(126, 9);
      ToLabel.Name = "ToLabel";
      ToLabel.Padding = new Padding(0, 4, 0, 0);
      ToLabel.Size = new Size(13, 19);
      ToLabel.TabIndex = 2;
      ToLabel.Text = "à";
      ToLabel.TextAlign = ContentAlignment.MiddleLeft;
      // 
      // FromDatePicker
      // 
      FromDatePicker.Dock = DockStyle.Left;
      FromDatePicker.Format = DateTimePickerFormat.Short;
      FromDatePicker.Location = new Point(21, 9);
      FromDatePicker.MaxDate = new DateTime(2050, 12, 31, 0, 0, 0, 0);
      FromDatePicker.MinDate = new DateTime(2023, 1, 1, 0, 0, 0, 0);
      FromDatePicker.Name = "FromDatePicker";
      FromDatePicker.Size = new Size(105, 23);
      FromDatePicker.TabIndex = 0;
      // 
      // FromLabel
      // 
      FromLabel.AutoSize = true;
      FromLabel.Dock = DockStyle.Left;
      FromLabel.Location = new Point(0, 9);
      FromLabel.Name = "FromLabel";
      FromLabel.Padding = new Padding(0, 4, 0, 0);
      FromLabel.Size = new Size(21, 19);
      FromLabel.TabIndex = 1;
      FromLabel.Text = "De";
      FromLabel.TextAlign = ContentAlignment.MiddleLeft;
      // 
      // EventToolStrip
      // 
      EventToolStrip.GripStyle = ToolStripGripStyle.Hidden;
      EventToolStrip.Items.AddRange(new ToolStripItem[] { AddEventToolStripButton, EditEventToolStripButton, DeleteEventToolStripButton, toolStripSeparator4, ToolStripDropDownButton });
      EventToolStrip.Location = new Point(3, 3);
      EventToolStrip.Name = "EventToolStrip";
      EventToolStrip.Size = new Size(550, 25);
      EventToolStrip.TabIndex = 0;
      EventToolStrip.Text = "toolStrip1";
      // 
      // AddEventToolStripButton
      // 
      AddEventToolStripButton.Image = Properties.Resources.add;
      AddEventToolStripButton.ImageTransparentColor = Color.Magenta;
      AddEventToolStripButton.Name = "AddEventToolStripButton";
      AddEventToolStripButton.Size = new Size(66, 22);
      AddEventToolStripButton.Text = "Ajouter";
      AddEventToolStripButton.Click += AddEventButton_Click;
      // 
      // EditEventToolStripButton
      // 
      EditEventToolStripButton.Image = Properties.Resources.edit;
      EditEventToolStripButton.ImageTransparentColor = Color.Magenta;
      EditEventToolStripButton.Name = "EditEventToolStripButton";
      EditEventToolStripButton.Size = new Size(72, 22);
      EditEventToolStripButton.Text = "Modifier";
      EditEventToolStripButton.Click += EditToolStripMenuItem_Click;
      // 
      // DeleteEventToolStripButton
      // 
      DeleteEventToolStripButton.Image = Properties.Resources.delete;
      DeleteEventToolStripButton.ImageTransparentColor = Color.Magenta;
      DeleteEventToolStripButton.Name = "DeleteEventToolStripButton";
      DeleteEventToolStripButton.Size = new Size(82, 22);
      DeleteEventToolStripButton.Text = "Supprimer";
      DeleteEventToolStripButton.Click += DeleteToolStripMenuItem_Click;
      // 
      // toolStripSeparator4
      // 
      toolStripSeparator4.Name = "toolStripSeparator4";
      toolStripSeparator4.Size = new Size(6, 25);
      // 
      // ToolStripDropDownButton
      // 
      ToolStripDropDownButton.DisplayStyle = ToolStripItemDisplayStyle.Text;
      ToolStripDropDownButton.DropDownItems.AddRange(new ToolStripItem[] { ThisDayToolStripMenuItem, LastDayToolStripMenuItem, toolStripSeparator5, ThisWeekToolStripMenuItem, LastWeekToolStripMenuItem, toolStripSeparator6, ThisMonthToolStripMenuItem, LastMonthToolStripMenuItem, toolStripSeparator7, ThisYearToolStripMenuItem, LastYearToolStripMenuItem });
      ToolStripDropDownButton.ImageTransparentColor = Color.Magenta;
      ToolStripDropDownButton.Name = "ToolStripDropDownButton";
      ToolStripDropDownButton.Size = new Size(60, 22);
      ToolStripDropDownButton.Text = "Période";
      // 
      // ThisDayToolStripMenuItem
      // 
      ThisDayToolStripMenuItem.Name = "ThisDayToolStripMenuItem";
      ThisDayToolStripMenuItem.Size = new Size(179, 22);
      ThisDayToolStripMenuItem.Text = "Aujourd'hui";
      ThisDayToolStripMenuItem.Click += SelectRangeToolStripMenuItem_Click;
      // 
      // LastDayToolStripMenuItem
      // 
      LastDayToolStripMenuItem.Name = "LastDayToolStripMenuItem";
      LastDayToolStripMenuItem.Size = new Size(179, 22);
      LastDayToolStripMenuItem.Text = "Dernier jour ouvré";
      LastDayToolStripMenuItem.Click += SelectRangeToolStripMenuItem_Click;
      // 
      // toolStripSeparator5
      // 
      toolStripSeparator5.Name = "toolStripSeparator5";
      toolStripSeparator5.Size = new Size(176, 6);
      // 
      // ThisWeekToolStripMenuItem
      // 
      ThisWeekToolStripMenuItem.Name = "ThisWeekToolStripMenuItem";
      ThisWeekToolStripMenuItem.Size = new Size(179, 22);
      ThisWeekToolStripMenuItem.Text = "Cette semaine";
      ThisWeekToolStripMenuItem.Click += SelectRangeToolStripMenuItem_Click;
      // 
      // LastWeekToolStripMenuItem
      // 
      LastWeekToolStripMenuItem.Name = "LastWeekToolStripMenuItem";
      LastWeekToolStripMenuItem.Size = new Size(179, 22);
      LastWeekToolStripMenuItem.Text = "La semaine dernière";
      LastWeekToolStripMenuItem.Click += SelectRangeToolStripMenuItem_Click;
      // 
      // toolStripSeparator6
      // 
      toolStripSeparator6.Name = "toolStripSeparator6";
      toolStripSeparator6.Size = new Size(176, 6);
      // 
      // ThisMonthToolStripMenuItem
      // 
      ThisMonthToolStripMenuItem.Name = "ThisMonthToolStripMenuItem";
      ThisMonthToolStripMenuItem.Size = new Size(179, 22);
      ThisMonthToolStripMenuItem.Text = "Ce mois-ci";
      ThisMonthToolStripMenuItem.Click += SelectRangeToolStripMenuItem_Click;
      // 
      // LastMonthToolStripMenuItem
      // 
      LastMonthToolStripMenuItem.Name = "LastMonthToolStripMenuItem";
      LastMonthToolStripMenuItem.Size = new Size(179, 22);
      LastMonthToolStripMenuItem.Text = "Le mois dernier";
      LastMonthToolStripMenuItem.Click += SelectRangeToolStripMenuItem_Click;
      // 
      // toolStripSeparator7
      // 
      toolStripSeparator7.Name = "toolStripSeparator7";
      toolStripSeparator7.Size = new Size(176, 6);
      // 
      // ThisYearToolStripMenuItem
      // 
      ThisYearToolStripMenuItem.Name = "ThisYearToolStripMenuItem";
      ThisYearToolStripMenuItem.Size = new Size(179, 22);
      ThisYearToolStripMenuItem.Text = "Cette année";
      ThisYearToolStripMenuItem.Click += SelectRangeToolStripMenuItem_Click;
      // 
      // LastYearToolStripMenuItem
      // 
      LastYearToolStripMenuItem.Name = "LastYearToolStripMenuItem";
      LastYearToolStripMenuItem.Size = new Size(179, 22);
      LastYearToolStripMenuItem.Text = "L'année dernière";
      LastYearToolStripMenuItem.Click += SelectRangeToolStripMenuItem_Click;
      // 
      // DaysOffTabPage
      // 
      DaysOffTabPage.Controls.Add(DaysOffDataGridView);
      DaysOffTabPage.Controls.Add(AnnotationToolStrip);
      DaysOffTabPage.Location = new Point(4, 24);
      DaysOffTabPage.Name = "DaysOffTabPage";
      DaysOffTabPage.Padding = new Padding(3);
      DaysOffTabPage.Size = new Size(556, 560);
      DaysOffTabPage.TabIndex = 2;
      DaysOffTabPage.Text = "Jours chomés";
      DaysOffTabPage.UseVisualStyleBackColor = true;
      // 
      // DaysOffDataGridView
      // 
      DaysOffDataGridView.AllowUserToAddRows = false;
      DaysOffDataGridView.AllowUserToDeleteRows = false;
      DaysOffDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      DaysOffDataGridView.Columns.AddRange(new DataGridViewColumn[] { AnnotationId, AnnotationDate, AnnotationType, AnnotationDescription });
      DaysOffDataGridView.Dock = DockStyle.Fill;
      DaysOffDataGridView.Location = new Point(3, 28);
      DaysOffDataGridView.Name = "DaysOffDataGridView";
      DaysOffDataGridView.ReadOnly = true;
      DaysOffDataGridView.RowHeadersVisible = false;
      DaysOffDataGridView.Size = new Size(550, 529);
      DaysOffDataGridView.TabIndex = 1;
      // 
      // AnnotationId
      // 
      AnnotationId.HeaderText = "Id";
      AnnotationId.Name = "AnnotationId";
      AnnotationId.ReadOnly = true;
      AnnotationId.Width = 50;
      // 
      // AnnotationDate
      // 
      AnnotationDate.HeaderText = "Date";
      AnnotationDate.Name = "AnnotationDate";
      AnnotationDate.ReadOnly = true;
      AnnotationDate.Width = 75;
      // 
      // AnnotationType
      // 
      AnnotationType.HeaderText = "Type";
      AnnotationType.Name = "AnnotationType";
      AnnotationType.ReadOnly = true;
      AnnotationType.Width = 150;
      // 
      // AnnotationDescription
      // 
      AnnotationDescription.HeaderText = "Description";
      AnnotationDescription.Name = "AnnotationDescription";
      AnnotationDescription.ReadOnly = true;
      AnnotationDescription.Width = 150;
      // 
      // AnnotationToolStrip
      // 
      AnnotationToolStrip.GripStyle = ToolStripGripStyle.Hidden;
      AnnotationToolStrip.Items.AddRange(new ToolStripItem[] { AddAnnotationToolStripButton, EditAnnotationToolStripButton, DeleteAnnotationToolStripButton });
      AnnotationToolStrip.Location = new Point(3, 3);
      AnnotationToolStrip.Name = "AnnotationToolStrip";
      AnnotationToolStrip.Size = new Size(550, 25);
      AnnotationToolStrip.TabIndex = 0;
      AnnotationToolStrip.Text = "toolStrip1";
      // 
      // AddAnnotationToolStripButton
      // 
      AddAnnotationToolStripButton.Image = Properties.Resources.add;
      AddAnnotationToolStripButton.ImageTransparentColor = Color.Magenta;
      AddAnnotationToolStripButton.Name = "AddAnnotationToolStripButton";
      AddAnnotationToolStripButton.Size = new Size(66, 22);
      AddAnnotationToolStripButton.Text = "Ajouter";
      // 
      // EditAnnotationToolStripButton
      // 
      EditAnnotationToolStripButton.Image = Properties.Resources.edit;
      EditAnnotationToolStripButton.ImageTransparentColor = Color.Magenta;
      EditAnnotationToolStripButton.Name = "EditAnnotationToolStripButton";
      EditAnnotationToolStripButton.Size = new Size(72, 22);
      EditAnnotationToolStripButton.Text = "Modifier";
      // 
      // DeleteAnnotationToolStripButton
      // 
      DeleteAnnotationToolStripButton.Image = Properties.Resources.delete;
      DeleteAnnotationToolStripButton.ImageTransparentColor = Color.Magenta;
      DeleteAnnotationToolStripButton.Name = "DeleteAnnotationToolStripButton";
      DeleteAnnotationToolStripButton.Size = new Size(82, 22);
      DeleteAnnotationToolStripButton.Text = "Supprimer";
      // 
      // WeeklySummaryTabPage
      // 
      WeeklySummaryTabPage.Controls.Add(WeekDataGridView);
      WeeklySummaryTabPage.Location = new Point(4, 24);
      WeeklySummaryTabPage.Name = "WeeklySummaryTabPage";
      WeeklySummaryTabPage.Padding = new Padding(3);
      WeeklySummaryTabPage.Size = new Size(556, 560);
      WeeklySummaryTabPage.TabIndex = 1;
      WeeklySummaryTabPage.Text = "Résumés hebdomadaires";
      WeeklySummaryTabPage.UseVisualStyleBackColor = true;
      // 
      // WeekDataGridView
      // 
      WeekDataGridView.AllowUserToAddRows = false;
      WeekDataGridView.AllowUserToDeleteRows = false;
      WeekDataGridView.AllowUserToResizeColumns = false;
      WeekDataGridView.AllowUserToResizeRows = false;
      WeekDataGridView.BackgroundColor = SystemColors.Control;
      WeekDataGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
      WeekDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      WeekDataGridView.Columns.AddRange(new DataGridViewColumn[] { WeekNumber, DateStart, CheckedTime, OffTime, TotalTime });
      WeekDataGridView.Dock = DockStyle.Fill;
      WeekDataGridView.Location = new Point(3, 3);
      WeekDataGridView.MultiSelect = false;
      WeekDataGridView.Name = "WeekDataGridView";
      WeekDataGridView.ReadOnly = true;
      WeekDataGridView.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
      WeekDataGridView.RowHeadersVisible = false;
      WeekDataGridView.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
      WeekDataGridView.SelectionMode = DataGridViewSelectionMode.CellSelect;
      WeekDataGridView.Size = new Size(550, 554);
      WeekDataGridView.TabIndex = 0;
      // 
      // WeekNumber
      // 
      WeekNumber.HeaderText = "#";
      WeekNumber.Name = "WeekNumber";
      WeekNumber.ReadOnly = true;
      WeekNumber.Width = 50;
      // 
      // DateStart
      // 
      DateStart.HeaderText = "Date";
      DateStart.Name = "DateStart";
      DateStart.ReadOnly = true;
      DateStart.Width = 75;
      // 
      // CheckedTime
      // 
      CheckedTime.HeaderText = "Temps badgé";
      CheckedTime.Name = "CheckedTime";
      CheckedTime.ReadOnly = true;
      CheckedTime.Width = 125;
      // 
      // OffTime
      // 
      OffTime.HeaderText = "Temps chomé";
      OffTime.Name = "OffTime";
      OffTime.ReadOnly = true;
      OffTime.Width = 125;
      // 
      // TotalTime
      // 
      TotalTime.HeaderText = "Temps total";
      TotalTime.Name = "TotalTime";
      TotalTime.ReadOnly = true;
      TotalTime.Width = 125;
      // 
      // ajourdhuiToolStripMenuItem
      // 
      ajourdhuiToolStripMenuItem.Name = "ajourdhuiToolStripMenuItem";
      ajourdhuiToolStripMenuItem.Size = new Size(137, 22);
      ajourdhuiToolStripMenuItem.Text = "Aujourd'hui";
      // 
      // BottomPanel
      // 
      BottomPanel.Controls.Add(SqliteLinkLabel);
      BottomPanel.Controls.Add(LogLinkLabel);
      BottomPanel.Controls.Add(CloseButton);
      BottomPanel.Dock = DockStyle.Bottom;
      BottomPanel.Location = new Point(0, 588);
      BottomPanel.Name = "BottomPanel";
      BottomPanel.Padding = new Padding(10);
      BottomPanel.Size = new Size(564, 45);
      BottomPanel.TabIndex = 3;
      // 
      // SqliteLinkLabel
      // 
      SqliteLinkLabel.AutoSize = true;
      SqliteLinkLabel.Cursor = Cursors.Hand;
      SqliteLinkLabel.Location = new Point(158, 15);
      SqliteLinkLabel.Name = "SqliteLinkLabel";
      SqliteLinkLabel.Size = new Size(103, 15);
      SqliteLinkLabel.TabIndex = 3;
      SqliteLinkLabel.TabStop = true;
      SqliteLinkLabel.Text = "time-tracker.sqlite";
      SqliteLinkLabel.Click += SqliteLinkLabel_Click;
      // 
      // LogLinkLabel
      // 
      LogLinkLabel.Cursor = Cursors.Hand;
      LogLinkLabel.Dock = DockStyle.Left;
      LogLinkLabel.Location = new Point(10, 10);
      LogLinkLabel.Margin = new Padding(0);
      LogLinkLabel.Name = "LogLinkLabel";
      LogLinkLabel.Size = new Size(123, 25);
      LogLinkLabel.TabIndex = 2;
      LogLinkLabel.TabStop = true;
      LogLinkLabel.Text = "time-tracker-20xx.log";
      LogLinkLabel.TextAlign = ContentAlignment.MiddleLeft;
      LogLinkLabel.Click += LogLinkLabel_Click;
      // 
      // CloseButton
      // 
      CloseButton.Dock = DockStyle.Right;
      CloseButton.FlatStyle = FlatStyle.Flat;
      CloseButton.Location = new Point(479, 10);
      CloseButton.Name = "CloseButton";
      CloseButton.Size = new Size(75, 25);
      CloseButton.TabIndex = 0;
      CloseButton.Text = "Fermer";
      CloseButton.UseVisualStyleBackColor = true;
      CloseButton.Click += CloseButton_Click;
      // 
      // HistoryForm
      // 
      AutoScaleDimensions = new SizeF(7F, 15F);
      AutoScaleMode = AutoScaleMode.Font;
      ClientSize = new Size(564, 633);
      Controls.Add(TabControl);
      Controls.Add(BottomPanel);
      Name = "HistoryForm";
      Text = "Historique";
      Load += HistoryForm_Load;
      ((System.ComponentModel.ISupportInitialize)EventsDataGridView).EndInit();
      EventContextMenuStrip.ResumeLayout(false);
      TabControl.ResumeLayout(false);
      RawEventsTabPage.ResumeLayout(false);
      RawEventsTabPage.PerformLayout();
      TopPanel.ResumeLayout(false);
      TopPanel.PerformLayout();
      EventToolStrip.ResumeLayout(false);
      EventToolStrip.PerformLayout();
      DaysOffTabPage.ResumeLayout(false);
      DaysOffTabPage.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)DaysOffDataGridView).EndInit();
      AnnotationToolStrip.ResumeLayout(false);
      AnnotationToolStrip.PerformLayout();
      WeeklySummaryTabPage.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)WeekDataGridView).EndInit();
      BottomPanel.ResumeLayout(false);
      BottomPanel.PerformLayout();
      ResumeLayout(false);
    }

    #endregion
    private DataGridView EventsDataGridView;
    private TabControl TabControl;
    private TabPage RawEventsTabPage;
    private TabPage WeeklySummaryTabPage;
    private DataGridView WeekDataGridView;
    private Panel BottomPanel;
    private Button CloseButton;
    private Panel TopPanel;
    private Button ApplyButton;
    private DateTimePicker ToDatePicker;
    private Label ToLabel;
    private Label FromLabel;
    private DateTimePicker FromDatePicker;
    private ContextMenuStrip EventContextMenuStrip;
    private ToolStripMenuItem EditToolStripMenuItem;
    private ToolStripMenuItem DeleteToolStripMenuItem;
    private ToolStripMenuItem ajourdhuiToolStripMenuItem;
    private ToolStripMenuItem ThisDayToolStripMenuItem;
    private ToolStripMenuItem LastDayToolStripMenuItem;
    private ToolStripMenuItem ThisWeekToolStripMenuItem;
    private ToolStripMenuItem LastWeekToolStripMenuItem;
    private ToolStripMenuItem ThisMonthToolStripMenuItem;
    private ToolStripMenuItem LastMonthToolStripMenuItem;
    private ToolStripMenuItem ThisYearToolStripMenuItem;
    private ToolStripMenuItem LastYearToolStripMenuItem;
    private LinkLabel LogLinkLabel;
    private ToolStrip EventToolStrip;
    private ToolStripButton AddEventToolStripButton;
    private ToolStripButton EditEventToolStripButton;
    private ToolStripButton DeleteEventToolStripButton;
    private ToolStripSeparator toolStripSeparator4;
    private ToolStripDropDownButton ToolStripDropDownButton;
    private ToolStripSeparator toolStripSeparator5;
    private ToolStripSeparator toolStripSeparator6;
    private ToolStripSeparator toolStripSeparator7;
    private Panel panel1;
    private DataGridViewTextBoxColumn Id;
    private DataGridViewTextBoxColumn Date;
    private DataGridViewTextBoxColumn Time;
    private DataGridViewTextBoxColumn Type;
    private LinkLabel SqliteLinkLabel;
    private DataGridViewTextBoxColumn WeekNumber;
    private DataGridViewTextBoxColumn DateStart;
    private DataGridViewTextBoxColumn CheckedTime;
    private DataGridViewTextBoxColumn OffTime;
    private DataGridViewTextBoxColumn TotalTime;
    private TabPage DaysOffTabPage;
    private ToolStrip AnnotationToolStrip;
    private ToolStripButton AddAnnotationToolStripButton;
    private ToolStripButton EditAnnotationToolStripButton;
    private ToolStripButton DeleteAnnotationToolStripButton;
    private DataGridView DaysOffDataGridView;
    private DataGridViewTextBoxColumn AnnotationId;
    private DataGridViewTextBoxColumn AnnotationDate;
    private DataGridViewTextBoxColumn AnnotationType;
    private DataGridViewTextBoxColumn AnnotationDescription;
  }
}
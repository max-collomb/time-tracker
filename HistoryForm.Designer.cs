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
      Edit = new DataGridViewButtonColumn();
      EventContextMenuStrip = new ContextMenuStrip(components);
      EditToolStripMenuItem = new ToolStripMenuItem();
      DeleteToolStripMenuItem = new ToolStripMenuItem();
      TabControl = new TabControl();
      RawEventsTabPage = new TabPage();
      FillPanel = new Panel();
      TopPanel = new Panel();
      button2 = new Button();
      PredifinedContextMenuStrip = new ContextMenuStrip(components);
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
      ApplyButton = new Button();
      ToDatePicker = new DateTimePicker();
      ToLabel = new Label();
      FromLabel = new Label();
      FromDatePicker = new DateTimePicker();
      WeeklySummaryTabPage = new TabPage();
      WeekDataGridView = new DataGridView();
      WeekNumber = new DataGridViewTextBoxColumn();
      DateStart = new DataGridViewTextBoxColumn();
      TotalTime = new DataGridViewTextBoxColumn();
      ajourdhuiToolStripMenuItem = new ToolStripMenuItem();
      BottomPanel = new Panel();
      AddEventButton = new Button();
      CloseButton = new Button();
      ((System.ComponentModel.ISupportInitialize)EventsDataGridView).BeginInit();
      EventContextMenuStrip.SuspendLayout();
      TabControl.SuspendLayout();
      RawEventsTabPage.SuspendLayout();
      FillPanel.SuspendLayout();
      TopPanel.SuspendLayout();
      PredifinedContextMenuStrip.SuspendLayout();
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
      EventsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      EventsDataGridView.Columns.AddRange(new DataGridViewColumn[] { Id, Date, Time, Type, Edit });
      EventsDataGridView.Dock = DockStyle.Fill;
      EventsDataGridView.Location = new Point(0, 0);
      EventsDataGridView.MultiSelect = false;
      EventsDataGridView.Name = "EventsDataGridView";
      EventsDataGridView.ReadOnly = true;
      EventsDataGridView.RowHeadersVisible = false;
      EventsDataGridView.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
      EventsDataGridView.RowTemplate.ContextMenuStrip = EventContextMenuStrip;
      EventsDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
      EventsDataGridView.Size = new Size(454, 454);
      EventsDataGridView.TabIndex = 1;
      EventsDataGridView.CellContentClick += EventsDataGridView_CellContentClick;
      EventsDataGridView.CellMouseDown += EventsDataGridView_CellMouseDown;
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
      Type.Width = 150;
      // 
      // Edit
      // 
      Edit.FlatStyle = FlatStyle.Flat;
      Edit.HeaderText = "";
      Edit.Name = "Edit";
      Edit.ReadOnly = true;
      Edit.Text = "Modifier";
      Edit.UseColumnTextForButtonValue = true;
      Edit.Width = 75;
      // 
      // EventContextMenuStrip
      // 
      EventContextMenuStrip.Items.AddRange(new ToolStripItem[] { EditToolStripMenuItem, DeleteToolStripMenuItem });
      EventContextMenuStrip.Name = "contextMenuStrip1";
      EventContextMenuStrip.Size = new Size(181, 70);
      // 
      // EditToolStripMenuItem
      // 
      EditToolStripMenuItem.Name = "EditToolStripMenuItem";
      EditToolStripMenuItem.Size = new Size(180, 22);
      EditToolStripMenuItem.Text = "Modifier";
      EditToolStripMenuItem.Click += EditToolStripMenuItem_Click;
      // 
      // DeleteToolStripMenuItem
      // 
      DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem";
      DeleteToolStripMenuItem.Size = new Size(180, 22);
      DeleteToolStripMenuItem.Text = "Supprimer";
      DeleteToolStripMenuItem.Click += DeleteToolStripMenuItem_Click;
      // 
      // TabControl
      // 
      TabControl.Controls.Add(RawEventsTabPage);
      TabControl.Controls.Add(WeeklySummaryTabPage);
      TabControl.Dock = DockStyle.Fill;
      TabControl.Location = new Point(0, 0);
      TabControl.Multiline = true;
      TabControl.Name = "TabControl";
      TabControl.SelectedIndex = 0;
      TabControl.Size = new Size(468, 522);
      TabControl.TabIndex = 2;
      TabControl.SelectedIndexChanged += TabControl_SelectedIndexChanged;
      // 
      // RawEventsTabPage
      // 
      RawEventsTabPage.Controls.Add(FillPanel);
      RawEventsTabPage.Controls.Add(TopPanel);
      RawEventsTabPage.Location = new Point(4, 24);
      RawEventsTabPage.Name = "RawEventsTabPage";
      RawEventsTabPage.Padding = new Padding(3);
      RawEventsTabPage.Size = new Size(460, 494);
      RawEventsTabPage.TabIndex = 0;
      RawEventsTabPage.Text = "Evénements";
      RawEventsTabPage.UseVisualStyleBackColor = true;
      // 
      // FillPanel
      // 
      FillPanel.Controls.Add(EventsDataGridView);
      FillPanel.Dock = DockStyle.Fill;
      FillPanel.Location = new Point(3, 37);
      FillPanel.Name = "FillPanel";
      FillPanel.Size = new Size(454, 454);
      FillPanel.TabIndex = 5;
      // 
      // TopPanel
      // 
      TopPanel.Controls.Add(button2);
      TopPanel.Controls.Add(ApplyButton);
      TopPanel.Controls.Add(ToDatePicker);
      TopPanel.Controls.Add(ToLabel);
      TopPanel.Controls.Add(FromLabel);
      TopPanel.Controls.Add(FromDatePicker);
      TopPanel.Dock = DockStyle.Top;
      TopPanel.Location = new Point(3, 3);
      TopPanel.Name = "TopPanel";
      TopPanel.Size = new Size(454, 34);
      TopPanel.TabIndex = 2;
      // 
      // button2
      // 
      button2.ContextMenuStrip = PredifinedContextMenuStrip;
      button2.FlatStyle = FlatStyle.Flat;
      button2.Location = new Point(268, 3);
      button2.Name = "button2";
      button2.Size = new Size(48, 23);
      button2.TabIndex = 5;
      button2.Text = "...";
      button2.TextAlign = ContentAlignment.MiddleLeft;
      button2.UseVisualStyleBackColor = true;
      button2.Paint += PredifinedButton_Paint;
      button2.MouseDown += PredifinedButton_MouseDown;
      // 
      // PredifinedContextMenuStrip
      // 
      PredifinedContextMenuStrip.Items.AddRange(new ToolStripItem[] { ThisDayToolStripMenuItem, LastDayToolStripMenuItem, toolStripSeparator1, ThisWeekToolStripMenuItem, LastWeekToolStripMenuItem, toolStripSeparator2, ThisMonthToolStripMenuItem, LastMonthToolStripMenuItem, toolStripSeparator3, ThisYearToolStripMenuItem, LastYearToolStripMenuItem });
      PredifinedContextMenuStrip.Name = "contextMenuStrip2";
      PredifinedContextMenuStrip.Size = new Size(180, 198);
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
      // ApplyButton
      // 
      ApplyButton.FlatStyle = FlatStyle.Flat;
      ApplyButton.Location = new Point(322, 2);
      ApplyButton.Name = "ApplyButton";
      ApplyButton.Size = new Size(75, 25);
      ApplyButton.TabIndex = 4;
      ApplyButton.Text = "Appliquer";
      ApplyButton.Click += ApplyButton_Click;
      // 
      // ToDatePicker
      // 
      ToDatePicker.Format = DateTimePickerFormat.Short;
      ToDatePicker.Location = new Point(157, 3);
      ToDatePicker.MaxDate = new DateTime(2050, 12, 31, 0, 0, 0, 0);
      ToDatePicker.MinDate = new DateTime(2023, 1, 1, 0, 0, 0, 0);
      ToDatePicker.Name = "ToDatePicker";
      ToDatePicker.Size = new Size(105, 23);
      ToDatePicker.TabIndex = 3;
      // 
      // ToLabel
      // 
      ToLabel.Location = new Point(138, 3);
      ToLabel.Name = "ToLabel";
      ToLabel.Size = new Size(13, 23);
      ToLabel.TabIndex = 2;
      ToLabel.Text = "à";
      ToLabel.TextAlign = ContentAlignment.MiddleLeft;
      // 
      // FromLabel
      // 
      FromLabel.Location = new Point(0, 3);
      FromLabel.Name = "FromLabel";
      FromLabel.Size = new Size(21, 23);
      FromLabel.TabIndex = 1;
      FromLabel.Text = "De";
      FromLabel.TextAlign = ContentAlignment.MiddleLeft;
      // 
      // FromDatePicker
      // 
      FromDatePicker.Format = DateTimePickerFormat.Short;
      FromDatePicker.Location = new Point(27, 3);
      FromDatePicker.MaxDate = new DateTime(2050, 12, 31, 0, 0, 0, 0);
      FromDatePicker.MinDate = new DateTime(2023, 1, 1, 0, 0, 0, 0);
      FromDatePicker.Name = "FromDatePicker";
      FromDatePicker.Size = new Size(105, 23);
      FromDatePicker.TabIndex = 0;
      // 
      // WeeklySummaryTabPage
      // 
      WeeklySummaryTabPage.Controls.Add(WeekDataGridView);
      WeeklySummaryTabPage.Location = new Point(4, 24);
      WeeklySummaryTabPage.Name = "WeeklySummaryTabPage";
      WeeklySummaryTabPage.Padding = new Padding(3);
      WeeklySummaryTabPage.Size = new Size(460, 494);
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
      WeekDataGridView.Size = new Size(454, 488);
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
      // ajourdhuiToolStripMenuItem
      // 
      ajourdhuiToolStripMenuItem.Name = "ajourdhuiToolStripMenuItem";
      ajourdhuiToolStripMenuItem.Size = new Size(137, 22);
      ajourdhuiToolStripMenuItem.Text = "Aujourd'hui";
      // 
      // BottomPanel
      // 
      BottomPanel.Controls.Add(AddEventButton);
      BottomPanel.Controls.Add(CloseButton);
      BottomPanel.Dock = DockStyle.Bottom;
      BottomPanel.Location = new Point(0, 477);
      BottomPanel.Name = "BottomPanel";
      BottomPanel.Padding = new Padding(10);
      BottomPanel.Size = new Size(468, 45);
      BottomPanel.TabIndex = 3;
      // 
      // AddEventButton
      // 
      AddEventButton.Dock = DockStyle.Left;
      AddEventButton.FlatStyle = FlatStyle.Flat;
      AddEventButton.Location = new Point(10, 10);
      AddEventButton.Name = "AddEventButton";
      AddEventButton.Size = new Size(155, 25);
      AddEventButton.TabIndex = 1;
      AddEventButton.Text = "Ajouter un événement";
      AddEventButton.UseVisualStyleBackColor = true;
      AddEventButton.Click += AddEventButton_Click;
      // 
      // CloseButton
      // 
      CloseButton.Dock = DockStyle.Right;
      CloseButton.FlatStyle = FlatStyle.Flat;
      CloseButton.Location = new Point(383, 10);
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
      ClientSize = new Size(468, 522);
      Controls.Add(BottomPanel);
      Controls.Add(TabControl);
      FormBorderStyle = FormBorderStyle.SizableToolWindow;
      Name = "HistoryForm";
      Text = "Historique";
      ((System.ComponentModel.ISupportInitialize)EventsDataGridView).EndInit();
      EventContextMenuStrip.ResumeLayout(false);
      TabControl.ResumeLayout(false);
      RawEventsTabPage.ResumeLayout(false);
      FillPanel.ResumeLayout(false);
      TopPanel.ResumeLayout(false);
      PredifinedContextMenuStrip.ResumeLayout(false);
      WeeklySummaryTabPage.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)WeekDataGridView).EndInit();
      BottomPanel.ResumeLayout(false);
      ResumeLayout(false);
    }

    #endregion
    private DataGridView EventsDataGridView;
    private TabControl TabControl;
    private TabPage RawEventsTabPage;
    private TabPage WeeklySummaryTabPage;
    private DataGridView WeekDataGridView;
    private DataGridViewTextBoxColumn WeekNumber;
    private DataGridViewTextBoxColumn DateStart;
    private DataGridViewTextBoxColumn TotalTime;
    private DataGridViewTextBoxColumn Id;
    private DataGridViewTextBoxColumn Date;
    private DataGridViewTextBoxColumn Time;
    private DataGridViewTextBoxColumn Type;
    private DataGridViewButtonColumn Edit;
    private Panel BottomPanel;
    private Button CloseButton;
    private Panel FillPanel;
    private Panel TopPanel;
    private Button ApplyButton;
    private DateTimePicker ToDatePicker;
    private Label ToLabel;
    private Label FromLabel;
    private DateTimePicker FromDatePicker;
    private ContextMenuStrip EventContextMenuStrip;
    private ToolStripMenuItem EditToolStripMenuItem;
    private ToolStripMenuItem DeleteToolStripMenuItem;
    private Button button2;
    private ContextMenuStrip PredifinedContextMenuStrip;
    private ToolStripMenuItem ajourdhuiToolStripMenuItem;
    private ToolStripMenuItem ThisDayToolStripMenuItem;
    private ToolStripMenuItem LastDayToolStripMenuItem;
    private ToolStripSeparator toolStripSeparator1;
    private ToolStripMenuItem ThisWeekToolStripMenuItem;
    private ToolStripMenuItem LastWeekToolStripMenuItem;
    private ToolStripSeparator toolStripSeparator2;
    private ToolStripMenuItem ThisMonthToolStripMenuItem;
    private ToolStripMenuItem LastMonthToolStripMenuItem;
    private ToolStripSeparator toolStripSeparator3;
    private ToolStripMenuItem ThisYearToolStripMenuItem;
    private ToolStripMenuItem LastYearToolStripMenuItem;
    private Button AddEventButton;
  }
}
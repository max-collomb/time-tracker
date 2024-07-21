namespace time_tracker
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      components = new System.ComponentModel.Container();
      ChartPictureBox = new PictureBox();
      ClockInOutButton = new Button();
      TopPanel = new Panel();
      TopTableLayoutPanel = new TableLayoutPanel();
      DayTitleLabel = new Label();
      WeekTitleLabel = new Label();
      DayValueLabel = new Label();
      WeekValueLabel = new Label();
      CenterFlowLayoutPanel = new FlowLayoutPanel();
      CheckContextMenuStrip = new ContextMenuStrip(components);
      EditToolStripMenuItem = new ToolStripMenuItem();
      DeleteToolStripMenuItem = new ToolStripMenuItem();
      BottomPanel = new Panel();
      BottomRightPanel = new Panel();
      DetailsButton = new Button();
      MarginPanel = new Panel();
      OptionsButton = new Button();
      SecondTimer = new System.Windows.Forms.Timer(components);
      MainFormToolTip = new ToolTip(components);
      ((System.ComponentModel.ISupportInitialize)ChartPictureBox).BeginInit();
      TopPanel.SuspendLayout();
      TopTableLayoutPanel.SuspendLayout();
      CheckContextMenuStrip.SuspendLayout();
      BottomPanel.SuspendLayout();
      BottomRightPanel.SuspendLayout();
      SuspendLayout();
      // 
      // ChartPictureBox
      // 
      ChartPictureBox.Dock = DockStyle.Left;
      ChartPictureBox.Location = new Point(0, 0);
      ChartPictureBox.Name = "ChartPictureBox";
      ChartPictureBox.Size = new Size(181, 140);
      ChartPictureBox.TabIndex = 1;
      ChartPictureBox.TabStop = false;
      ChartPictureBox.Paint += ChartPictureBox_Paint;
      ChartPictureBox.MouseLeave += ChartPictureBox_MouseLeave;
      ChartPictureBox.MouseMove += ChartPictureBox_MouseMove;
      // 
      // ClockInOutButton
      // 
      ClockInOutButton.BackColor = Color.FromArgb(16, 24, 31);
      ClockInOutButton.Dock = DockStyle.Left;
      ClockInOutButton.FlatAppearance.BorderColor = Color.FromArgb(42, 58, 76);
      ClockInOutButton.FlatStyle = FlatStyle.Flat;
      ClockInOutButton.ForeColor = Color.White;
      ClockInOutButton.Location = new Point(10, 10);
      ClockInOutButton.Margin = new Padding(0, 0, 10, 0);
      ClockInOutButton.Name = "ClockInOutButton";
      ClockInOutButton.Size = new Size(80, 60);
      ClockInOutButton.TabIndex = 1;
      ClockInOutButton.UseVisualStyleBackColor = false;
      ClockInOutButton.Click += ClockInOutButton_Click;
      // 
      // TopPanel
      // 
      TopPanel.Controls.Add(TopTableLayoutPanel);
      TopPanel.Controls.Add(ClockInOutButton);
      TopPanel.Dock = DockStyle.Top;
      TopPanel.Location = new Point(0, 0);
      TopPanel.Name = "TopPanel";
      TopPanel.Padding = new Padding(10, 10, 0, 10);
      TopPanel.Size = new Size(224, 80);
      TopPanel.TabIndex = 2;
      // 
      // TopTableLayoutPanel
      // 
      TopTableLayoutPanel.ColumnCount = 2;
      TopTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 38.16794F));
      TopTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 61.83206F));
      TopTableLayoutPanel.Controls.Add(DayTitleLabel, 0, 0);
      TopTableLayoutPanel.Controls.Add(WeekTitleLabel, 0, 1);
      TopTableLayoutPanel.Controls.Add(DayValueLabel, 1, 0);
      TopTableLayoutPanel.Controls.Add(WeekValueLabel, 1, 1);
      TopTableLayoutPanel.Dock = DockStyle.Fill;
      TopTableLayoutPanel.Location = new Point(90, 10);
      TopTableLayoutPanel.Margin = new Padding(0);
      TopTableLayoutPanel.Name = "TopTableLayoutPanel";
      TopTableLayoutPanel.RowCount = 2;
      TopTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 51.6666679F));
      TopTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 48.3333321F));
      TopTableLayoutPanel.Size = new Size(134, 60);
      TopTableLayoutPanel.TabIndex = 2;
      // 
      // DayTitleLabel
      // 
      DayTitleLabel.AutoSize = true;
      DayTitleLabel.Dock = DockStyle.Fill;
      DayTitleLabel.ForeColor = Color.FromArgb(50, 93, 102);
      DayTitleLabel.Location = new Point(3, 0);
      DayTitleLabel.Name = "DayTitleLabel";
      DayTitleLabel.Size = new Size(45, 31);
      DayTitleLabel.TabIndex = 0;
      DayTitleLabel.Text = "Jour";
      DayTitleLabel.TextAlign = ContentAlignment.BottomRight;
      // 
      // WeekTitleLabel
      // 
      WeekTitleLabel.AutoSize = true;
      WeekTitleLabel.Dock = DockStyle.Fill;
      WeekTitleLabel.ForeColor = Color.FromArgb(50, 93, 102);
      WeekTitleLabel.Location = new Point(3, 31);
      WeekTitleLabel.Name = "WeekTitleLabel";
      WeekTitleLabel.Size = new Size(45, 29);
      WeekTitleLabel.TabIndex = 1;
      WeekTitleLabel.Text = "Sem";
      WeekTitleLabel.TextAlign = ContentAlignment.BottomRight;
      // 
      // DayValueLabel
      // 
      DayValueLabel.AutoSize = true;
      DayValueLabel.Dock = DockStyle.Fill;
      DayValueLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
      DayValueLabel.ForeColor = Color.FromArgb(224, 224, 224);
      DayValueLabel.Location = new Point(51, 0);
      DayValueLabel.Margin = new Padding(0);
      DayValueLabel.Name = "DayValueLabel";
      DayValueLabel.Size = new Size(83, 31);
      DayValueLabel.TabIndex = 2;
      DayValueLabel.Text = "--:--";
      DayValueLabel.TextAlign = ContentAlignment.BottomRight;
      // 
      // WeekValueLabel
      // 
      WeekValueLabel.AutoSize = true;
      WeekValueLabel.Dock = DockStyle.Fill;
      WeekValueLabel.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
      WeekValueLabel.ForeColor = Color.Silver;
      WeekValueLabel.Location = new Point(51, 31);
      WeekValueLabel.Margin = new Padding(0);
      WeekValueLabel.Name = "WeekValueLabel";
      WeekValueLabel.Padding = new Padding(0, 0, 3, 0);
      WeekValueLabel.Size = new Size(83, 29);
      WeekValueLabel.TabIndex = 3;
      WeekValueLabel.Text = "--:--";
      WeekValueLabel.TextAlign = ContentAlignment.BottomRight;
      // 
      // CenterFlowLayoutPanel
      // 
      CenterFlowLayoutPanel.Dock = DockStyle.Fill;
      CenterFlowLayoutPanel.Location = new Point(0, 80);
      CenterFlowLayoutPanel.Margin = new Padding(0);
      CenterFlowLayoutPanel.Name = "CenterFlowLayoutPanel";
      CenterFlowLayoutPanel.Padding = new Padding(10, 5, 10, 0);
      CenterFlowLayoutPanel.Size = new Size(224, 41);
      CenterFlowLayoutPanel.TabIndex = 3;
      // 
      // CheckContextMenuStrip
      // 
      CheckContextMenuStrip.Items.AddRange(new ToolStripItem[] { EditToolStripMenuItem, DeleteToolStripMenuItem });
      CheckContextMenuStrip.Name = "contextMenuStrip1";
      CheckContextMenuStrip.Size = new Size(130, 48);
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
      // BottomPanel
      // 
      BottomPanel.Controls.Add(BottomRightPanel);
      BottomPanel.Controls.Add(ChartPictureBox);
      BottomPanel.Dock = DockStyle.Bottom;
      BottomPanel.Location = new Point(0, 121);
      BottomPanel.Name = "BottomPanel";
      BottomPanel.Size = new Size(224, 140);
      BottomPanel.TabIndex = 0;
      // 
      // BottomRightPanel
      // 
      BottomRightPanel.Controls.Add(DetailsButton);
      BottomRightPanel.Controls.Add(MarginPanel);
      BottomRightPanel.Controls.Add(OptionsButton);
      BottomRightPanel.Dock = DockStyle.Right;
      BottomRightPanel.Location = new Point(184, 0);
      BottomRightPanel.Name = "BottomRightPanel";
      BottomRightPanel.Padding = new Padding(0, 0, 10, 10);
      BottomRightPanel.Size = new Size(40, 140);
      BottomRightPanel.TabIndex = 2;
      // 
      // DetailsButton
      // 
      DetailsButton.Dock = DockStyle.Bottom;
      DetailsButton.FlatAppearance.BorderColor = Color.FromArgb(42, 58, 76);
      DetailsButton.FlatStyle = FlatStyle.Flat;
      DetailsButton.ForeColor = Color.White;
      DetailsButton.Image = Properties.Resources.details;
      DetailsButton.Location = new Point(0, 60);
      DetailsButton.Name = "DetailsButton";
      DetailsButton.Size = new Size(30, 30);
      DetailsButton.TabIndex = 1;
      DetailsButton.TabStop = false;
      DetailsButton.UseVisualStyleBackColor = true;
      DetailsButton.Click += DetailsButton_Click;
      // 
      // MarginPanel
      // 
      MarginPanel.Dock = DockStyle.Bottom;
      MarginPanel.Location = new Point(0, 90);
      MarginPanel.Name = "MarginPanel";
      MarginPanel.Size = new Size(30, 10);
      MarginPanel.TabIndex = 2;
      // 
      // OptionsButton
      // 
      OptionsButton.Dock = DockStyle.Bottom;
      OptionsButton.FlatAppearance.BorderColor = Color.FromArgb(42, 58, 76);
      OptionsButton.FlatStyle = FlatStyle.Flat;
      OptionsButton.ForeColor = Color.White;
      OptionsButton.Image = Properties.Resources.options;
      OptionsButton.Location = new Point(0, 100);
      OptionsButton.Name = "OptionsButton";
      OptionsButton.Size = new Size(30, 30);
      OptionsButton.TabIndex = 0;
      OptionsButton.TabStop = false;
      OptionsButton.UseVisualStyleBackColor = true;
      OptionsButton.Click += OptionsButton_Click;
      // 
      // SecondTimer
      // 
      SecondTimer.Enabled = true;
      SecondTimer.Interval = 1000;
      SecondTimer.Tick += SecondTimer_Tick;
      // 
      // MainFormToolTip
      // 
      MainFormToolTip.AutomaticDelay = 100;
      MainFormToolTip.AutoPopDelay = 10000;
      MainFormToolTip.InitialDelay = 100;
      MainFormToolTip.ReshowDelay = 20;
      // 
      // MainForm
      // 
      AutoScaleDimensions = new SizeF(7F, 15F);
      AutoScaleMode = AutoScaleMode.Font;
      AutoSize = true;
      BackColor = Color.FromArgb(11, 16, 21);
      ClientSize = new Size(224, 261);
      Controls.Add(CenterFlowLayoutPanel);
      Controls.Add(TopPanel);
      Controls.Add(BottomPanel);
      FormBorderStyle = FormBorderStyle.FixedSingle;
      MaximizeBox = false;
      Name = "MainForm";
      FormClosing += MainForm_FormClosing;
      Load += MainForm_Load;
      ((System.ComponentModel.ISupportInitialize)ChartPictureBox).EndInit();
      TopPanel.ResumeLayout(false);
      TopTableLayoutPanel.ResumeLayout(false);
      TopTableLayoutPanel.PerformLayout();
      CheckContextMenuStrip.ResumeLayout(false);
      BottomPanel.ResumeLayout(false);
      BottomRightPanel.ResumeLayout(false);
      ResumeLayout(false);
    }

    #endregion
    private PictureBox ChartPictureBox;
        private Button ClockInOutButton;
        private Panel TopPanel;
        private TableLayoutPanel TopTableLayoutPanel;
        private Label DayTitleLabel;
        private Label WeekTitleLabel;
        private Label DayValueLabel;
        private Label WeekValueLabel;
        private FlowLayoutPanel CenterFlowLayoutPanel;
        private Panel BottomPanel;
        private Panel BottomRightPanel;
        private System.Windows.Forms.Timer SecondTimer;
        private ToolTip MainFormToolTip;
    private Label label2;
    private ContextMenuStrip CheckContextMenuStrip;
    private ToolStripMenuItem DeleteToolStripMenuItem;
    private ToolStripMenuItem EditToolStripMenuItem;
    private Button OptionsButton;
    private Panel MarginPanel;
    private Button DetailsButton;
  }
}

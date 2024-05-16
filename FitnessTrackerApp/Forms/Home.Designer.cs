namespace FitnessTrackerApp
{
    partial class Home
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Tabs = new System.Windows.Forms.TabControl();
            this.HomeTab = new System.Windows.Forms.TabPage();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.exrRecordLbl = new System.Windows.Forms.Label();
            this.exrVolumeLbl = new System.Windows.Forms.Label();
            this.exrTimeLbl = new System.Windows.Forms.Label();
            this.latestExcerizeNameLbl = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.Routins = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.addRoutinBtn = new System.Windows.Forms.Button();
            this.routinPanel = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.routinNameLbl = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.startRoutBtn = new System.Windows.Forms.Button();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.Exercises = new System.Windows.Forms.TabPage();
            this.exercisPanel = new System.Windows.Forms.Panel();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.DateLbl = new System.Windows.Forms.Label();
            this.recordTab = new System.Windows.Forms.TabPage();
            this.recordsPanel = new System.Windows.Forms.Panel();
            this.recordDetailsDGV = new System.Windows.Forms.DataGridView();
            this.routinsList = new System.Windows.Forms.ListBox();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.delRecBtn = new System.Windows.Forms.DataGridViewImageColumn();
            this.tableLayoutPanel1.SuspendLayout();
            this.Tabs.SuspendLayout();
            this.HomeTab.SuspendLayout();
            this.mainPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.Routins.SuspendLayout();
            this.panel3.SuspendLayout();
            this.routinPanel.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.Exercises.SuspendLayout();
            this.exercisPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.panel2.SuspendLayout();
            this.recordTab.SuspendLayout();
            this.recordsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.recordDetailsDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.Tabs, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.758427F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 94.24157F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1296, 835);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // Tabs
            // 
            this.Tabs.Controls.Add(this.HomeTab);
            this.Tabs.Controls.Add(this.Routins);
            this.Tabs.Controls.Add(this.Exercises);
            this.Tabs.Controls.Add(this.recordTab);
            this.Tabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Tabs.Location = new System.Drawing.Point(3, 51);
            this.Tabs.Name = "Tabs";
            this.Tabs.Padding = new System.Drawing.Point(10, 10);
            this.Tabs.SelectedIndex = 0;
            this.Tabs.Size = new System.Drawing.Size(1290, 781);
            this.Tabs.TabIndex = 2;
            // 
            // HomeTab
            // 
            this.HomeTab.Controls.Add(this.mainPanel);
            this.HomeTab.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HomeTab.Location = new System.Drawing.Point(4, 39);
            this.HomeTab.Name = "HomeTab";
            this.HomeTab.Padding = new System.Windows.Forms.Padding(3);
            this.HomeTab.Size = new System.Drawing.Size(1282, 738);
            this.HomeTab.TabIndex = 0;
            this.HomeTab.Text = "Home";
            this.HomeTab.ToolTipText = "Home";
            this.HomeTab.UseVisualStyleBackColor = true;
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.mainPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mainPanel.Controls.Add(this.panel1);
            this.mainPanel.Controls.Add(this.label1);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(3, 3);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(1276, 732);
            this.mainPanel.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FloralWhite;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.exrRecordLbl);
            this.panel1.Controls.Add(this.exrVolumeLbl);
            this.panel1.Controls.Add(this.exrTimeLbl);
            this.panel1.Controls.Add(this.latestExcerizeNameLbl);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(39, 96);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1196, 604);
            this.panel1.TabIndex = 1;
            // 
            // exrRecordLbl
            // 
            this.exrRecordLbl.AutoSize = true;
            this.exrRecordLbl.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exrRecordLbl.ForeColor = System.Drawing.Color.MidnightBlue;
            this.exrRecordLbl.Location = new System.Drawing.Point(61, 427);
            this.exrRecordLbl.Name = "exrRecordLbl";
            this.exrRecordLbl.Size = new System.Drawing.Size(129, 39);
            this.exrRecordLbl.TabIndex = 5;
            this.exrRecordLbl.Text = "[record]";
            // 
            // exrVolumeLbl
            // 
            this.exrVolumeLbl.AutoSize = true;
            this.exrVolumeLbl.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exrVolumeLbl.ForeColor = System.Drawing.Color.MidnightBlue;
            this.exrVolumeLbl.Location = new System.Drawing.Point(61, 292);
            this.exrVolumeLbl.Name = "exrVolumeLbl";
            this.exrVolumeLbl.Size = new System.Drawing.Size(141, 39);
            this.exrVolumeLbl.TabIndex = 5;
            this.exrVolumeLbl.Text = "[000 KG]";
            // 
            // exrTimeLbl
            // 
            this.exrTimeLbl.AutoSize = true;
            this.exrTimeLbl.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exrTimeLbl.ForeColor = System.Drawing.Color.MidnightBlue;
            this.exrTimeLbl.Location = new System.Drawing.Point(61, 157);
            this.exrTimeLbl.Name = "exrTimeLbl";
            this.exrTimeLbl.Size = new System.Drawing.Size(159, 39);
            this.exrTimeLbl.TabIndex = 5;
            this.exrTimeLbl.Text = "[00:00:00]";
            // 
            // latestExcerizeNameLbl
            // 
            this.latestExcerizeNameLbl.AutoSize = true;
            this.latestExcerizeNameLbl.Font = new System.Drawing.Font("Microsoft YaHei UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.latestExcerizeNameLbl.ForeColor = System.Drawing.Color.MidnightBlue;
            this.latestExcerizeNameLbl.Location = new System.Drawing.Point(19, 17);
            this.latestExcerizeNameLbl.Name = "latestExcerizeNameLbl";
            this.latestExcerizeNameLbl.Size = new System.Drawing.Size(322, 50);
            this.latestExcerizeNameLbl.TabIndex = 4;
            this.latestExcerizeNameLbl.Text = "[exercise_name]";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label4.Location = new System.Drawing.Point(20, 371);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 40);
            this.label4.TabIndex = 3;
            this.label4.Text = "Record";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label3.Location = new System.Drawing.Point(20, 236);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 40);
            this.label3.TabIndex = 2;
            this.label3.Text = "Volume";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label2.Location = new System.Drawing.Point(20, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 40);
            this.label2.TabIndex = 1;
            this.label2.Text = "Time";
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.Location = new System.Drawing.Point(299, 101);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(865, 471);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(346, 60);
            this.label1.TabIndex = 0;
            this.label1.Text = "Latest Exercise";
            // 
            // Routins
            // 
            this.Routins.Controls.Add(this.panel3);
            this.Routins.Location = new System.Drawing.Point(4, 39);
            this.Routins.Name = "Routins";
            this.Routins.Size = new System.Drawing.Size(1282, 738);
            this.Routins.TabIndex = 2;
            this.Routins.Text = "Routins";
            this.Routins.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.addRoutinBtn);
            this.panel3.Controls.Add(this.routinPanel);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1282, 738);
            this.panel3.TabIndex = 0;
            // 
            // addRoutinBtn
            // 
            this.addRoutinBtn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.addRoutinBtn.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addRoutinBtn.Location = new System.Drawing.Point(16, 15);
            this.addRoutinBtn.Name = "addRoutinBtn";
            this.addRoutinBtn.Size = new System.Drawing.Size(231, 63);
            this.addRoutinBtn.TabIndex = 1;
            this.addRoutinBtn.Text = "Add New Routin ...";
            this.addRoutinBtn.UseVisualStyleBackColor = false;
            // 
            // routinPanel
            // 
            this.routinPanel.BackColor = System.Drawing.Color.LavenderBlush;
            this.routinPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.routinPanel.Controls.Add(this.panel5);
            this.routinPanel.Controls.Add(this.vScrollBar1);
            this.routinPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.routinPanel.Location = new System.Drawing.Point(0, 93);
            this.routinPanel.Name = "routinPanel";
            this.routinPanel.Size = new System.Drawing.Size(1282, 645);
            this.routinPanel.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.OldLace;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.dataGridView3);
            this.panel5.Controls.Add(this.routinNameLbl);
            this.panel5.Controls.Add(this.groupBox1);
            this.panel5.Controls.Add(this.startRoutBtn);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1252, 190);
            this.panel5.TabIndex = 0;
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(426, 25);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowHeadersWidth = 51;
            this.dataGridView3.RowTemplate.Height = 24;
            this.dataGridView3.Size = new System.Drawing.Size(527, 146);
            this.dataGridView3.TabIndex = 6;
            // 
            // routinNameLbl
            // 
            this.routinNameLbl.AutoSize = true;
            this.routinNameLbl.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.routinNameLbl.Location = new System.Drawing.Point(23, 25);
            this.routinNameLbl.Name = "routinNameLbl";
            this.routinNameLbl.Size = new System.Drawing.Size(123, 23);
            this.routinNameLbl.TabIndex = 5;
            this.routinNameLbl.Text = "[routin_name]";
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(27, 61);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(350, 110);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // startRoutBtn
            // 
            this.startRoutBtn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.startRoutBtn.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startRoutBtn.Location = new System.Drawing.Point(1052, 66);
            this.startRoutBtn.Name = "startRoutBtn";
            this.startRoutBtn.Size = new System.Drawing.Size(169, 64);
            this.startRoutBtn.TabIndex = 2;
            this.startRoutBtn.Text = "Start Routin";
            this.startRoutBtn.UseVisualStyleBackColor = false;
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Dock = System.Windows.Forms.DockStyle.Right;
            this.vScrollBar1.Location = new System.Drawing.Point(1252, 0);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(28, 643);
            this.vScrollBar1.TabIndex = 1;
            // 
            // Exercises
            // 
            this.Exercises.Controls.Add(this.exercisPanel);
            this.Exercises.Location = new System.Drawing.Point(4, 39);
            this.Exercises.Name = "Exercises";
            this.Exercises.Padding = new System.Windows.Forms.Padding(3);
            this.Exercises.Size = new System.Drawing.Size(1282, 738);
            this.Exercises.TabIndex = 1;
            this.Exercises.Text = "Exercises";
            this.Exercises.UseVisualStyleBackColor = true;
            // 
            // exercisPanel
            // 
            this.exercisPanel.BackColor = System.Drawing.Color.Snow;
            this.exercisPanel.Controls.Add(this.dataGridView2);
            this.exercisPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.exercisPanel.Location = new System.Drawing.Point(3, 3);
            this.exercisPanel.Name = "exercisPanel";
            this.exercisPanel.Size = new System.Drawing.Size(1276, 732);
            this.exercisPanel.TabIndex = 0;
            // 
            // dataGridView2
            // 
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(35, 91);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(1213, 605);
            this.dataGridView2.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.DateLbl);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1290, 42);
            this.panel2.TabIndex = 3;
            // 
            // DateLbl
            // 
            this.DateLbl.AutoSize = true;
            this.DateLbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DateLbl.Font = new System.Drawing.Font("Microsoft Tai Le", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateLbl.Location = new System.Drawing.Point(49, 0);
            this.DateLbl.Name = "DateLbl";
            this.DateLbl.Size = new System.Drawing.Size(189, 36);
            this.DateLbl.TabIndex = 6;
            this.DateLbl.Text = "[yyyy/mm/dd]";
            // 
            // recordTab
            // 
            this.recordTab.Controls.Add(this.recordsPanel);
            this.recordTab.Location = new System.Drawing.Point(4, 39);
            this.recordTab.Name = "recordTab";
            this.recordTab.Padding = new System.Windows.Forms.Padding(3);
            this.recordTab.Size = new System.Drawing.Size(1282, 738);
            this.recordTab.TabIndex = 3;
            this.recordTab.Text = "Records";
            this.recordTab.UseVisualStyleBackColor = true;
            // 
            // recordsPanel
            // 
            this.recordsPanel.BackColor = System.Drawing.Color.Linen;
            this.recordsPanel.Controls.Add(this.routinsList);
            this.recordsPanel.Controls.Add(this.recordDetailsDGV);
            this.recordsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.recordsPanel.Location = new System.Drawing.Point(3, 3);
            this.recordsPanel.Name = "recordsPanel";
            this.recordsPanel.Size = new System.Drawing.Size(1276, 732);
            this.recordsPanel.TabIndex = 0;
            // 
            // recordDetailsDGV
            // 
            this.recordDetailsDGV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.recordDetailsDGV.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.recordDetailsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.recordDetailsDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.delRecBtn});
            this.recordDetailsDGV.Location = new System.Drawing.Point(332, 44);
            this.recordDetailsDGV.Name = "recordDetailsDGV";
            this.recordDetailsDGV.RowHeadersWidth = 51;
            this.recordDetailsDGV.RowTemplate.Height = 24;
            this.recordDetailsDGV.Size = new System.Drawing.Size(908, 656);
            this.recordDetailsDGV.TabIndex = 0;
            // 
            // routinsList
            // 
            this.routinsList.FormattingEnabled = true;
            this.routinsList.ItemHeight = 16;
            this.routinsList.Location = new System.Drawing.Point(28, 40);
            this.routinsList.Name = "routinsList";
            this.routinsList.Size = new System.Drawing.Size(284, 660);
            this.routinsList.TabIndex = 1;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "";
            this.dataGridViewImageColumn1.Image = global::FitnessTrackerApp.Properties.Resources.images;
            this.dataGridViewImageColumn1.MinimumWidth = 6;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Width = 125;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = global::FitnessTrackerApp.Properties.Resources.new_text_logo_repify_small_;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(49, 42);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // delRecBtn
            // 
            this.delRecBtn.HeaderText = "";
            this.delRecBtn.Image = global::FitnessTrackerApp.Properties.Resources.images;
            this.delRecBtn.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.delRecBtn.MinimumWidth = 6;
            this.delRecBtn.Name = "delRecBtn";
            this.delRecBtn.ToolTipText = "Delete";
            this.delRecBtn.Width = 125;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1296, 835);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Home";
            this.Text = "Home";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.Tabs.ResumeLayout(false);
            this.HomeTab.ResumeLayout(false);
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.Routins.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.routinPanel.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.Exercises.ResumeLayout(false);
            this.exercisPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.recordTab.ResumeLayout(false);
            this.recordsPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.recordDetailsDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TabControl Tabs;
        private System.Windows.Forms.TabPage HomeTab;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage Exercises;
        private System.Windows.Forms.TabPage Routins;
        public System.Windows.Forms.Label exrRecordLbl;
        public System.Windows.Forms.Label exrVolumeLbl;
        public System.Windows.Forms.Label exrTimeLbl;
        public System.Windows.Forms.Label latestExcerizeNameLbl;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.Label DateLbl;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel exercisPanel;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Panel routinPanel;
        private System.Windows.Forms.VScrollBar vScrollBar1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button addRoutinBtn;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Label routinNameLbl;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button startRoutBtn;
        private System.Windows.Forms.TabPage recordTab;
        private System.Windows.Forms.Panel recordsPanel;
        private System.Windows.Forms.ListBox routinsList;
        private System.Windows.Forms.DataGridView recordDetailsDGV;
        private System.Windows.Forms.DataGridViewImageColumn delRecBtn;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
    }
}
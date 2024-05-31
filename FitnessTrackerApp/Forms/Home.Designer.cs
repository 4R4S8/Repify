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
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.routinPanel = new System.Windows.Forms.Panel();
            this.Exercises = new System.Windows.Forms.TabPage();
            this.exercisPanel = new System.Windows.Forms.Panel();
            this.exercisesDGV = new System.Windows.Forms.DataGridView();
            this.recordTab = new System.Windows.Forms.TabPage();
            this.recordsPanel = new System.Windows.Forms.Panel();
            this.routinsList = new System.Windows.Forms.ListBox();
            this.recordDetailsDGV = new System.Windows.Forms.DataGridView();
            this.delRecBtn = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.DateLbl = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.tableLayoutPanel1.SuspendLayout();
            this.Tabs.SuspendLayout();
            this.HomeTab.SuspendLayout();
            this.mainPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.Routins.SuspendLayout();
            this.panel3.SuspendLayout();
            this.Exercises.SuspendLayout();
            this.exercisPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.exercisesDGV)).BeginInit();
            this.recordTab.SuspendLayout();
            this.recordsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.recordDetailsDGV)).BeginInit();
            this.panel2.SuspendLayout();
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
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.758427F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 94.24157F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1296, 834);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // Tabs
            // 
            this.Tabs.Controls.Add(this.HomeTab);
            this.Tabs.Controls.Add(this.Routins);
            this.Tabs.Controls.Add(this.Exercises);
            this.Tabs.Controls.Add(this.recordTab);
            this.Tabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Tabs.Location = new System.Drawing.Point(3, 50);
            this.Tabs.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Tabs.Name = "Tabs";
            this.Tabs.Padding = new System.Drawing.Point(10, 10);
            this.Tabs.SelectedIndex = 0;
            this.Tabs.Size = new System.Drawing.Size(1290, 782);
            this.Tabs.TabIndex = 2;
            this.Tabs.SelectedIndexChanged += new System.EventHandler(this.Tabs_SelectedIndexChanged);
            // 
            // HomeTab
            // 
            this.HomeTab.Controls.Add(this.mainPanel);
            this.HomeTab.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HomeTab.Location = new System.Drawing.Point(4, 39);
            this.HomeTab.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.HomeTab.Name = "HomeTab";
            this.HomeTab.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.HomeTab.Size = new System.Drawing.Size(1282, 739);
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
            this.mainPanel.Location = new System.Drawing.Point(3, 2);
            this.mainPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(1276, 735);
            this.mainPanel.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1197, 604);
            this.panel1.TabIndex = 1;
            // 
            // exrRecordLbl
            // 
            this.exrRecordLbl.AutoSize = true;
            this.exrRecordLbl.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 15F);
            this.exrRecordLbl.ForeColor = System.Drawing.Color.MidnightBlue;
            this.exrRecordLbl.Location = new System.Drawing.Point(61, 427);
            this.exrRecordLbl.Name = "exrRecordLbl";
            this.exrRecordLbl.Size = new System.Drawing.Size(83, 27);
            this.exrRecordLbl.TabIndex = 5;
            this.exrRecordLbl.Text = "[record]";
            // 
            // exrVolumeLbl
            // 
            this.exrVolumeLbl.AutoSize = true;
            this.exrVolumeLbl.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 15F);
            this.exrVolumeLbl.ForeColor = System.Drawing.Color.MidnightBlue;
            this.exrVolumeLbl.Location = new System.Drawing.Point(61, 292);
            this.exrVolumeLbl.Name = "exrVolumeLbl";
            this.exrVolumeLbl.Size = new System.Drawing.Size(88, 27);
            this.exrVolumeLbl.TabIndex = 5;
            this.exrVolumeLbl.Text = "[000 KG]";
            // 
            // exrTimeLbl
            // 
            this.exrTimeLbl.AutoSize = true;
            this.exrTimeLbl.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 15F);
            this.exrTimeLbl.ForeColor = System.Drawing.Color.MidnightBlue;
            this.exrTimeLbl.Location = new System.Drawing.Point(61, 158);
            this.exrTimeLbl.Name = "exrTimeLbl";
            this.exrTimeLbl.Size = new System.Drawing.Size(100, 27);
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
            this.latestExcerizeNameLbl.Size = new System.Drawing.Size(258, 40);
            this.latestExcerizeNameLbl.TabIndex = 4;
            this.latestExcerizeNameLbl.Text = "[exercise_name]";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label4.Location = new System.Drawing.Point(20, 370);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 31);
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
            this.label3.Size = new System.Drawing.Size(108, 31);
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
            this.label2.Size = new System.Drawing.Size(74, 31);
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
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.label1.Location = new System.Drawing.Point(29, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(283, 49);
            this.label1.TabIndex = 0;
            this.label1.Text = "Latest Exercise";
            // 
            // Routins
            // 
            this.Routins.Controls.Add(this.panel3);
            this.Routins.Location = new System.Drawing.Point(4, 39);
            this.Routins.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Routins.Name = "Routins";
            this.Routins.Size = new System.Drawing.Size(1282, 739);
            this.Routins.TabIndex = 2;
            this.Routins.Text = "Routins";
            this.Routins.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.addRoutinBtn);
            this.panel3.Controls.Add(this.vScrollBar1);
            this.panel3.Controls.Add(this.routinPanel);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1282, 739);
            this.panel3.TabIndex = 0;
            // 
            // addRoutinBtn
            // 
            this.addRoutinBtn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.addRoutinBtn.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addRoutinBtn.Location = new System.Drawing.Point(9, 18);
            this.addRoutinBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addRoutinBtn.Name = "addRoutinBtn";
            this.addRoutinBtn.Size = new System.Drawing.Size(231, 63);
            this.addRoutinBtn.TabIndex = 1;
            this.addRoutinBtn.Text = "Add New Routin ...";
            this.addRoutinBtn.UseVisualStyleBackColor = false;
            this.addRoutinBtn.Click += new System.EventHandler(this.addRoutinBtn_Click);
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Dock = System.Windows.Forms.DockStyle.Right;
            this.vScrollBar1.Location = new System.Drawing.Point(1254, 0);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(28, 739);
            this.vScrollBar1.TabIndex = 1;
            // 
            // routinPanel
            // 
            this.routinPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.routinPanel.BackColor = System.Drawing.Color.LavenderBlush;
            this.routinPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.routinPanel.Location = new System.Drawing.Point(9, 90);
            this.routinPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.routinPanel.Name = "routinPanel";
            this.routinPanel.Size = new System.Drawing.Size(1229, 632);
            this.routinPanel.TabIndex = 0;
            // 
            // Exercises
            // 
            this.Exercises.Controls.Add(this.exercisPanel);
            this.Exercises.Location = new System.Drawing.Point(4, 39);
            this.Exercises.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Exercises.Name = "Exercises";
            this.Exercises.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Exercises.Size = new System.Drawing.Size(1282, 739);
            this.Exercises.TabIndex = 1;
            this.Exercises.Text = "Exercises";
            this.Exercises.UseVisualStyleBackColor = true;
            // 
            // exercisPanel
            // 
            this.exercisPanel.BackColor = System.Drawing.Color.Snow;
            this.exercisPanel.Controls.Add(this.exercisesDGV);
            this.exercisPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.exercisPanel.Location = new System.Drawing.Point(3, 2);
            this.exercisPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.exercisPanel.Name = "exercisPanel";
            this.exercisPanel.Size = new System.Drawing.Size(1276, 735);
            this.exercisPanel.TabIndex = 0;
            // 
            // exercisesDGV
            // 
            this.exercisesDGV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.exercisesDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.exercisesDGV.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.exercisesDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.exercisesDGV.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.exercisesDGV.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.exercisesDGV.Location = new System.Drawing.Point(29, 30);
            this.exercisesDGV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.exercisesDGV.MultiSelect = false;
            this.exercisesDGV.Name = "exercisesDGV";
            this.exercisesDGV.ReadOnly = true;
            this.exercisesDGV.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.exercisesDGV.RowHeadersWidth = 51;
            this.exercisesDGV.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.exercisesDGV.RowTemplate.Height = 24;
            this.exercisesDGV.Size = new System.Drawing.Size(1227, 683);
            this.exercisesDGV.TabIndex = 0;
            // 
            // recordTab
            // 
            this.recordTab.Controls.Add(this.recordsPanel);
            this.recordTab.Location = new System.Drawing.Point(4, 39);
            this.recordTab.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.recordTab.Name = "recordTab";
            this.recordTab.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.recordTab.Size = new System.Drawing.Size(1282, 739);
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
            this.recordsPanel.Location = new System.Drawing.Point(3, 2);
            this.recordsPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.recordsPanel.Name = "recordsPanel";
            this.recordsPanel.Size = new System.Drawing.Size(1276, 735);
            this.recordsPanel.TabIndex = 0;
            // 
            // routinsList
            // 
            this.routinsList.FormattingEnabled = true;
            this.routinsList.ItemHeight = 16;
            this.routinsList.Location = new System.Drawing.Point(28, 39);
            this.routinsList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.routinsList.Name = "routinsList";
            this.routinsList.Size = new System.Drawing.Size(284, 660);
            this.routinsList.TabIndex = 1;
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
            this.recordDetailsDGV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.recordDetailsDGV.Name = "recordDetailsDGV";
            this.recordDetailsDGV.RowHeadersWidth = 51;
            this.recordDetailsDGV.RowTemplate.Height = 24;
            this.recordDetailsDGV.Size = new System.Drawing.Size(908, 659);
            this.recordDetailsDGV.TabIndex = 0;
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
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel2.Controls.Add(this.DateLbl);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 2);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1290, 44);
            this.panel2.TabIndex = 3;
            // 
            // DateLbl
            // 
            this.DateLbl.AutoSize = true;
            this.DateLbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DateLbl.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 15F);
            this.DateLbl.Location = new System.Drawing.Point(139, 0);
            this.DateLbl.Name = "DateLbl";
            this.DateLbl.Size = new System.Drawing.Size(140, 27);
            this.DateLbl.TabIndex = 6;
            this.DateLbl.Text = "[yyyy/mm/dd]";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = global::FitnessTrackerApp.Properties.Resources.new_text_logo_repify_small_;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(139, 44);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "";
            this.dataGridViewImageColumn1.Image = global::FitnessTrackerApp.Properties.Resources.images;
            this.dataGridViewImageColumn1.MinimumWidth = 6;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Width = 125;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1296, 834);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Home_Load);
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
            this.Exercises.ResumeLayout(false);
            this.exercisPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.exercisesDGV)).EndInit();
            this.recordTab.ResumeLayout(false);
            this.recordsPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.recordDetailsDGV)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
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
        private System.Windows.Forms.DataGridView exercisesDGV;
        private System.Windows.Forms.Panel routinPanel;
        private System.Windows.Forms.VScrollBar vScrollBar1;
        private System.Windows.Forms.Button addRoutinBtn;
        private System.Windows.Forms.TabPage recordTab;
        private System.Windows.Forms.Panel recordsPanel;
        private System.Windows.Forms.ListBox routinsList;
        private System.Windows.Forms.DataGridView recordDetailsDGV;
        private System.Windows.Forms.DataGridViewImageColumn delRecBtn;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
    }
}
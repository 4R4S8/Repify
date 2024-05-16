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
            this.Exercises = new System.Windows.Forms.TabPage();
            this.exercisPanel = new System.Windows.Forms.Panel();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.DateLbl = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.Tabs.SuspendLayout();
            this.HomeTab.SuspendLayout();
            this.mainPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.Routins.SuspendLayout();
            this.Exercises.SuspendLayout();
            this.exercisPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
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
            this.exrRecordLbl.Font = new System.Drawing.Font("Microsoft Tai Le", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exrRecordLbl.Location = new System.Drawing.Point(61, 427);
            this.exrRecordLbl.Name = "exrRecordLbl";
            this.exrRecordLbl.Size = new System.Drawing.Size(130, 42);
            this.exrRecordLbl.TabIndex = 5;
            this.exrRecordLbl.Text = "[record]";
            // 
            // exrVolumeLbl
            // 
            this.exrVolumeLbl.AutoSize = true;
            this.exrVolumeLbl.Font = new System.Drawing.Font("Microsoft Tai Le", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exrVolumeLbl.Location = new System.Drawing.Point(61, 292);
            this.exrVolumeLbl.Name = "exrVolumeLbl";
            this.exrVolumeLbl.Size = new System.Drawing.Size(143, 42);
            this.exrVolumeLbl.TabIndex = 5;
            this.exrVolumeLbl.Text = "[000 KG]";
            // 
            // exrTimeLbl
            // 
            this.exrTimeLbl.AutoSize = true;
            this.exrTimeLbl.Font = new System.Drawing.Font("Microsoft Tai Le", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exrTimeLbl.Location = new System.Drawing.Point(61, 157);
            this.exrTimeLbl.Name = "exrTimeLbl";
            this.exrTimeLbl.Size = new System.Drawing.Size(160, 42);
            this.exrTimeLbl.TabIndex = 5;
            this.exrTimeLbl.Text = "[00:00:00]";
            // 
            // latestExcerizeNameLbl
            // 
            this.latestExcerizeNameLbl.AutoSize = true;
            this.latestExcerizeNameLbl.Font = new System.Drawing.Font("Microsoft Tai Le", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.latestExcerizeNameLbl.Location = new System.Drawing.Point(19, 17);
            this.latestExcerizeNameLbl.Name = "latestExcerizeNameLbl";
            this.latestExcerizeNameLbl.Size = new System.Drawing.Size(299, 48);
            this.latestExcerizeNameLbl.TabIndex = 4;
            this.latestExcerizeNameLbl.Text = "[exercise_name]";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 19.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(20, 371);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 41);
            this.label4.TabIndex = 3;
            this.label4.Text = "Record";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 19.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 236);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 41);
            this.label3.TabIndex = 2;
            this.label3.Text = "Volume";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 19.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 41);
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
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(298, 51);
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
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1282, 738);
            this.panel3.TabIndex = 0;
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
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView2.Location = new System.Drawing.Point(0, 127);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(1276, 605);
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
            this.Exercises.ResumeLayout(false);
            this.exercisPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
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
        private System.Windows.Forms.DataGridView dataGridView2;
    }
}
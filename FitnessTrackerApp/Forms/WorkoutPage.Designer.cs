namespace FitnessTrackerApp.Forms
{
    partial class WorkoutPage
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
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.routinPanel = new System.Windows.Forms.Panel();
            this.exerPanel = new System.Windows.Forms.Panel();
            this.weight_lbl = new System.Windows.Forms.Label();
            this.setDoneCheck = new System.Windows.Forms.CheckBox();
            this.exerPic = new System.Windows.Forms.PictureBox();
            this.set_repLbl = new System.Windows.Forms.Label();
            this.exerciseNameLbl = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.timespanLbl = new System.Windows.Forms.Label();
            this.routinNameLbl = new System.Windows.Forms.Label();
            this.finishBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.closePic = new System.Windows.Forms.PictureBox();
            this.routinProgress = new System.Windows.Forms.ProgressBar();
            this.tableLayoutPanel1.SuspendLayout();
            this.routinPanel.SuspendLayout();
            this.exerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.exerPic)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.closePic)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tableLayoutPanel1.Controls.Add(this.vScrollBar1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.routinPanel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel4, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.32333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 88.67667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1057, 733);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.vScrollBar1.Location = new System.Drawing.Point(1026, 83);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(31, 650);
            this.vScrollBar1.TabIndex = 0;
            // 
            // routinPanel
            // 
            this.routinPanel.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.routinPanel.Controls.Add(this.exerPanel);
            this.routinPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.routinPanel.Location = new System.Drawing.Point(3, 86);
            this.routinPanel.Name = "routinPanel";
            this.routinPanel.Size = new System.Drawing.Size(1020, 644);
            this.routinPanel.TabIndex = 1;
            // 
            // exerPanel
            // 
            this.exerPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.exerPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.exerPanel.Controls.Add(this.weight_lbl);
            this.exerPanel.Controls.Add(this.setDoneCheck);
            this.exerPanel.Controls.Add(this.exerPic);
            this.exerPanel.Controls.Add(this.set_repLbl);
            this.exerPanel.Controls.Add(this.exerciseNameLbl);
            this.exerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.exerPanel.Location = new System.Drawing.Point(0, 0);
            this.exerPanel.Name = "exerPanel";
            this.exerPanel.Size = new System.Drawing.Size(1020, 77);
            this.exerPanel.TabIndex = 0;
            // 
            // weight_lbl
            // 
            this.weight_lbl.AutoSize = true;
            this.weight_lbl.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.weight_lbl.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weight_lbl.ForeColor = System.Drawing.Color.SaddleBrown;
            this.weight_lbl.Location = new System.Drawing.Point(229, 21);
            this.weight_lbl.Name = "weight_lbl";
            this.weight_lbl.Size = new System.Drawing.Size(197, 40);
            this.weight_lbl.TabIndex = 11;
            this.weight_lbl.Text = "[weight KG]";
            // 
            // setDoneCheck
            // 
            this.setDoneCheck.AutoSize = true;
            this.setDoneCheck.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.setDoneCheck.Location = new System.Drawing.Point(27, 15);
            this.setDoneCheck.Name = "setDoneCheck";
            this.setDoneCheck.Size = new System.Drawing.Size(119, 44);
            this.setDoneCheck.TabIndex = 10;
            this.setDoneCheck.Text = "Done";
            this.setDoneCheck.UseVisualStyleBackColor = true;
            this.setDoneCheck.CheckedChanged += new System.EventHandler(this.setDoneCheck_CheckedChanged);
            // 
            // exerPic
            // 
            this.exerPic.Image = global::FitnessTrackerApp.Properties.Resources._28931101_Scissors__advanced___female__small_thumbnail_3x;
            this.exerPic.Location = new System.Drawing.Point(945, 4);
            this.exerPic.Name = "exerPic";
            this.exerPic.Size = new System.Drawing.Size(70, 70);
            this.exerPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.exerPic.TabIndex = 6;
            this.exerPic.TabStop = false;
            // 
            // set_repLbl
            // 
            this.set_repLbl.AutoSize = true;
            this.set_repLbl.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.set_repLbl.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.set_repLbl.ForeColor = System.Drawing.Color.SaddleBrown;
            this.set_repLbl.Location = new System.Drawing.Point(439, 21);
            this.set_repLbl.Name = "set_repLbl";
            this.set_repLbl.Size = new System.Drawing.Size(168, 40);
            this.set_repLbl.TabIndex = 7;
            this.set_repLbl.Text = "[set * rep]";
            // 
            // exerciseNameLbl
            // 
            this.exerciseNameLbl.AutoEllipsis = true;
            this.exerciseNameLbl.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.exerciseNameLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.exerciseNameLbl.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exerciseNameLbl.ForeColor = System.Drawing.Color.SaddleBrown;
            this.exerciseNameLbl.Location = new System.Drawing.Point(605, 4);
            this.exerciseNameLbl.Name = "exerciseNameLbl";
            this.exerciseNameLbl.Size = new System.Drawing.Size(305, 69);
            this.exerciseNameLbl.TabIndex = 12;
            this.exerciseNameLbl.Text = "dhgsvahvdhsgavdhvashdvshvha";
            this.exerciseNameLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel2.Controls.Add(this.routinProgress);
            this.panel2.Controls.Add(this.timespanLbl);
            this.panel2.Controls.Add(this.routinNameLbl);
            this.panel2.Controls.Add(this.finishBtn);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1020, 77);
            this.panel2.TabIndex = 2;
            // 
            // timespanLbl
            // 
            this.timespanLbl.AutoSize = true;
            this.timespanLbl.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timespanLbl.ForeColor = System.Drawing.Color.SaddleBrown;
            this.timespanLbl.Location = new System.Drawing.Point(778, 18);
            this.timespanLbl.Name = "timespanLbl";
            this.timespanLbl.Size = new System.Drawing.Size(149, 40);
            this.timespanLbl.TabIndex = 4;
            this.timespanLbl.Text = "00:00:00";
            // 
            // routinNameLbl
            // 
            this.routinNameLbl.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.routinNameLbl.ForeColor = System.Drawing.Color.SaddleBrown;
            this.routinNameLbl.Location = new System.Drawing.Point(398, 3);
            this.routinNameLbl.Name = "routinNameLbl";
            this.routinNameLbl.Size = new System.Drawing.Size(277, 60);
            this.routinNameLbl.TabIndex = 3;
            this.routinNameLbl.Text = "[routin_name]";
            this.routinNameLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // finishBtn
            // 
            this.finishBtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.finishBtn.Location = new System.Drawing.Point(8, 13);
            this.finishBtn.Name = "finishBtn";
            this.finishBtn.Size = new System.Drawing.Size(180, 53);
            this.finishBtn.TabIndex = 2;
            this.finishBtn.Text = "Finish";
            this.finishBtn.UseVisualStyleBackColor = true;
            this.finishBtn.Click += new System.EventHandler(this.finishBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(697, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "Time :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(289, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Routine :";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.closePic);
            this.panel4.Location = new System.Drawing.Point(1029, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(25, 77);
            this.panel4.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Dock = System.Windows.Forms.DockStyle.Top;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 38);
            this.label5.TabIndex = 4;
            this.label5.Text = "X";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label5.Click += new System.EventHandler(this.label5_Click_1);
            // 
            // closePic
            // 
            this.closePic.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.closePic.Image = global::FitnessTrackerApp.Properties.Resources.new_text_logo_repify_small_;
            this.closePic.Location = new System.Drawing.Point(0, 26);
            this.closePic.Name = "closePic";
            this.closePic.Size = new System.Drawing.Size(25, 51);
            this.closePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.closePic.TabIndex = 3;
            this.closePic.TabStop = false;
            // 
            // routinProgress
            // 
            this.routinProgress.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.routinProgress.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.routinProgress.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.routinProgress.Location = new System.Drawing.Point(0, 67);
            this.routinProgress.Name = "routinProgress";
            this.routinProgress.Size = new System.Drawing.Size(1020, 10);
            this.routinProgress.TabIndex = 5;
            // 
            // WorkoutPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1057, 733);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "WorkoutPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "WorkoutPage";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tableLayoutPanel1.ResumeLayout(false);
            this.routinPanel.ResumeLayout(false);
            this.exerPanel.ResumeLayout(false);
            this.exerPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.exerPic)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.closePic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.VScrollBar vScrollBar1;
        private System.Windows.Forms.Panel routinPanel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button finishBtn;
        private System.Windows.Forms.Panel exerPanel;
        private System.Windows.Forms.Label routinNameLbl;
        private System.Windows.Forms.PictureBox exerPic;
        private System.Windows.Forms.Label exerciseNameLbl;
        private System.Windows.Forms.CheckBox setDoneCheck;
        private System.Windows.Forms.Label set_repLbl;
        private System.Windows.Forms.Label weight_lbl;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox closePic;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label timespanLbl;
        private System.Windows.Forms.ProgressBar routinProgress;
    }
}
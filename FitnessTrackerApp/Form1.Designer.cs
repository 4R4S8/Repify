namespace FitnessTrackerApp
{
    partial class Form1
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
            this.ExercisesBtn = new System.Windows.Forms.Button();
            this.RoutinesBtn = new System.Windows.Forms.Button();
            this.HomeBtn = new System.Windows.Forms.Button();
            this.navigatePanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.latestExcerizeNameLbl = new System.Windows.Forms.Label();
            this.exrTimeLbl = new System.Windows.Forms.Label();
            this.exrVolumeLbl = new System.Windows.Forms.Label();
            this.exrRecordLbl = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.navigatePanel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.mainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tableLayoutPanel1.Controls.Add(this.mainPanel, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.navigatePanel, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1289, 709);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // ExercisesBtn
            // 
            this.ExercisesBtn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ExercisesBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ExercisesBtn.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExercisesBtn.Location = new System.Drawing.Point(0, 556);
            this.ExercisesBtn.Name = "ExercisesBtn";
            this.ExercisesBtn.Size = new System.Drawing.Size(149, 112);
            this.ExercisesBtn.TabIndex = 0;
            this.ExercisesBtn.Text = "Exercises";
            this.ExercisesBtn.UseVisualStyleBackColor = false;
            // 
            // RoutinesBtn
            // 
            this.RoutinesBtn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.RoutinesBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.RoutinesBtn.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RoutinesBtn.Location = new System.Drawing.Point(0, 444);
            this.RoutinesBtn.Name = "RoutinesBtn";
            this.RoutinesBtn.Size = new System.Drawing.Size(149, 112);
            this.RoutinesBtn.TabIndex = 1;
            this.RoutinesBtn.Text = "Routines";
            this.RoutinesBtn.UseVisualStyleBackColor = false;
            // 
            // HomeBtn
            // 
            this.HomeBtn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.HomeBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.HomeBtn.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HomeBtn.Location = new System.Drawing.Point(0, 332);
            this.HomeBtn.Name = "HomeBtn";
            this.HomeBtn.Size = new System.Drawing.Size(149, 112);
            this.HomeBtn.TabIndex = 2;
            this.HomeBtn.Text = "Home";
            this.HomeBtn.UseVisualStyleBackColor = false;
            this.HomeBtn.Click += new System.EventHandler(this.HomeBtn_Click);
            // 
            // navigatePanel
            // 
            this.navigatePanel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.navigatePanel.Controls.Add(this.HomeBtn);
            this.navigatePanel.Controls.Add(this.RoutinesBtn);
            this.navigatePanel.Controls.Add(this.ExercisesBtn);
            this.navigatePanel.Controls.Add(this.pictureBox1);
            this.navigatePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.navigatePanel.Location = new System.Drawing.Point(3, 38);
            this.navigatePanel.Name = "navigatePanel";
            this.navigatePanel.Size = new System.Drawing.Size(149, 668);
            this.navigatePanel.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(298, 51);
            this.label1.TabIndex = 0;
            this.label1.Text = "Latest Exercise";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.exrRecordLbl);
            this.panel1.Controls.Add(this.exrVolumeLbl);
            this.panel1.Controls.Add(this.exrTimeLbl);
            this.panel1.Controls.Add(this.latestExcerizeNameLbl);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(39, 128);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1069, 518);
            this.panel1.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.Location = new System.Drawing.Point(314, 101);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(725, 387);
            this.dataGridView1.TabIndex = 0;
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.mainPanel.Controls.Add(this.panel1);
            this.mainPanel.Controls.Add(this.label1);
            this.mainPanel.Location = new System.Drawing.Point(158, 38);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(1131, 668);
            this.mainPanel.TabIndex = 1;
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
            // exrTimeLbl
            // 
            this.exrTimeLbl.AutoSize = true;
            this.exrTimeLbl.Font = new System.Drawing.Font("Microsoft Tai Le", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exrTimeLbl.Location = new System.Drawing.Point(61, 157);
            this.exrTimeLbl.Name = "exrTimeLbl";
            this.exrTimeLbl.Size = new System.Drawing.Size(161, 44);
            this.exrTimeLbl.TabIndex = 5;
            this.exrTimeLbl.Text = "[00:00:00]";
            // 
            // exrVolumeLbl
            // 
            this.exrVolumeLbl.AutoSize = true;
            this.exrVolumeLbl.Font = new System.Drawing.Font("Microsoft Tai Le", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exrVolumeLbl.Location = new System.Drawing.Point(61, 292);
            this.exrVolumeLbl.Name = "exrVolumeLbl";
            this.exrVolumeLbl.Size = new System.Drawing.Size(145, 44);
            this.exrVolumeLbl.TabIndex = 5;
            this.exrVolumeLbl.Text = "[000 KG]";
            // 
            // exrRecordLbl
            // 
            this.exrRecordLbl.AutoSize = true;
            this.exrRecordLbl.Font = new System.Drawing.Font("Microsoft Tai Le", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exrRecordLbl.Location = new System.Drawing.Point(61, 427);
            this.exrRecordLbl.Name = "exrRecordLbl";
            this.exrRecordLbl.Size = new System.Drawing.Size(137, 44);
            this.exrRecordLbl.TabIndex = 5;
            this.exrRecordLbl.Text = "[record]";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FitnessTrackerApp.Properties.Resources.new_text_logo_repify_small_;
            this.pictureBox1.Location = new System.Drawing.Point(-3, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(149, 125);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1289, 709);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.navigatePanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel navigatePanel;
        private System.Windows.Forms.Button HomeBtn;
        private System.Windows.Forms.Button RoutinesBtn;
        private System.Windows.Forms.Button ExercisesBtn;
        private System.Windows.Forms.Label exrRecordLbl;
        private System.Windows.Forms.Label exrVolumeLbl;
        private System.Windows.Forms.Label exrTimeLbl;
        private System.Windows.Forms.Label latestExcerizeNameLbl;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}


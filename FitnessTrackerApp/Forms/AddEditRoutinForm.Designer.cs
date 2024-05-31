namespace FitnessTrackerApp.Forms
{
    partial class AddEditRoutinForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.setNum = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.repNum = new System.Windows.Forms.NumericUpDown();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.weightNum = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.exerciseList = new System.Windows.Forms.ComboBox();
            this.newRoutinNametxt = new System.Windows.Forms.TextBox();
            this.submitBtn = new System.Windows.Forms.Button();
            this.routinNameLbl = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.AddExerciseBtn = new System.Windows.Forms.Button();
            this.routinExercisesRTxt = new System.Windows.Forms.RichTextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.setNum)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.repNum)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.weightNum)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.groupBox5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.newRoutinNametxt);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 18F);
            this.groupBox1.Location = new System.Drawing.Point(9, 38);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(537, 346);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.setNum);
            this.groupBox5.Location = new System.Drawing.Point(25, 223);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox5.Size = new System.Drawing.Size(112, 103);
            this.groupBox5.TabIndex = 13;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Set";
            // 
            // setNum
            // 
            this.setNum.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.setNum.Cursor = System.Windows.Forms.Cursors.Default;
            this.setNum.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.setNum.InterceptArrowKeys = false;
            this.setNum.Location = new System.Drawing.Point(25, 42);
            this.setNum.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.setNum.Name = "setNum";
            this.setNum.Size = new System.Drawing.Size(67, 47);
            this.setNum.TabIndex = 7;
            this.setNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 18F);
            this.label2.Location = new System.Drawing.Point(20, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 39);
            this.label2.TabIndex = 13;
            this.label2.Text = "Name ";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.repNum);
            this.groupBox4.Location = new System.Drawing.Point(187, 223);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox4.Size = new System.Drawing.Size(112, 108);
            this.groupBox4.TabIndex = 12;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Rep";
            // 
            // repNum
            // 
            this.repNum.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.repNum.Cursor = System.Windows.Forms.Cursors.Default;
            this.repNum.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.repNum.InterceptArrowKeys = false;
            this.repNum.Location = new System.Drawing.Point(23, 47);
            this.repNum.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.repNum.Name = "repNum";
            this.repNum.Size = new System.Drawing.Size(67, 47);
            this.repNum.TabIndex = 7;
            this.repNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.weightNum);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(348, 223);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Size = new System.Drawing.Size(164, 108);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Weight";
            // 
            // weightNum
            // 
            this.weightNum.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.weightNum.Cursor = System.Windows.Forms.Cursors.Default;
            this.weightNum.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weightNum.InterceptArrowKeys = false;
            this.weightNum.Location = new System.Drawing.Point(20, 46);
            this.weightNum.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.weightNum.Name = "weightNum";
            this.weightNum.Size = new System.Drawing.Size(67, 47);
            this.weightNum.TabIndex = 7;
            this.weightNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(95, 50);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 39);
            this.label1.TabIndex = 8;
            this.label1.Text = "KG";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.exerciseList);
            this.groupBox2.Location = new System.Drawing.Point(28, 107);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(484, 108);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Exercise";
            // 
            // exerciseList
            // 
            this.exerciseList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exerciseList.DropDownHeight = 150;
            this.exerciseList.DropDownWidth = 500;
            this.exerciseList.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exerciseList.FormattingEnabled = true;
            this.exerciseList.IntegralHeight = false;
            this.exerciseList.Location = new System.Drawing.Point(21, 46);
            this.exerciseList.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.exerciseList.Name = "exerciseList";
            this.exerciseList.Size = new System.Drawing.Size(433, 47);
            this.exerciseList.TabIndex = 6;
            this.exerciseList.Text = "select an exercise ...";
            // 
            // newRoutinNametxt
            // 
            this.newRoutinNametxt.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newRoutinNametxt.Location = new System.Drawing.Point(140, 42);
            this.newRoutinNametxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.newRoutinNametxt.Multiline = true;
            this.newRoutinNametxt.Name = "newRoutinNametxt";
            this.newRoutinNametxt.Size = new System.Drawing.Size(371, 47);
            this.newRoutinNametxt.TabIndex = 1;
            this.newRoutinNametxt.TextChanged += new System.EventHandler(this.newRoutinNametxt_TextChanged);
            // 
            // submitBtn
            // 
            this.submitBtn.BackColor = System.Drawing.Color.MediumAquamarine;
            this.submitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.submitBtn.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 18F);
            this.submitBtn.Location = new System.Drawing.Point(165, 726);
            this.submitBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.submitBtn.Name = "submitBtn";
            this.submitBtn.Size = new System.Drawing.Size(228, 68);
            this.submitBtn.TabIndex = 0;
            this.submitBtn.Text = "Submit";
            this.submitBtn.UseVisualStyleBackColor = false;
            this.submitBtn.Click += new System.EventHandler(this.submitBtn_Click);
            // 
            // routinNameLbl
            // 
            this.routinNameLbl.AutoSize = true;
            this.routinNameLbl.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 18F);
            this.routinNameLbl.Location = new System.Drawing.Point(15, 11);
            this.routinNameLbl.Name = "routinNameLbl";
            this.routinNameLbl.Size = new System.Drawing.Size(174, 39);
            this.routinNameLbl.TabIndex = 1;
            this.routinNameLbl.Text = "New Routin";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 18F);
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(803, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 39);
            this.label5.TabIndex = 8;
            this.label5.Text = "X";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // AddExerciseBtn
            // 
            this.AddExerciseBtn.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 18F);
            this.AddExerciseBtn.Location = new System.Drawing.Point(196, 402);
            this.AddExerciseBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AddExerciseBtn.Name = "AddExerciseBtn";
            this.AddExerciseBtn.Size = new System.Drawing.Size(167, 60);
            this.AddExerciseBtn.TabIndex = 9;
            this.AddExerciseBtn.Text = "↓";
            this.AddExerciseBtn.UseVisualStyleBackColor = true;
            this.AddExerciseBtn.Click += new System.EventHandler(this.AddExerciseBtn_Click);
            // 
            // routinExercisesRTxt
            // 
            this.routinExercisesRTxt.Location = new System.Drawing.Point(37, 482);
            this.routinExercisesRTxt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.routinExercisesRTxt.Name = "routinExercisesRTxt";
            this.routinExercisesRTxt.ReadOnly = true;
            this.routinExercisesRTxt.Size = new System.Drawing.Size(483, 216);
            this.routinExercisesRTxt.TabIndex = 10;
            this.routinExercisesRTxt.Text = "";
            // 
            // AddEditRoutinForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(561, 807);
            this.Controls.Add(this.routinExercisesRTxt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.routinNameLbl);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.AddExerciseBtn);
            this.Controls.Add(this.submitBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddEditRoutinForm";
            this.Opacity = 0.95D;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AddEditRoutinForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.setNum)).EndInit();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.repNum)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.weightNum)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox newRoutinNametxt;
        private System.Windows.Forms.Button submitBtn;
        private System.Windows.Forms.Label routinNameLbl;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.ComboBox exerciseList;
        private System.Windows.Forms.NumericUpDown repNum;
        private System.Windows.Forms.NumericUpDown weightNum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AddExerciseBtn;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox routinExercisesRTxt;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.NumericUpDown setNum;
    }
}
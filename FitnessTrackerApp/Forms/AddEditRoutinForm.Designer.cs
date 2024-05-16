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
            this.submitBtn = new System.Windows.Forms.Button();
            this.newRoutinNametxt = new System.Windows.Forms.TextBox();
            this.routinNameLbl = new System.Windows.Forms.Label();
            this.exerList = new System.Windows.Forms.ListBox();
            this.newRoutinList = new System.Windows.Forms.ListBox();
            this.addToListBtn = new System.Windows.Forms.Button();
            this.removeFromListBtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.removeFromListBtn);
            this.groupBox1.Controls.Add(this.addToListBtn);
            this.groupBox1.Controls.Add(this.newRoutinList);
            this.groupBox1.Controls.Add(this.exerList);
            this.groupBox1.Controls.Add(this.newRoutinNametxt);
            this.groupBox1.Controls.Add(this.submitBtn);
            this.groupBox1.Location = new System.Drawing.Point(12, 56);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(623, 461);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // submitBtn
            // 
            this.submitBtn.Location = new System.Drawing.Point(17, 51);
            this.submitBtn.Name = "submitBtn";
            this.submitBtn.Size = new System.Drawing.Size(155, 53);
            this.submitBtn.TabIndex = 0;
            this.submitBtn.Text = "Submit";
            this.submitBtn.UseVisualStyleBackColor = true;
            // 
            // newRoutinNametxt
            // 
            this.newRoutinNametxt.Location = new System.Drawing.Point(258, 50);
            this.newRoutinNametxt.Multiline = true;
            this.newRoutinNametxt.Name = "newRoutinNametxt";
            this.newRoutinNametxt.Size = new System.Drawing.Size(352, 54);
            this.newRoutinNametxt.TabIndex = 1;
            // 
            // routinNameLbl
            // 
            this.routinNameLbl.AutoSize = true;
            this.routinNameLbl.Location = new System.Drawing.Point(26, 26);
            this.routinNameLbl.Name = "routinNameLbl";
            this.routinNameLbl.Size = new System.Drawing.Size(75, 16);
            this.routinNameLbl.TabIndex = 1;
            this.routinNameLbl.Text = "New Routin";
            // 
            // exerList
            // 
            this.exerList.FormattingEnabled = true;
            this.exerList.ItemHeight = 16;
            this.exerList.Location = new System.Drawing.Point(363, 146);
            this.exerList.Name = "exerList";
            this.exerList.Size = new System.Drawing.Size(247, 292);
            this.exerList.TabIndex = 2;
            // 
            // newRoutinList
            // 
            this.newRoutinList.FormattingEnabled = true;
            this.newRoutinList.ItemHeight = 16;
            this.newRoutinList.Location = new System.Drawing.Point(14, 146);
            this.newRoutinList.Name = "newRoutinList";
            this.newRoutinList.Size = new System.Drawing.Size(247, 292);
            this.newRoutinList.TabIndex = 3;
            // 
            // addToListBtn
            // 
            this.addToListBtn.Location = new System.Drawing.Point(270, 222);
            this.addToListBtn.Name = "addToListBtn";
            this.addToListBtn.Size = new System.Drawing.Size(75, 35);
            this.addToListBtn.TabIndex = 4;
            this.addToListBtn.Text = "<=";
            this.addToListBtn.UseVisualStyleBackColor = true;
            // 
            // removeFromListBtn
            // 
            this.removeFromListBtn.Location = new System.Drawing.Point(270, 323);
            this.removeFromListBtn.Name = "removeFromListBtn";
            this.removeFromListBtn.Size = new System.Drawing.Size(75, 35);
            this.removeFromListBtn.TabIndex = 5;
            this.removeFromListBtn.Text = "=>";
            this.removeFromListBtn.UseVisualStyleBackColor = true;
            // 
            // AddEditRoutinForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 529);
            this.Controls.Add(this.routinNameLbl);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddEditRoutinForm";
            this.Text = "AddEditRoutinForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox newRoutinNametxt;
        private System.Windows.Forms.Button submitBtn;
        private System.Windows.Forms.Label routinNameLbl;
        private System.Windows.Forms.ListBox newRoutinList;
        private System.Windows.Forms.ListBox exerList;
        private System.Windows.Forms.Button removeFromListBtn;
        private System.Windows.Forms.Button addToListBtn;
    }
}
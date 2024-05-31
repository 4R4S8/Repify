namespace FitnessTrackerApp.Classes
{
    internal class SetRepLabel : System.Windows.Forms.Label
    {
        public SetRepLabel()
        {
            AutoSize = true;
            Font = new System.Drawing.Font("Microsoft YaHei UI Light", 15F);
            ForeColor = System.Drawing.Color.SaddleBrown;
            Location = new System.Drawing.Point(439, 21);
            Name = "set_repLbl";
            Size = new System.Drawing.Size(125, 32);
            BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        }
    }
}

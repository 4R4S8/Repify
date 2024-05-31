using System.Drawing;

namespace FitnessTrackerApp.Classes
{
    internal class WeightLabel : System.Windows.Forms.Label
    {
        public WeightLabel()
        {
            AutoSize = true;
            Font = new Font("Microsoft YaHei UI Light", 15F);
            ForeColor = Color.SaddleBrown;
            Location = new Point(229, 21);
            Name = "weight_lbl";
            Size = new Size(144, 32);
            BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        }
    }
}

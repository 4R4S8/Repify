using System.Windows.Forms;

namespace FitnessTrackerApp.Classes
{
    internal class ExerciseNameLabel : System.Windows.Forms.Label
    {
        public ExerciseNameLabel()
        {
            AutoEllipsis = true;
            BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            Font = new System.Drawing.Font("Microsoft YaHei UI Light", 14F);
            ForeColor = System.Drawing.Color.SaddleBrown;
            Location = new System.Drawing.Point(615, 4);
            Name = "exerciseNameLbl";
            Size = new System.Drawing.Size(305, 69);
            TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            Anchor = AnchorStyles.Right;
        }
    }
}

using System.Windows.Forms;

namespace FitnessTrackerApp.Classes
{
    internal class ExercisePictureBox : PictureBox
    {
        public ExercisePictureBox()
        {
            Location = new System.Drawing.Point(945, 4);
            Size = new System.Drawing.Size(70, 70);
            SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            TabIndex = 6;
            TabStop = false;
            Image = FitnessTrackerApp.Properties.Resources._bca137eb_e219_45e7_bc95_7646f86bbcd7;
        }
    }
}

using System.Windows.Forms;

namespace FitnessTrackerApp.Classes
{
    internal class ExerciseIsDoneCheckBox : CheckBox
    {
        public ExerciseIsDoneCheckBox()
        {
            AutoSize = true;
            Font = new System.Drawing.Font("Microsoft YaHei UI Light", 15F);
            Location = new System.Drawing.Point(27, 15);
            Size = new System.Drawing.Size(97, 36);
            Text = "Done";
            UseVisualStyleBackColor = true;

        }
    }
}

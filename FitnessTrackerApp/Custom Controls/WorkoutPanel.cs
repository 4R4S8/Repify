using System.Windows.Forms;

namespace FitnessTrackerApp.Classes
{
    internal class WorkoutPanel : Panel
    {
        public WorkoutPanel()
        {
            BackColor = System.Drawing.SystemColors.ActiveCaption;
            Dock = System.Windows.Forms.DockStyle.Top;
            Size = new System.Drawing.Size(1020, 77);
            BorderStyle = BorderStyle.FixedSingle;
        }
    }
}

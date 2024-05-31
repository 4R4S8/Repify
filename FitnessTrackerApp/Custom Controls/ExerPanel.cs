using System.Drawing;
using System.Windows.Forms;

namespace FitnessTrackerApp.Classes
{
    internal class ExerPanel : Panel
    {
        public ExerPanel()
        {
            this.Size = new Size(930, 155);
            this.Location = new Point(0, 155);
            this.BackColor = Color.Beige;
            this.BorderStyle = BorderStyle.FixedSingle;
            this.Dock = DockStyle.Top;
        }
    }
}

using System.Drawing;
using System.Windows.Forms;

namespace FitnessTrackerApp.Classes
{
    internal class RoutinDGV : DataGridView
    {
        public RoutinDGV()
        {
            AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            BackgroundColor = SystemColors.ButtonHighlight;
            ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            EditMode = DataGridViewEditMode.EditProgrammatically;
            GridColor = SystemColors.ActiveCaption;
            Location = new Point(320, 20);
            Margin = new Padding(2);
            MultiSelect = false;
            ReadOnly = true;
            RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            RowHeadersWidth = 51;
            RowTemplate.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            RowTemplate.Height = 24;
            Size = new Size(395, 119);
            AllowUserToAddRows = false;
        }
    }
}

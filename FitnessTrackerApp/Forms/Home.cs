using FitnessTrackerApp.Classes;
using System.Windows.Forms;

namespace FitnessTrackerApp
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
            ConnectionManager _connectionManager = new ConnectionManager();
            _connectionManager.CreateDataBase();
        }
    }
}

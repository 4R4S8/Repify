using FitnessTrackerApp.Classes;
using FitnessTrackerApp.Forms;
using System;
using System.Windows.Forms;

namespace FitnessTrackerApp
{
    public partial class Home : Form
    {
        ConnectionManager _connectionManager = new ConnectionManager();
        public Home()
        {
            InitializeComponent();
            SplashScreen splashScreen = new SplashScreen();
            splashScreen.ShowDialog();
            _connectionManager.CreateDataBase();

        }



        private void addRoutinBtn_Click(object sender, System.EventArgs e)
        {

            AddEditRoutinForm addEditRoutinForm = new AddEditRoutinForm();
            _connectionManager.PopulateListBoxFromSqlite(addEditRoutinForm.exerciseList);
            addEditRoutinForm.ShowDialog();
        }

        private void label5_Click(object sender, System.EventArgs e)
        {
            this.Dispose();
        }

        private void Home_Load(object sender, System.EventArgs e)
        {
            string toDay;
            toDay = DateTime.Now.ToString("yyyy/MM/dd");
            DateLbl.Text = toDay;
        }

        private void Tabs_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            string selectedTabText = null;
            if (Tabs.SelectedTab != null)
            {
                selectedTabText = Tabs.SelectedTab.Text;
            }
            if (selectedTabText != null)
            {
                switch (selectedTabText)
                {
                    case "Exercises":
                        {
                            _connectionManager.PopulateExerciseDGV(exercisesDGV);
                        }
                        break;

                    case "Home":
                        {

                        }
                        break;

                    case "Routins":
                        {
                            _connectionManager.PopulateRoutins(routinPanel);
                        }
                        break;

                    case "Records":
                        {

                        }
                        break;
                }
            }
        }
    }
}

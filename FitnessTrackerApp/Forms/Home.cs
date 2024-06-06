using FitnessTrackerApp.Classes;
using FitnessTrackerApp.Forms;
using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace FitnessTrackerApp
{
    public partial class Home : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
     (
         int nLeftRect,     // x-coordinate of upper-left corner
         int nTopRect,      // y-coordinate of upper-left corner
         int nRightRect,    // x-coordinate of lower-right corner
         int nBottomRect,   // y-coordinate of lower-right corner
         int nWidthEllipse, // width of ellipse
         int nHeightEllipse // height of ellipse
     );
        ConnectionManager _connectionManager = new ConnectionManager();
        public Home()
        {

            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
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
                            _connectionManager.PopulateHomePage();
                        }
                        break;

                    case "Routins":
                        {
                            _connectionManager.PopulateRoutins(routinPanel);
                        }
                        break;

                    case "Records":
                        {
                            _connectionManager.PopulateRecords(recordDetailsDGV);
                        }
                        break;
                }
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label5_Click_1(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            switch (this.WindowState)
            {
                case FormWindowState.Normal:
                    this.WindowState = FormWindowState.Maximized;
                    Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
                    break;
                case FormWindowState.Maximized:
                    Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 0, 0));
                    this.WindowState = FormWindowState.Normal;
                    break;
                default:
                    break;
            }
        }
    }
}

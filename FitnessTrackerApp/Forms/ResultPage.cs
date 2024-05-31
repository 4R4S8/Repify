using FitnessTrackerApp.Classes;
using System;
using System.Windows.Forms;

namespace FitnessTrackerApp.Forms
{
    public partial class ResultPage : Form
    {
        public ResultPage()
        {
            InitializeComponent();
        }
        ConnectionManager _connectionManager = new ConnectionManager();
        public static int TotalWeight { get; set; }
        public static int TotalSet { get; set; }
        public static string ElapsedTime { get; set; }
        public static string Date { get; set; }
        public static string RoutinName { get; set; }


        private void ResultPage_Closing(object sender, EventArgs e)
        {
            WorkoutPage.timer.Start();
            this.Dispose();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (_connectionManager.AddRecord(RoutinName, ElapsedTime, Date, TotalWeight, TotalSet))
            {
                MessageBox.Show("Record Saved Succesfully");
                this.Dispose();
                _connectionManager.workoutPage.Dispose();
            }
        }
    }
}

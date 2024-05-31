using FitnessTrackerApp.Classes;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace FitnessTrackerApp.Forms
{
    public partial class WorkoutPage : Form
    {
        private Timer timer;
        private int elapsedSeconds = 0;
        internal static int workoutsCount = 0;
        ConnectionManager _connectionManager = new ConnectionManager();
        public WorkoutPage(string _routinName, List<string[]> _workoutDatas)
        {
            workoutsCount = _workoutDatas.Count;
            InitializeComponent();
            routinNameLbl.Text = _routinName;
            routinProgress.Minimum = 0;
            routinProgress.Maximum = workoutsCount;
            _connectionManager.PopulateWorkouts(routinPanel, _workoutDatas, routinProgress);


            timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += OnTimerTick;

            timer.Start();
        }
        private void OnTimerTick(object sender, EventArgs e)
        {
            elapsedSeconds++;

            timespanLbl.Text = TimeSpan.FromSeconds(elapsedSeconds).ToString(@"hh\:mm\:ss");
        }
        private void label5_Click_1(object sender, EventArgs e)
        {
            this.Dispose();

        }

        private void finishBtn_Click(object sender, EventArgs e)
        {

        }

        private void setDoneCheck_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}

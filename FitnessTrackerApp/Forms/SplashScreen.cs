using System;
using System.Windows.Forms;

namespace FitnessTrackerApp
{
    public partial class SplashScreen : Form
    {
        private Timer timer;

        public SplashScreen()
        {
            InitializeComponent();
            InitializeTimer();
        }
        private void InitializeTimer()
        {
            timer = new Timer();
            timer.Interval = 3000;
            timer.Tick += Timer_Tick;
            timer.Start();
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            timer.Stop();
            //this.Dispose();

            var HomeForm = new Home();
            HomeForm.Show();

        }
    }
}

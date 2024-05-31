using FitnessTrackerApp.Classes;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace FitnessTrackerApp.Forms
{
    public partial class WorkoutPage : Form
    {
        public static Timer timer;
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
            ResultPage result = new ResultPage();
            List<Control> doneExercises = new List<Control>();
            for (int i = 0; i < routinPanel.Controls.Count; i++)
            {
                CheckBox dsa = (CheckBox)routinPanel.Controls[i].Controls[1];
                if (dsa.Checked == true)
                {
                    doneExercises.Add(routinPanel.Controls[i]);
                }
            }
            if (doneExercises.Count > 0)
            {
                timer.Stop();
                CreateControls(doneExercises, result.doneExercisesPanel);
                result.routinNameLbl.Text = routinNameLbl.Text;
                result.timespanLbl.Text = timespanLbl.Text;
                result.ShowDialog();
            }
        }
        private void CreateControls(List<Control> controls, Panel resultPanel)
        {
            ResultPage.TotalWeight = 0;
            ResultPage.TotalSet = 0;
            ResultPage.ElapsedTime = null;
            ResultPage.Date = null;
            ResultPage.RoutinName = null;
            for (int i = 0; i < controls.Count; i++)
            {
                WorkoutPanel exerPanel = new WorkoutPanel();
                ExerciseNameLabel exerciseNameLabel = new ExerciseNameLabel();
                SetRepLabel setRepLabel = new SetRepLabel();
                WeightLabel weightLabel = new WeightLabel();

                for (int j = 0; j < controls[i].Controls.Count; j++)
                {
                    if (!(controls[i].Controls[j] is CheckBox) || !(controls[i].Controls[j] is PictureBox))
                    {
                        Type controlType = controls[i].Controls[j].GetType();
                        switch (controlType.Name)
                        {
                            case "WeightLabel":
                                {
                                    string weightLabelText = controls[i].Controls[j].Text;
                                    weightLabel.Text = weightLabelText;
                                    int weight = int.Parse(weightLabelText.Replace("KG", ""));
                                    ResultPage.TotalWeight += weight;
                                }
                                break;

                            case "SetRepLabel":
                                {
                                    string[] SetRep = controls[i].Controls[j].Text.Split('×');
                                    int set = int.Parse(SetRep[0]);
                                    setRepLabel.Text = controls[i].Controls[j].Text;
                                    ResultPage.TotalSet += set;
                                }
                                break;

                            case "ExerciseNameLabel":
                                {
                                    exerciseNameLabel.Text = controls[i].Controls[j].Text;
                                }
                                break;
                        }
                    }
                }
                exerPanel.Controls.Add(exerciseNameLabel);
                exerPanel.Controls.Add(setRepLabel);
                exerPanel.Controls.Add(weightLabel);
                ResultPage.RoutinName = routinNameLbl.Text;
                ResultPage.ElapsedTime = timespanLbl.Text;
                ResultPage.Date = DateTime.Now.ToString("yyyy/MM/dd");
                resultPanel.Controls.Add(exerPanel);
            }
        }
        private void setDoneCheck_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void WorkoutPage_Load(object sender, EventArgs e)
        {

        }
        private void WorkoutPage_Closing(object sender, FormClosingEventArgs e)
        {
            ResultPage result = new ResultPage();
            List<Control> doneExercises = new List<Control>();
            for (int i = 0; i < routinPanel.Controls.Count; i++)
            {
                CheckBox dsa = (CheckBox)routinPanel.Controls[i].Controls[1];
                if (dsa.Checked == true)
                {
                    doneExercises.Add(routinPanel.Controls[i]);
                }
            }
            if (doneExercises.Count > 0)
            {

                DialogResult dr = MessageBox.Show("You have unsaved exercise progress. Would you like to save before exiting?", "Unsaved Progress", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                if (dr == DialogResult.Yes)
                {

                    if (doneExercises.Count > 0)
                    {
                        timer.Stop();
                        CreateControls(doneExercises, result.doneExercisesPanel);
                        result.routinNameLbl.Text = routinNameLbl.Text;
                        result.timespanLbl.Text = timespanLbl.Text;
                        result.ShowDialog();
                    }
                    e.Cancel = true;
                }
                else if (dr == DialogResult.No)
                {
                    this.Dispose();
                }
                else
                {
                    e.Cancel = true;
                }
            }
        }
    }
}

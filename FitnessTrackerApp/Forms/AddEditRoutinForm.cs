using FitnessTrackerApp.Classes;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace FitnessTrackerApp.Forms
{
    public partial class AddEditRoutinForm : Form
    {
        readonly ConnectionManager _connectionManager = new ConnectionManager();
        private List<string[]> routinExercises = new List<string[]>();
        public AddEditRoutinForm()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void newRoutinNametxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddExerciseBtn_Click(object sender, EventArgs e)
        {
            var _weight = weightNum.Value;
            var _rep = repNum.Value;
            var _set = setNum.Value;
            var _exerciseName = exerciseList.Text;

            if (_weight != 0 && _rep != 0 && _set != 0 && _exerciseName != "select an exercise ..." && _exerciseName != "")
            {
                routinExercisesRTxt.Text += $"{_exerciseName} \t\t {_weight}KG {_set} × {_rep}\n";
                exerciseList.Items.Remove(_exerciseName);
                routinExercises.Add(new string[] { _exerciseName, _weight.ToString(), _set.ToString(), _rep.ToString() });
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            string routinName = newRoutinNametxt.Text.Trim();
            if (routinName != "" && routinExercises.Count > 0)
            {
                if (_connectionManager.AddNewRoutin(routinExercises, routinName))
                {
                    #region msg
                    StringBuilder @msg = new StringBuilder();
                    @msg.Append($"'{routinName}' added succesfuly");
                    @msg.AppendLine();
                    @msg.Append($"{routinExercisesRTxt.Text}");
                    #endregion
                    MessageBox.Show(@msg.ToString(), "Repify", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    #region clear boxes
                    routinExercisesRTxt.ResetText();
                    weightNum.ResetText();
                    repNum.ResetText();
                    setNum.ResetText();
                    exerciseList.ResetText();
                    newRoutinNametxt.ResetText();
                    _connectionManager.PopulateListBoxFromSqlite(this.exerciseList);
                    #endregion
                }
            }
        }
    }
}

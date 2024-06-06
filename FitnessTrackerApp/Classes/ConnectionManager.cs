using FitnessTrackerApp.Forms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
namespace FitnessTrackerApp.Classes
{
    internal class ConnectionManager
    {
        public static WorkoutPage workoutPage;
        public static Home HomePage;
        private readonly string _SQLiteDBPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "Repify", "Repify.sqlite");
        private readonly string _SQLiteConncectionString = $"Data Source={Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "Repify", "Repify.sqlite")};Version=3;";
        public string SQLiteDBPath
        {
            get { return _SQLiteDBPath; }
        }
        public string SQLiteConncectionString
        {
            get { return _SQLiteConncectionString; }
        }
        internal void CreateDataBase()
        {
            if (!File.Exists(_SQLiteDBPath))
            {
                string SQLiteDirPath = Path.GetDirectoryName(_SQLiteDBPath);
                if (!Directory.Exists(SQLiteDirPath))
                {
                    Directory.CreateDirectory(SQLiteDirPath);
                }
                SQLiteConnection.CreateFile(_SQLiteDBPath);
            }
            FileInfo _sqlFile = new FileInfo(_SQLiteDBPath);

            if (File.Exists(_SQLiteDBPath))
            {
                using (var conn = new SQLiteConnection(_SQLiteConncectionString))
                {
                    conn.Open();

                    using (var cmd = new SQLiteCommand(conn))
                    {
                        //Create a table named Exercise
                        cmd.CommandText = "CREATE TABLE IF NOT EXISTS Exercise (exercise_guid TEXT, Name TEXT, muscle_group TEXT)";
                        cmd.ExecuteNonQuery();

                        //Create a table named Routine

                        cmd.CommandText = "CREATE TABLE IF NOT EXISTS Routine (routine_guid TEXT, Name TEXT, workout_list_guid TEXT)";
                        cmd.ExecuteNonQuery();

                        //Create a table named workout_list

                        cmd.CommandText = "CREATE TABLE IF NOT EXISTS workout_list (workout_list_guid TEXT, exercise_guid TEXT,weight INTEGER,sets INTEGER, rep INTEGER )";
                        cmd.ExecuteNonQuery();

                        ////Create a table named Records
                        //cmd.CommandText = "CREATE TABLE records (records_guid TEXT, routine_guid TEXT, total_rep INTEGER, total_weight INTEGER)";
                        //cmd.ExecuteNonQuery();

                        //Create a table named Routin Record
                        cmd.CommandText = "CREATE TABLE IF NOT EXISTS routin_record (ID INTEGER PRIMARY KEY AUTOINCREMENT, routin_record_guid TEXT ,routine_name TEXT,total_set INTEGER, total_weight INTEGER, time_span TEXT, date TEXT)";
                        cmd.ExecuteNonQuery();

                    }
                    InsertIntoExerciseTable(_SQLiteConncectionString);
                }
            }

        }
        internal void InsertIntoExerciseTable(string SQLiteConncectionString)
        {

            List<string> exerciseNameFile = new List<string>();
            List<string> muscleGroupFile = new List<string>();

            // Assuming "exercise_Name" and "muscle_group" are valid resource names
            exerciseNameFile.AddRange(FitnessTrackerApp.Properties.Resources.exercise_Name.Split('\n'));
            muscleGroupFile.AddRange(FitnessTrackerApp.Properties.Resources.muscle_group.Split('\n'));

            using (var connection = new SQLiteConnection(SQLiteConncectionString))
            {
                connection.Open();

                string sql = "INSERT INTO exercise  VALUES (@id, @valueA, @valueB)";
                using (var command = new SQLiteCommand(sql, connection))
                {

                    if (exerciseNameFile.Count() == muscleGroupFile.Count())
                    {
                        var listCount = exerciseNameFile.Count();
                        for (int i = 0; i < listCount; i++)
                        {
                            Guid newGuid = Guid.NewGuid();
                            command.Parameters.AddWithValue("@id", newGuid.ToString());
                            command.Parameters.AddWithValue("@valueA", exerciseNameFile[i]);
                            command.Parameters.AddWithValue("@valueB", muscleGroupFile[i]);
                            command.ExecuteNonQuery();
                        }
                    }
                }
            }

        }
        private LatestRecord GetTheLatestRecord()
        {
            var query = "SELECT *\r\nFROM routin_record\r\nORDER BY id DESC\r\nLIMIT 1;";
            LatestRecord latestRecord = new LatestRecord();
            using (var connection = new SQLiteConnection(SQLiteConncectionString))
            {
                connection.Open();
                using (var command = new SQLiteCommand(connection))
                {
                    command.Connection = connection;

                    command.CommandText = query;

                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            var _routineName = "";
                            var _totalSet = 0;
                            var _totalWeight = 0;
                            var _time = "";
                            if (reader.Read())
                            {
                                _routineName = reader.GetString(2);
                                _totalSet = reader.GetInt32(3);
                                _totalWeight = reader.GetInt32(4);
                                _time = reader.GetString(5);
                            }
                            latestRecord.Time = _time;
                            latestRecord.RoutinName = _routineName;
                            latestRecord.TotalWeight = $"{_totalWeight} KG";
                            latestRecord.TotalSet = _totalSet;
                        }
                        else
                        {
                            return null;
                        }
                    }
                }
            }
            return latestRecord;

        }
        internal void PopulateHomePage()
        {
            LatestRecord latestRecord = new LatestRecord();
            latestRecord = GetTheLatestRecord();
            if (latestRecord != null)
            {
                HomePage.latestExcerizeNameLbl.Text = latestRecord.RoutinName;
                HomePage.exrTotalSetLbl.Text = latestRecord.TotalSet.ToString();
                HomePage.exrTimeLbl.Text = latestRecord.Time;
                HomePage.exrVolumeLbl.Text = latestRecord.TotalWeight;
            }
            else
            {
                HomePage.latestExcerizeNameLbl.Text = "There is no new Exercise";
                HomePage.exrTotalSetLbl.Text = "0";
                HomePage.exrTimeLbl.Text = "00:00:00";
                HomePage.exrVolumeLbl.Text = "0KG";
            }
        }
        internal void PopulateListBoxFromSqlite(ComboBox cmboBox)
        {
            cmboBox.Items.Clear();
            string query = "SELECT Name FROM Exercise";
            using (var connection = new SQLiteConnection(SQLiteConncectionString))
            {
                connection.Open();

                using (var command = new SQLiteCommand(query, connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            // Assuming you want to display the first column
                            string itemToAdd = reader.GetString(0);
                            cmboBox.Items.Add(itemToAdd);
                        }
                    }
                }
            }
        }
        internal void PopulateExerciseDGV(DataGridView _exerDGV)
        {
            using (var connection = new SQLiteConnection(SQLiteConncectionString))
            {
                connection.Open();

                var dataTable = new DataTable();
                var dataAdapter = new SQLiteDataAdapter("SELECT Name as \"Exercise Name\" ,muscle_group as \"Muscle Group\"  FROM Exercise", connection);
                dataAdapter.Fill(dataTable);

                _exerDGV.DataSource = dataTable;
            }
        }
        internal void PopulateRoutins(Panel routinPanel)
        {
            routinPanel.Controls.Clear();
            // get routin counts
            string query = "SELECT Name,workout_list_guid FROM Routine";
            using (var connection = new SQLiteConnection(SQLiteConncectionString))
            {
                connection.Open();

                using (var command = new SQLiteCommand(query, connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string routineName = reader.GetString(0);
                            string exerciseGUID = reader.GetString(1);
                            #region Panel routin
                            ExerPanel routin = new ExerPanel();
                            routin.Name = routineName;
                            #endregion
                            AddControlsToRoutinPanel(routin, routineName, exerciseGUID);
                            routinPanel.Controls.Add(routin);
                        }
                    }
                }
            }
        }
        internal void PopulateWorkouts(Panel workoutPanel, List<string[]> workoutList, ProgressBar routonProgress)
        {
            workoutPanel.Controls.Clear();
            for (int i = 0; i < workoutList.Count; i++)
            {
                string _exerName = workoutList[i][0].ToString();
                string _weight = workoutList[i][1].ToString();
                string _set = workoutList[i][2].ToString();
                string _rep = workoutList[i][3].ToString();
                #region WorkoutPanel exerPanel
                WorkoutPanel exerPanel = new WorkoutPanel();
                exerPanel.Name = $"{_exerName}Panel";
                #endregion
                AddControlsToExercisePanel(exerPanel, _exerName, _weight, _set, _rep, routonProgress);
                workoutPanel.Controls.Add(exerPanel);

            }
        }
        internal void PopulateRecords(DataGridView _recordDGV)
        {
            string query = "SELECT routine_name as \"Routin Name\",total_set AS \"Total Set\",total_weight AS \"Total Weight\",time_span AS \"Time Span\",date AS Date FROM routin_record";
            using (var connection = new SQLiteConnection(SQLiteConncectionString))
            {
                connection.Open();

                var dataTable = new DataTable();
                var dataAdapter = new SQLiteDataAdapter(query, connection);
                dataAdapter.Fill(dataTable);

                _recordDGV.DataSource = dataTable;
            }
        }
        private void AddControlsToExercisePanel(Panel _exerPanel, string _exerName, string _weight, string _set, string _rep, ProgressBar _routonProgress)
        {
            #region weight_lbl
            WeightLabel weight_lbl = new WeightLabel();
            weight_lbl.Text = $"{_weight} KG";
            #endregion
            #region set_repLbl
            SetRepLabel set_repLbl = new SetRepLabel();
            set_repLbl.Text = $"{_set} × {_rep}";
            #endregion
            #region exerciseNameLbl
            ExerciseNameLabel exerciseNameLbl = new ExerciseNameLabel();
            exerciseNameLbl.Text = _exerName;

            #endregion
            #region exerciseIsDoneCheck
            ExerciseIsDoneCheckBox exerciseIsDoneCheck = new ExerciseIsDoneCheckBox();
            exerciseIsDoneCheck.Name = $"{_exerName}IsDoneCheck";
            exerciseIsDoneCheck.CheckedChanged += setDoneCheck_CheckedChanged;
            #region Events
            void setDoneCheck_CheckedChanged(object sender, EventArgs e)
            {
                if (exerciseIsDoneCheck.Checked == true)
                {
                    _exerPanel.BackColor = Color.LightGreen;
                    _routonProgress.Value++;
                }
                else
                {
                    _exerPanel.BackColor = SystemColors.ActiveCaption;
                    _routonProgress.Value--;
                }
            }
            #endregion
            #endregion
            #region exerPic
            ExercisePictureBox exerPic = new ExercisePictureBox();
            exerPic.Name = $"{_exerName}Pic";
            #endregion
            _exerPanel.Controls.Add(weight_lbl);
            _exerPanel.Controls.Add(exerciseIsDoneCheck);
            _exerPanel.Controls.Add(exerPic);
            _exerPanel.Controls.Add(set_repLbl);
            _exerPanel.Controls.Add(exerciseNameLbl);
        }
        private void AddControlsToRoutinPanel(Panel routinPanel, string _routinName, string _exerciseGUID)
        {
            #region DataGridView routinDGV
            RoutinDGV routinDGV = new RoutinDGV();
            routinDGV.Name = $"{_routinName}DGV";
            #endregion
            using (var connection = new SQLiteConnection(SQLiteConncectionString))
            {
                connection.Open();

                var dataTable = new DataTable();
                var dataAdapter = new SQLiteDataAdapter($"SELECT exercise_guid as \"Name\" ,weight as \"Weight\",sets as \"Set\", rep as \"Rep\" FROM workout_list WHERE workout_list_guid = '{_exerciseGUID}'", connection);
                dataAdapter.Fill(dataTable);

                routinDGV.DataSource = dataTable;
            }
            #region Label RoutinNameLbl

            Label RoutinNameLbl = new Label();
            RoutinNameLbl.AutoSize = true;
            RoutinNameLbl.Font = new Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            RoutinNameLbl.Location = new Point(17, 20);
            RoutinNameLbl.Margin = new Padding(2, 0, 2, 0);
            RoutinNameLbl.Name = $"{_routinName}Lbl";
            RoutinNameLbl.Size = new Size(104, 20);
            RoutinNameLbl.Text = _routinName;
            #endregion
            #region Button startRoutBtn
            Button startRoutBtn = new Button();
            startRoutBtn.BackColor = SystemColors.ButtonHighlight;
            startRoutBtn.Font = new Font("Microsoft Tai Le", 9F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            startRoutBtn.Location = new Point(789, 54);
            startRoutBtn.Margin = new Padding(2);
            startRoutBtn.Name = $"start{_routinName}Btn";
            startRoutBtn.Size = new Size(127, 52);
            startRoutBtn.Text = "Start Routin";
            startRoutBtn.UseVisualStyleBackColor = false;
            startRoutBtn.Click += new EventHandler(startRoutBtn_Click);
            void startRoutBtn_Click(object sender, EventArgs e)
            {
                List<string[]> workoutDatas = new List<string[]>();
                for (int i = 0; i < routinDGV.RowCount; i++)
                {
                    string _exerName = routinDGV.Rows[i].Cells[0].Value.ToString();
                    string _weight = routinDGV.Rows[i].Cells[1].Value.ToString();
                    string _set = routinDGV.Rows[i].Cells[2].Value.ToString();
                    string _rep = routinDGV.Rows[i].Cells[3].Value.ToString();
                    workoutDatas.Add(new string[] { _exerName, _weight, _set, _rep });
                }
                workoutPage = new WorkoutPage(_routinName, workoutDatas);
                workoutPage.ShowDialog();
            }
            #endregion

            routinPanel.Controls.Add(routinDGV);
            routinPanel.Controls.Add(RoutinNameLbl);
            routinPanel.Controls.Add(startRoutBtn);
        }
        internal bool AddNewRoutin(List<string[]> routinExercise, string routinName)
        {
            try
            {
                using (var connection = new SQLiteConnection(SQLiteConncectionString))
                {
                    connection.Open();
                    Guid routinGUID = Guid.NewGuid();
                    Guid routinWorkOutGUID = Guid.NewGuid();

                    string RoutineSQL = "INSERT INTO Routine VALUES (@guid, @name,@workoutListGUID)";
                    using (var command = new SQLiteCommand(RoutineSQL, connection))
                    {

                        command.Parameters.AddWithValue("@guid", routinGUID.ToString());
                        command.Parameters.AddWithValue("@name", routinName);
                        command.Parameters.AddWithValue("@workoutListGUID", routinWorkOutGUID.ToString());
                        command.ExecuteNonQuery();

                    }
                    string workout_listSQL = "INSERT INTO workout_list VALUES (@guid, @exerciseName, @weight, @set, @rep)";
                    using (var command = new SQLiteCommand(workout_listSQL, connection))
                    {

                        if (routinExercise.Count() > 0)
                        {
                            var listCount = routinExercise.Count();
                            for (int i = 0; i < listCount; i++)
                            {
                                command.Parameters.AddWithValue("@guid", routinWorkOutGUID.ToString());
                                command.Parameters.AddWithValue("@exerciseName", routinExercise[i][0]);
                                command.Parameters.AddWithValue("@weight", routinExercise[i][1]);
                                command.Parameters.AddWithValue("@set", routinExercise[i][2]);
                                command.Parameters.AddWithValue("@rep", routinExercise[i][3]);
                                command.ExecuteNonQuery();
                            }
                        }
                    }
                    return true;
                }
            }
            catch (Exception)
            {
                return false;
            }

        }
        internal bool AddRecord(string _routinName, string _timeSpan, string _date, int _totalWeight, int _totalSet)
        {
            try
            {
                using (var connection = new SQLiteConnection(SQLiteConncectionString))
                {
                    //routin_record_guid TEXT ,routine_name TEXT,total_set INTEGER, total_weight INTEGER, time_span TEXT, date TEXT
                    connection.Open();
                    Guid recordGUID = Guid.NewGuid();
                    string RoutineSQL = "INSERT INTO routin_record (routin_record_guid, routine_name, total_set, total_weight, time_span, date) VALUES (@guid, @name, @total_set, @total_weight, @time_span, @date)";

                    using (var command = new SQLiteCommand(RoutineSQL, connection))
                    {
                        command.Parameters.AddWithValue("@guid", recordGUID.ToString());
                        command.Parameters.AddWithValue("@name", _routinName);
                        command.Parameters.AddWithValue("@total_set", _totalSet);
                        command.Parameters.AddWithValue("@total_weight", _totalWeight);
                        command.Parameters.AddWithValue("@time_span", _timeSpan);
                        command.Parameters.AddWithValue("@date", _date);
                        command.ExecuteNonQuery();

                    }
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An unxpected error has accured.\n Please try again later \n\n {ex.Message}", "Repify", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }


}


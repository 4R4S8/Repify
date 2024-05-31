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

            if (File.Exists(_SQLiteDBPath) && _sqlFile.Length <= 0)
            {

                using (var conn = new SQLiteConnection(_SQLiteConncectionString))
                {
                    conn.Open();

                    using (var cmd = new SQLiteCommand(conn))
                    {
                        //Create a table named Exercise
                        cmd.CommandText = "CREATE TABLE Exercise (exercise_guid TEXT, Name TEXT, muscle_group TEXT)";
                        cmd.ExecuteNonQuery();

                        //Create a table named Routine

                        cmd.CommandText = "CREATE TABLE Routine (routine_guid TEXT, Name TEXT, workout_list_guid TEXT)";
                        cmd.ExecuteNonQuery();

                        //Create a table named workout_list

                        cmd.CommandText = "CREATE TABLE workout_list (workout_list_guid TEXT, exercise_guid TEXT,weight INTEGER,sets INTEGER, rep INTEGER )";
                        cmd.ExecuteNonQuery();

                        ////Create a table named Records
                        //cmd.CommandText = "CREATE TABLE records (records_guid TEXT, routine_guid TEXT, total_rep INTEGER, total_weight INTEGER)";
                        //cmd.ExecuteNonQuery();

                        //Create a table named Routin Record
                        cmd.CommandText = "CREATE TABLE routin_record (routin_record_guid TEXT ,routine_name TEXT,total_set INTEGER, total_weight INTEGER, time_span TEXT, date TEXT)";
                        cmd.ExecuteNonQuery();

                    }
                    InsertIntoExerciseTable(_SQLiteConncectionString);
                }
            }

        }
        internal void InsertIntoExerciseTable(string SQLiteConncectionString)
        {
            if (File.Exists(@"E:\4R4S8\دانشگاه\022\پروژه\FitnessTrackerApp\Assets\exercise-Name.txt")
               && File.Exists(@"E:\4R4S8\دانشگاه\022\پروژه\FitnessTrackerApp\Assets\muscle-group.txt"))
            {
                List<string> exerciseNameFile = new List<string>();
                List<string> muscleGroupFile = new List<string>();
                exerciseNameFile.AddRange(File.ReadLines(@"E:\4R4S8\دانشگاه\022\پروژه\FitnessTrackerApp\Assets\exercise-Name.txt"));
                muscleGroupFile.AddRange(File.ReadLines(@"E:\4R4S8\دانشگاه\022\پروژه\FitnessTrackerApp\Assets\muscle-group.txt"));

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
                            Panel routin = new Panel();
                            routin.Name = routineName;
                            routin.Size = new Size(930, 155);
                            routin.Location = new Point(0, 155);
                            routin.BackColor = Color.Beige;
                            routin.BorderStyle = BorderStyle.FixedSingle;
                            routin.Dock = DockStyle.Top;
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
                #region Panel exerPanel
                Panel exerPanel = new Panel();
                exerPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
                exerPanel.Dock = System.Windows.Forms.DockStyle.Top;
                exerPanel.Name = $"{_exerName}Panel";
                exerPanel.Size = new System.Drawing.Size(1020, 77);
                exerPanel.BorderStyle = BorderStyle.FixedSingle;
                #endregion
                AddControlsToExercisePanel(exerPanel, _exerName, _weight, _set, _rep, routonProgress);
                workoutPanel.Controls.Add(exerPanel);

            }
        }
        private void AddControlsToExercisePanel(Panel _exerPanel, string _exerName, string _weight, string _set, string _rep, ProgressBar _routonProgress)
        {
            #region weight_lbl
            Label weight_lbl = new Label();
            weight_lbl.AutoSize = true;
            weight_lbl.Font = new Font("Microsoft YaHei UI Light", 15F);
            weight_lbl.ForeColor = Color.SaddleBrown;
            weight_lbl.Location = new Point(229, 21);
            weight_lbl.Name = "weight_lbl";
            weight_lbl.Size = new Size(144, 32);
            weight_lbl.Text = $"{_weight} KG";
            weight_lbl.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            weight_lbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            #endregion
            #region set_repLbl
            Label set_repLbl = new Label();
            set_repLbl.AutoSize = true;
            set_repLbl.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 15F);
            set_repLbl.ForeColor = System.Drawing.Color.SaddleBrown;
            set_repLbl.Location = new System.Drawing.Point(439, 21);
            set_repLbl.Name = "set_repLbl";
            set_repLbl.Size = new System.Drawing.Size(125, 32);
            set_repLbl.Text = $"{_set} × {_rep}";
            set_repLbl.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            set_repLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            #endregion
            #region exerciseNameLbl
            Label exerciseNameLbl = new Label();
            exerciseNameLbl.AutoEllipsis = true;
            exerciseNameLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            exerciseNameLbl.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 14F);
            exerciseNameLbl.ForeColor = System.Drawing.Color.SaddleBrown;
            exerciseNameLbl.Location = new System.Drawing.Point(615, 4);
            exerciseNameLbl.Name = "exerciseNameLbl";
            exerciseNameLbl.Size = new System.Drawing.Size(305, 69);
            exerciseNameLbl.Text = _exerName;
            exerciseNameLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            exerciseNameLbl.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            exerciseNameLbl.Anchor = AnchorStyles.Right;
            #endregion
            #region exerciseIsDoneCheck
            CheckBox exerciseIsDoneCheck = new CheckBox();
            exerciseIsDoneCheck.AutoSize = true;
            exerciseIsDoneCheck.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 15F);
            exerciseIsDoneCheck.Location = new System.Drawing.Point(27, 15);
            exerciseIsDoneCheck.Name = $"{_exerName}IsDoneCheck";
            exerciseIsDoneCheck.Size = new System.Drawing.Size(97, 36);
            exerciseIsDoneCheck.Text = "Done";
            exerciseIsDoneCheck.UseVisualStyleBackColor = true;
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
            PictureBox exerPic = new PictureBox();
            //this.exerPic.Image = global::FitnessTrackerApp.Properties.Resources._28931101_Scissors__advanced___female__small_thumbnail_3x;
            exerPic.Location = new System.Drawing.Point(945, 4);
            exerPic.Name = $"{_exerName}Pic";
            exerPic.Size = new System.Drawing.Size(70, 70);
            exerPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            exerPic.TabIndex = 6;
            exerPic.TabStop = false;
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
            DataGridView routinDGV = new DataGridView();
            routinDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            routinDGV.BackgroundColor = SystemColors.ButtonHighlight;
            routinDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            routinDGV.EditMode = DataGridViewEditMode.EditProgrammatically;
            routinDGV.GridColor = SystemColors.ActiveCaption;
            routinDGV.Location = new Point(320, 20);
            routinDGV.Margin = new Padding(2);
            routinDGV.MultiSelect = false;
            routinDGV.Name = $"{_routinName}DGV";
            routinDGV.ReadOnly = true;
            routinDGV.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            routinDGV.RowHeadersWidth = 51;
            routinDGV.RowTemplate.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            routinDGV.RowTemplate.Height = 24;
            routinDGV.Size = new Size(395, 119);
            routinDGV.AllowUserToAddRows = false;
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
                WorkoutPage workoutPage = new WorkoutPage(_routinName, workoutDatas);
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
    }


}


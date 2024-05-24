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
            int x = 5;
            for (int i = 0; i < x; i++)
            {
                string routinName = $"routin{i + 1}";
                #region Panel routin
                Panel routin = new Panel();
                routin.Name = routinName;
                routin.Size = new Size(930, 155);
                routin.Location = new Point(0, 155);
                routin.BackColor = Color.Beige;
                routin.BorderStyle = BorderStyle.FixedSingle;
                routin.Dock = DockStyle.Top;
                #endregion
                AddControlsToPanel(routin, routinName);
                routinPanel.Controls.Add(routin);
            }
        }
        private void AddControlsToPanel(Panel routinPanel, string _routinName)
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
            #endregion
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
                WorkoutPage workoutPage = new WorkoutPage(_routinName);
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


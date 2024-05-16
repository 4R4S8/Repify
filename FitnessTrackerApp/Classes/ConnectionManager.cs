using System.Data.SQLite;
using System.IO;

namespace FitnessTrackerApp.Classes
{
    internal class ConnectionManager
    {
        internal void CreateDataBase()
        {
            if (!File.Exists("Repify.sqlite"))
            {
                SQLiteConnection.CreateFile("Repify.sqlite");
            }
            if (File.Exists("Repify.sqlite"))
            {

                using (var conn = new SQLiteConnection("Data Source=Repify.sqlite;Version=3;"))
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

                        cmd.CommandText = "CREATE TABLE workout_list (workout_list_guid TEXT, routine_guid TEXT, exercise_guid TEXT, rest_time TEXT, rep INTEGER)";
                        cmd.ExecuteNonQuery();

                        //Create a table named Records
                        cmd.CommandText = "CREATE TABLE records (records_guid TEXT, workout_list_guid TEXT, rep INTEGER, total_weight INTEGER)";
                        cmd.ExecuteNonQuery();

                        //Create a table named Routin Record
                        cmd.CommandText = "CREATE TABLE routin_record (routine_guid TEXT, total_weight INTEGER, time_span TEXT, date TEXT)";
                        cmd.ExecuteNonQuery();
                        // Insert some data into the table

                        //cmd.CommandText = "CREATE TABLE services (id INTEGER PRIMARY KEY,name TEXT NOT NULL, price REAL NOT NULL, duration INTEGER NOT NULL)";
                        //cmd.ExecuteNonQuery();
                        //cmd.CommandText = "CREATE TABLE customers (id INTEGER PRIMARY KEY,  name TEXT NOT NULL,  phone TEXT NOT NULL,  email TEXT,  address TEXT NOT NULL)";
                        //cmd.ExecuteNonQuery();
                        //cmd.CommandText = "CREATE TABLE jobs(id INTEGER PRIMARY KEY, customer_id INTEGER NOT NULL,service_id INTEGER NOT NULL,quantity INTEGER NOT NULL,status TEXT NOT NULL, pickup_date TEXT NOT NULL,delivery_date TEXT NOT NULL, FOREIGN KEY (customer_id) REFERENCES customers(id), FOREIGN KEY (service_id) REFERENCES services(id))";
                        //cmd.ExecuteNonQuery();



                        // Query the data from the table
                        //cmd.CommandText = "SELECT Id FROM Employee where Name = 'Alice'";
                        //using (var reader = cmd.ExecuteReader())
                        //{
                        //    // Loop through the results and print them to the console
                        //    while (reader.Read())
                        //    {
                        //        Console.WriteLine($"Id: {reader["Id"]}")/*, Name: {reader["Name"]}, Job: {reader["Job"]}")*/;
                        //    }
                        //}
                    }
                }
            }

        }
    }
}

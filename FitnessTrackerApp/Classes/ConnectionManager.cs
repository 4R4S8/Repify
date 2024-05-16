using System;
using System.Data.SQLite;
using System.IO;

namespace FitnessTrackerApp.Classes
{
    internal class ConnectionManager
    {
        void CreateDataBase()
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
                        //Create a table named Employee
                        //cmd.CommandText = "CREATE TABLE Employee (Id INTEGER PRIMARY KEY, Name TEXT, Job TEXT)";
                        //cmd.ExecuteNonQuery();

                        // Insert some data into the table

                        //cmd.CommandText = "CREATE TABLE services (id INTEGER PRIMARY KEY,name TEXT NOT NULL, price REAL NOT NULL, duration INTEGER NOT NULL)";
                        //cmd.ExecuteNonQuery();
                        //cmd.CommandText = "CREATE TABLE customers (id INTEGER PRIMARY KEY,  name TEXT NOT NULL,  phone TEXT NOT NULL,  email TEXT,  address TEXT NOT NULL)";
                        //cmd.ExecuteNonQuery();
                        //cmd.CommandText = "CREATE TABLE jobs(id INTEGER PRIMARY KEY, customer_id INTEGER NOT NULL,service_id INTEGER NOT NULL,quantity INTEGER NOT NULL,status TEXT NOT NULL, pickup_date TEXT NOT NULL,delivery_date TEXT NOT NULL, FOREIGN KEY (customer_id) REFERENCES customers(id), FOREIGN KEY (service_id) REFERENCES services(id))";
                        //cmd.ExecuteNonQuery();



                        // Query the data from the table
                        cmd.CommandText = "SELECT Id FROM Employee where Name = 'Alice'";
                        using (var reader = cmd.ExecuteReader())
                        {
                            // Loop through the results and print them to the console
                            while (reader.Read())
                            {
                                Console.WriteLine($"Id: {reader["Id"]}")/*, Name: {reader["Name"]}, Job: {reader["Job"]}")*/;
                            }
                        }
                    }
                }
            }

        }
    }
}

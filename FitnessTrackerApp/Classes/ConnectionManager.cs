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

            }
            using (var conn = new SQLiteConnection("Data Source=MyDatabase.sqlite;Version=3;"))

        }
    }
}

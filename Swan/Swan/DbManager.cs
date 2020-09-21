using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace Swan
{
    public static class DbManager
    {
        private static readonly string dbFileName = "swan_data.sqlite";
        private static readonly string connectionString = "Data Source = " + dbFileName + "; Version = 3;";

        public static bool CreateSwimmer(Swimmer sw)
        {
            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                string sql = "INSERT INTO swimmer (" +
                    "first_name," +
                    "last_name," +
                    "date_of_birth," +
                    "email," +
                    "home_number," +
                    "mobile_number," +
                    "street," +
                    "city," +
                    "zip," +
                    "emergency_contact," +
                    "emergency_number," +
                    "comments) VALUES (@fn,@ln,@dob,@email,@hn,@mn,@street,@city,@zip,@ec,@en,@comments);";
                try
                {
                    SQLiteCommand Command = new SQLiteCommand(sql, conn);
                    Command.Parameters.AddWithValue("@fn", sw.first_name);
                    Command.Parameters.AddWithValue("@ln", sw.last_name);
                    Command.Parameters.AddWithValue("@dob", sw.date_of_birth);
                    Command.Parameters.AddWithValue("@email", sw.email);
                    Command.Parameters.AddWithValue("@hn", sw.home_number);
                    Command.Parameters.AddWithValue("@mn", sw.mobile_number);
                    Command.Parameters.AddWithValue("@street", sw.street);
                    Command.Parameters.AddWithValue("@city", sw.city);
                    Command.Parameters.AddWithValue("@zip", sw.zip);
                    Command.Parameters.AddWithValue("@ec", sw.emergency_contact);
                    Command.Parameters.AddWithValue("@en", sw.emergency_number);
                    Command.Parameters.AddWithValue("@comments", sw.comments);
                    conn.Open();
                    Command.ExecuteNonQuery();
                }
                catch (SQLiteException e)
                {
                    if (e.ErrorCode == 19)
                    {
                        Console.WriteLine("Swimmer already in DB!");
                    }
                    return false;
                }
                return true;
            }
        }

        public static List<Swimmer> GetAllSwimmers()
        {
            List<Swimmer> ans = new List<Swimmer>();
            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                string sql = "SELECT * FROM swimmer;";
                try
                {
                    SQLiteCommand Command = new SQLiteCommand(sql, conn);
                    conn.Open();
                    SQLiteDataReader reader = Command.ExecuteReader();
                    while (reader.Read())
                    {
                        List<string> rowData = new List<string>();
                        int id = reader.GetInt32(0);
                        DateTime dob = DateTime.Parse(reader.GetString(3));
                        rowData.Add(reader.GetString(1));
                        rowData.Add(reader.GetString(2));
                        rowData.Add(reader.GetString(4));
                        rowData.Add(reader.GetString(5));
                        rowData.Add(reader.GetString(6));
                        rowData.Add(reader.GetString(7));
                        rowData.Add(reader.GetString(8));
                        rowData.Add(reader.GetString(9));
                        rowData.Add(reader.GetString(10));
                        rowData.Add(reader.GetString(11));
                        rowData.Add(reader.GetString(12));
                        ans.Add(new Swimmer(id, rowData, dob));
                    }
                }
                catch (SQLiteException e)
                {
                    Console.WriteLine(e);
                }
            }
            return ans;
        }

        public static bool AddRecord(int sw_id, string style, int distance, DateTime start, int milliseconds, List<Tuple<TimeSpan,TimeSpan>> laps)
        {
            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                string sql = "INSERT INTO track (" +
                    "swimmer," +
                    "style," +
                    "distance," +
                    "lane_distance," +
                    "tournament," +
                    "start," +
                    "millisecond," +
                    "comments) VALUES (@id,@sty,@dis,@lanedis,@tour,@st,@milli,@com);";
                try
                {
                    SQLiteCommand Command = new SQLiteCommand(sql, conn);
                    Command.Parameters.AddWithValue("@id", sw_id);
                    Command.Parameters.AddWithValue("@sty", style);
                    Command.Parameters.AddWithValue("@dis", distance);
                    Command.Parameters.AddWithValue("@lanedis", FormMain.selected50 ? 50 : 25);
                    Command.Parameters.AddWithValue("@tour", FormMain.selectedTM);
                    Command.Parameters.AddWithValue("@st", start);
                    Command.Parameters.AddWithValue("@milli", milliseconds);
                    Command.Parameters.AddWithValue("@com", "");
                    conn.Open();
                    Command.ExecuteNonQuery();
                    // check if we need to add laps to track
                    if (laps.Count > 0)
                    {
                        long trackid = conn.LastInsertRowId;
                        sql = "INSERT INTO lap (" +
                            "track," +
                            "millisecond," +
                            "total_millisecond) VALUES (@track_id, @milli, @total_milli);";
                        Command.CommandText = sql;
                        foreach (Tuple<TimeSpan,TimeSpan> lap in laps)
                        {
                            int laptime = Convert.ToInt32(lap.Item1.TotalMilliseconds);
                            int total = Convert.ToInt32(lap.Item2.TotalMilliseconds);
                            Command.Parameters.Clear();
                            Command.Parameters.AddWithValue("@track_id", trackid);
                            Command.Parameters.AddWithValue("@milli", laptime);
                            Command.Parameters.AddWithValue("@total_milli", total);
                            Command.ExecuteNonQuery();
                        }
                    }
                }
                catch (SQLiteException e)
                {
                    Console.WriteLine(e);
                    return false;
                }
            }
            return true;
        }

        public static Tuple<string, string, string> GetLastSameTrackText(int sw_id, string style, int distance)
        {
            string laps = "";
            string splits = "";
            string date = "";
            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                string sql = "SELECT lap.millisecond, lap.total_millisecond, track.start " +
                    "FROM lap INNER JOIN track ON track.id = lap.track " +
                    "WHERE track=(SELECT id FROM track WHERE swimmer=@sw AND style=@sty AND distance=@dis AND tournament=@tm ORDER BY start DESC LIMIT 1);";
                try
                {
                    SQLiteCommand Command = new SQLiteCommand(sql, conn);
                    Command.Parameters.AddWithValue("@sw", sw_id);
                    Command.Parameters.AddWithValue("@sty", style);
                    Command.Parameters.AddWithValue("@dis", distance);
                    Command.Parameters.AddWithValue("@tm", FormMain.selectedTM);
                    conn.Open();
                    SQLiteDataReader reader = Command.ExecuteReader();
                    while (reader.Read())
                    {
                        TimeSpan ts = TimeSpan.FromMilliseconds(reader.GetInt32(0));
                        laps += ts.ToString(@"mm\:ss\:ff") + "\n";
                        ts = TimeSpan.FromMilliseconds(reader.GetInt32(1));
                        splits += ts.ToString(@"mm\:ss\:ff") + "\n";
                        date = reader.GetDateTime(2).ToString("d");
                    }
                }
                catch (SQLiteException e)
                {
                    Console.WriteLine(e);
                }
            }
            return Tuple.Create(laps, splits, date); ;
        }

        public static void CreateDatabaseAndTablesIfNotExists()
        {
            // Check if DB-File already existing, so we dont overwrite
            if (!System.IO.File.Exists(dbFileName))
            {
                SQLiteConnection.CreateFile(dbFileName);
            }
            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                string sql = "CREATE TABLE IF NOT EXISTS swimmer (" +
                    "id INTEGER PRIMARY KEY AUTOINCREMENT," +
                    "first_name TEXT NOT NULL," +
                    "last_name TEXT NOT NULL," +
                    "date_of_birth TEXT NOT NULL," +
                    "email TEXT," +
                    "home_number TEXT," +
                    "mobile_number TEXT," +
                    "street TEXT," +
                    "city TEXT," +
                    "zip TEXT," +
                    "emergency_contact TEXT," +
                    "emergency_number TEXT," +
                    "comments TEXT," +
                    "UNIQUE(first_name, last_name, date_of_birth) ON CONFLICT ROLLBACK);" +
                    "CREATE TABLE IF NOT EXISTS track (" +
                    "id INTEGER PRIMARY KEY AUTOINCREMENT," +
                    "swimmer INTEGER NOT NULL," +
                    "style TEXT," +
                    "distance INTEGER," +
                    "lane_distance INTEGER," +
                    "tournament INTEGER," +
                    "start TEXT," +
                    "millisecond INTEGER," +
                    "comments TEXT," +
                    "FOREIGN KEY (swimmer) REFERENCES swimmer(id) ON DELETE CASCADE);" +
                    "CREATE TABLE IF NOT EXISTS lap (" +
                    "track INTEGER NOT NULL," +
                    "millisecond INTEGER," +
                    "total_millisecond INTEGER," +
                    "FOREIGN KEY (track) REFERENCES track(id) ON DELETE CASCADE);";
                try
                {
                    SQLiteCommand Command = new SQLiteCommand(sql, conn);
                    conn.Open();
                    Command.ExecuteNonQuery();
                }
                catch (SQLiteException e)
                {
                    Console.WriteLine(e);
                }
                
            }
        }
    }
}

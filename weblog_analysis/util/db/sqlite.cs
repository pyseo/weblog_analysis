using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SQLite;
using System.Data.SQLite.Linq;
using System.IO;
using System.Windows.Forms;
using System.Data;

namespace weblog_analysis.util.db
{
    internal class sqlite
    {
        private SQLiteConnection conn = null;
        
        public void CreateDB() 
        {
            string rootdir = Environment.CurrentDirectory;
            string dbfile = Path.Combine(rootdir, "sqlite.db");
            
            if (!File.Exists(dbfile))
            {
                SQLiteConnection.CreateFile("sqlite.db");
            }
        }

        public void ConnectionDB()
        {
            string rootdir = Environment.CurrentDirectory;
            string dbfile = Path.Combine(rootdir, "sqlite.db");

            string connString = string.Format("Data Source={0};Version=3;", dbfile);
            conn = new SQLiteConnection(connString);
            conn.Open();
        }

        public void testDB()
        {
            string sql = "create table members (name varchar(20), age int)";
            SQLiteCommand command = new SQLiteCommand(sql, conn);
            int result = command.ExecuteNonQuery();
            sql = "create index idx01 on members(name)";
            command = new SQLiteCommand(sql, conn);
            result = command.ExecuteNonQuery();

            sql = "insert into members (name, age) values ('김도현', 6)";
            command = new SQLiteCommand(sql, conn);
            result = command.ExecuteNonQuery();

            sql = "select * from members";
            command = new SQLiteCommand(sql, conn);
            SQLiteDataReader rdr = command.ExecuteReader();
            while (rdr.Read())
            {
                MessageBox.Show(rdr["name"] + " " + rdr["age"]);
            }
            rdr.Close();
        }

        public void CloseDB()
        {
            conn.Close();
        }
    }
}

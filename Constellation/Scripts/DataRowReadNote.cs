using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace Constellation.Scripts
{
    internal class DataRowReadNote
    {
        public static DataRow[] ReadDatabaseRowNote()
        {
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            string BoardOpened = config.AppSettings.Settings["BoardToOpen"].Value;
            string UserDataLocaion = config.AppSettings.Settings["UserLoginLocation"].Value;
            SQLiteConnection sqlconnection = new SQLiteConnection();
            sqlconnection.ConnectionString = "DataSource = " + UserDataLocaion;
            string commandText = "SELECT * FROM '" + BoardOpened + "'";
            DataTable table = new DataTable();
            SQLiteDataAdapter myDataAdapter = new SQLiteDataAdapter(commandText, sqlconnection);
            sqlconnection.Open();
            myDataAdapter.Fill(table);
            //put all data from the database into datarow
            DataRow[] rows = table.Select();
            sqlconnection.Close();
            return rows;
        }
        public static DataRow[] ReadDatabaseRowNoteAll(DataRow[] Boards)
        {
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            string BoardOpened = config.AppSettings.Settings["BoardToOpen"].Value;
            string UserDataLocaion = config.AppSettings.Settings["UserLoginLocation"].Value;
            SQLiteConnection sqlconnection = new SQLiteConnection();
            sqlconnection.ConnectionString = "DataSource = " + UserDataLocaion;
            string commandText = "SELECT * FROM *";
            DataTable table = new DataTable();
            SQLiteDataAdapter myDataAdapter = new SQLiteDataAdapter(commandText, sqlconnection);
            sqlconnection.Open();
            myDataAdapter.Fill(table);
            //put all data from the database into datarow
            DataRow[] rows = table.Select();
            sqlconnection.Close();
            return rows;
        }

        public static (DataRow[], int) FindInDataRowNote(string Find)
        {
            DataRow[] rows = ReadDatabaseRowNote();
            int i = 0;
            bool found = false;
            while (!found)
            {
                if (rows[i]["Name"].ToString() == Find)
                {
                    found = true;
                }
                else
                {
                    i++;
                }
            }
            return (rows, i);
        }
        public static DataRow[] ReadDatabaseRowSelectedBoard(string Selected)
        {
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            string BoardOpened = config.AppSettings.Settings["BoardToOpen"].Value;
            string UserDataLocaion = config.AppSettings.Settings["UserLoginLocation"].Value;
            SQLiteConnection sqlconnection = new SQLiteConnection();
            sqlconnection.ConnectionString = "DataSource = " + UserDataLocaion;
            string commandText = "SELECT * FROM '" + Selected + "'";
            DataTable table = new DataTable();
            SQLiteDataAdapter myDataAdapter = new SQLiteDataAdapter(commandText, sqlconnection);
            sqlconnection.Open();
            myDataAdapter.Fill(table);
            //put all data from the database into datarow
            DataRow[] rows = table.Select();
            sqlconnection.Close();
            return rows;
        }
    }
}

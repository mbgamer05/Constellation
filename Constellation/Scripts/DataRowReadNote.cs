using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Net.Sockets;

namespace Constellation.Scripts
{
    internal class DataRowReadNote
    {
        public static DataRow[] ReadCurrentBoardsNotes()
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
        /// <summary>
        /// reads all the databases notes
        /// </summary>
        /// <param name="Boards">the current selected board</param>
        /// <returns>datarow containing all the notes</returns>
        public static List<DataRow> ReadAllBoardsNotes(DataRow[] Boards)
        {
            int i = 0;
            bool end = false;
            List<DataRow> rows = new List<DataRow>();
            while (end == false)
            {
                try
                {
                    Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                    string BoardOpened = config.AppSettings.Settings["BoardToOpen"].Value;
                    string UserDataLocaion = config.AppSettings.Settings["UserLoginLocation"].Value;
                    SQLiteConnection sqlconnection = new SQLiteConnection();
                    DataRow[] boards = DataRowReadBoard.GetAllDatabaseBoards();
                    sqlconnection.ConnectionString = "DataSource = " + UserDataLocaion;
                    string commandText = "SELECT * FROM '" + boards[i]["name"] + "'";
                    DataTable table = new DataTable();
                    SQLiteDataAdapter myDataAdapter = new SQLiteDataAdapter(commandText, sqlconnection);
                    sqlconnection.Open();
                    myDataAdapter.Fill(table);
                    sqlconnection.Close();
                    rows = AddRow(table, rows);
                    i++;
                }
                catch
                {
                    end = true; break;
                }
            }
            return rows;
           
        }
        /// <summary>
        /// adds a new datarow to the database
        /// </summary>
        /// <param name="table">the datatable that holds the current data</param>
        /// <param name="input">the current input which contains the list of datarows</param>
        /// <returns></returns>
        public static List<DataRow> AddRow(DataTable table, List<DataRow> input)
        {
            List<DataRow> rows = input;
            foreach (DataRow row in table.Rows)
            {
                rows.Add(row);
            }
            return rows;
        }

        public static (DataRow[], int) FindInDataRowNote(string Find)
        {
            DataRow[] rows = ReadCurrentBoardsNotes();
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
        /// <summary>
        /// gets all the selected boards notes
        /// </summary>
        /// <param name="Selected">gets the selected boards and there </param>
        /// <returns>a datarow with all the selected boards</returns>
        public static DataRow[] ReadSelectedBoardsNotes(string Selected)
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

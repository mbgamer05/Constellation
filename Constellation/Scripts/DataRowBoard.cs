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
    internal class DataRowBoard
    {
        /// <summary>
        /// gets all the boards(tables) associated with the current user
        /// </summary>
        /// <returns>returns the datarow</returns>
        public static DataRow[] GetAllDatabaseBoards()
        {
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            string UserDataLocaion = config.AppSettings.Settings["UserLoginLocation"].Value; SQLiteConnection sqlconnection = new SQLiteConnection();
            sqlconnection.ConnectionString = "DataSource = " + UserDataLocaion;
            string commandText = "SELECT * FROM sqlite_master WHERE type = 'table'";
            DataTable table = new DataTable();
            SQLiteDataAdapter myDataAdapter = new SQLiteDataAdapter(commandText, sqlconnection);
            sqlconnection.Open();
            myDataAdapter.Fill(table);
            sqlconnection.Close();
            DataRow[] rows = table.Select();
            return rows;
        }
        /// <summary>
        /// gets all the Colour(tables) associated with the Application
        /// </summary>
        /// <returns>returns the datarow</returns>
        public static DataRow[] GetAllDatabaseColours()
        {
            string FolderPath = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            string FileCreatePath = FolderPath + "\\Constellation";
            string[] colourpathFind = new string[2] { FileCreatePath, "Colour" };
            string ColourPath = Path.Combine(colourpathFind) + ".db";
            PublicData PD = new PublicData();
            SQLiteConnection sqlconnection = new SQLiteConnection();
            sqlconnection.ConnectionString = "DataSource = " + ColourPath;
            string commandText = "SELECT * FROM sqlite_master WHERE type = 'table'";
            DataTable table = new DataTable();
            SQLiteDataAdapter myDataAdapter = new SQLiteDataAdapter(commandText, sqlconnection);
            sqlconnection.Open();
            myDataAdapter.Fill(table);
            sqlconnection.Close();
            DataRow[] rows = table.Select();
            return rows;
        }
        /// <summary>
        /// finds the know boards location and returns its location
        /// </summary>
        /// <param name="Find">gives a name of what board needs to be found</param>
        /// <returns>returns the datarows and also the location</returns>
        public static (DataRow[], int) FindBoardInDatabase(string Find)
        {
            int i = 0;
            DataRow[] rows = GetAllDatabaseBoards();
            bool found = false;
            while (!found)
            {
                if (rows[i]["name"].ToString() == Find)
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

    }
}

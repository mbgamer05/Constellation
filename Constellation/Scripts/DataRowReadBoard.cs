using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constellation.Scripts
{
    internal class DataRowReadBoard
    {
        /// <summary>
        /// gets all the boards(tables) associated with the current user
        /// </summary>
        /// <returns>returns the datarow</returns>
        public static DataRow[] GetAllDatabaseBoards()
        {
            PublicData PD = new PublicData();
            SQLiteConnection sqlconnection = new SQLiteConnection();
            sqlconnection.ConnectionString = "DataSource = " + PD.UserDataLocaion;
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

﻿using System;
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
        public static DataRow[] ReadDatabaseBoards()
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
        public static (DataRow[], int) FindBoardInDatabase(string Find)
        {
            int i = 0;
            DataRow[] rows = ReadDatabaseBoards();
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
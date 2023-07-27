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
    internal class Setups
    {
        public static string CreateBoard(string BoardName, string Path)
        {
            SQLiteConnection CreateTable = new SQLiteConnection();
            CreateTable.ConnectionString = "DataSource = " + Path;
            SQLiteCommand SetUpCommand = new SQLiteCommand();
            SetUpCommand.Connection = CreateTable;
            SetUpCommand.CommandType = CommandType.Text;
            SetUpCommand.CommandText = "CREATE TABLE '" + BoardName + "'" +
            "(Name  TEXT NOT NULL," +
            "PreviewBody   TEXT NOT NULL," +
            "FullBody  TEXT," +
            "Date  TEXT," +
            "Location  INT," +
            "PBoard    INTEGER," +
            "PRIMARY KEY(Name))";
            CreateTable.Open();
            SetUpCommand.ExecuteNonQuery();
            CreateTable.Close();
            return BoardName;
        }
    }
}

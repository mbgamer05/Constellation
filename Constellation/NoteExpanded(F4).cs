﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Constellation
{
    public partial class NoteExpanded_F4_ : Form
    {
        static Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
        public NoteExpanded_F4_()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnApply_Click(object sender, EventArgs e)
        {
            //adds finsihing touches to data making sure that it is all valid 
            string[] data = new string[4];
            data[0] = txtName.Text;
            data[1] = txtPreview.Text;
            data[2] = txtBody.Text;
            data[3] = dtpDate.Text;
            data[3] = data[3].Replace(",", "");
            int i = 0;
            foreach (string s in data)
            {
                if (data[i].Contains("'"))
                {
                    data[i] = data[i].Replace("'", "''");
                }
                i++;
            }
            //makes sure note name is always valid
            Board_F3_.NoteName = Board_F3_.NoteName.Replace("'", "''");

            var ConfigLocation = config.AppSettings.Settings["UserLoginLocation"].Value;
            //writes new data to database
            SQLiteConnection sqlconnection = new SQLiteConnection();
            sqlconnection.ConnectionString = "DataSource = " + ConfigLocation;
            SQLiteCommand sqlCommand = new SQLiteCommand();
            sqlCommand.Connection = sqlconnection;
            sqlCommand.CommandType = CommandType.Text;
            sqlCommand.CommandText = sqlCommand.CommandText = "UPDATE Board1 " +
                "SET Name = '" + data[0] + "'," +
                " PreviewBody = '" + data[1] + "'," +
                " FullBody = '" + data[2] + "'," +
                " Date = '" + data[3] + "'" +
                " WHERE Name = '" + Board_F3_.NoteName + "'";
            sqlconnection.Open();
            sqlCommand.ExecuteNonQuery();
            sqlconnection.Close();
            MessageBox.Show("Changes applied");

            btnClose.Visible = true;
            btnClose.Enabled = true;
        }

        private void NoteExpanded_F4__Load(object sender, EventArgs e)
        {
            btnClose.Enabled = false;
            btnClose.Visible = false;
            var ConfigLocation = config.AppSettings.Settings["UserLoginLocation"].Value;
            //connects to the database to read data from already existing data
            SQLiteConnection sqlconnection = new SQLiteConnection();
            sqlconnection.ConnectionString = "DataSource = " + ConfigLocation;
            SQLiteCommand sqlCommand = new SQLiteCommand();
            string commandText = "SELECT * FROM Board1";
            DataTable table = new DataTable();
            SQLiteDataAdapter myDataAdapter = new SQLiteDataAdapter(commandText, sqlconnection);
            sqlconnection.Open();
            myDataAdapter.Fill(table);
            sqlconnection.Close();
            DataRow[] rows = table.Select();
            int i = 0;
            bool found = false;
            while (!found)
            {
                if (rows[i]["Name"].ToString() == Board_F3_.NoteName)
                {
                    found = true;
                }
                else
                {
                    i++;
                }
            }
            txtName.Text = rows[i]["Name"].ToString();
            txtPreview.Text = rows[i]["PreviewBody"].ToString();
            txtBody.Text = rows[i]["FullBody"].ToString();
            dtpDate.Value = DateTime.Parse(rows[i]["Date"].ToString());
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
using System;
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
        public static string BoardOpened = config.AppSettings.Settings["BoardToOpen"].Value;
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
            bool allow = false;
            foreach (string s in data)
            {
                if (string.IsNullOrEmpty(s))
                {
                    MessageBox.Show("whoa there you've got some empty data please make sure everything is filled in please");
                }
                else
                {
                    allow = true;
                }
            }
            if (allow == true)
            {
                foreach (string s in data)
                {

                    if (data[i].Contains("'"))
                    {
                        data[i] = data[i].Replace("'", "''");
                    }
                    i++;
                }
                //makes sure note name is always valid
                if (!string.IsNullOrEmpty(Board_F3_.NoteName))
                {
                    Board_F3_.NoteName = Board_F3_.NoteName.Replace("'", "''");
                }
                var ConfigLocation = config.AppSettings.Settings["UserLoginLocation"].Value;
                //writes new data to database
                SQLiteConnection sqlconnection = new SQLiteConnection();
                sqlconnection.ConnectionString = "DataSource = " + ConfigLocation;
                SQLiteCommand sqlCommand = new SQLiteCommand();
                sqlCommand.Connection = sqlconnection;
                sqlCommand.CommandType = CommandType.Text;
                switch(Board_F3_.Create)
                {
                    case 0:
                        sqlCommand.CommandText = "INSERT INTO " + BoardOpened +
                   "(Name, PreviewBody, FullBody, Date, Location)" +
                   " Values (@Name, @PreviewBody, @FullBody, @Date, @Location)";
                        sqlCommand.Parameters.AddWithValue("@Name", data[0]);
                        sqlCommand.Parameters.AddWithValue("@PreviewBody", data[1]);
                        sqlCommand.Parameters.AddWithValue("@FullBody", data[2]);
                        sqlCommand.Parameters.AddWithValue("@Date", data[3]);
                        sqlCommand.Parameters.AddWithValue("@Location", 0);
                        sqlconnection.Open();
                        sqlCommand.ExecuteNonQuery();
                        sqlconnection.Close();
                        MessageBox.Show("New note made");
                        break;

                    case 1:
                        sqlCommand.CommandText = sqlCommand.CommandText = "UPDATE "+ BoardOpened +
                                        " SET Name = '" + data[0] + "'," +
                                        " PreviewBody = '" + data[1] + "'," +
                                        " FullBody = '" + data[2] + "'," +
                                        " Date = '" + data[3] + "'" +
                                        " WHERE Name = '" + Board_F3_.NoteName + "'";
                        sqlconnection.Open();
                        sqlCommand.ExecuteNonQuery();
                        sqlconnection.Close();
                        MessageBox.Show("Changes applied");
                        break;
                }


                btnClose.Visible = true;
                btnClose.Enabled = true;
            }
            
        }

        private void NoteExpanded_F4__Load(object sender, EventArgs e)
        {

            if (Board_F3_.Create != 0)
            {
                btnClose.Enabled = false;
                btnClose.Visible = false;
                (DataRow[] rows, int i) = Class.DataRowReadNote.FindInDataRowNote(Board_F3_.NoteName);
                txtName.Text = rows[i]["Name"].ToString();
                txtPreview.Text = rows[i]["PreviewBody"].ToString();
                txtBody.Text = rows[i]["FullBody"].ToString();
                dtpDate.Value = DateTime.Parse(rows[i]["Date"].ToString());
            }
            else if (Board_F3_.Create == 0)
            {
                btnClose.Enabled = false;
                btnClose.Visible = false;
            }
            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

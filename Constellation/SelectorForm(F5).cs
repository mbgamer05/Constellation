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
using Constellation.Scripts;

namespace Constellation
{
    public partial class SelectorForm_F5_ : Form
    {
        public SelectorForm_F5_()
        {
            InitializeComponent();
        }
        public bool Choice = false;
        public static bool allow = false;
        public Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
        public string Action;

        private void SelectorForm_F5__Load(object sender, EventArgs e)
        {
            if (Action == "Delete")
            {
                txtConfirm.Visible = true;
                Choice = true;
                //sets text of buttons 
                btnNo.Text = "Cancel";
                btnYes.Text = "Delete";
                this.Text = "Select Note";
                LoadNotes();
            }
            else
            {
                allow = false;
                Choice = false;
                //sets text of buttons
                btnNo.Text = "Cancel";
                btnYes.Text = "Open";
                this.Text = "Select Board";
                LoadBoards();
            }
        }

        private void LoadBoards()
        {
            DataRow[] rows = DataRowBoard.GetAllDatabaseBoards();
            //creates a entry in the combo box for each of the entries in the datarow
            foreach (DataRow row in rows)
            {
                cbSelector.Items.Add(row["name"].ToString());
                cbSelector.SelectedIndex = 0;
            }
        }

        private void LoadNotes()
        {
            DataRow[] rows = DataRowNote.ReadCurrentBoardsNotes();
            //creates a entry in the combo box for each of the entries in the datarow
            foreach (DataRow row in rows)
            {
                cbSelector.Items.Add(row["Name"].ToString());
            }
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            switch (Choice)
            {
                case true:
                    if (string.IsNullOrEmpty(txtConfirm.Text))
                    {
                        MessageBox.Show("please enter the name of the note then press this again");
                    }
                    else
                    {
                        DialogResult dr = MessageBox.Show("Are you sure?", "Conformation", MessageBoxButtons.YesNo);
                        switch (dr)
                        {
                            case DialogResult.Yes:
                                PublicData PD = new PublicData();
                                MessageBox.Show("Deleting entry...");
                                Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                                var ConfigLocation = config.AppSettings.Settings["UserLoginLocation"].Value;
                                //connects to the database to remove Data
                                SQLiteConnection sqlconnection = new SQLiteConnection();
                                sqlconnection.ConnectionString = "DataSource = " + ConfigLocation;
                                SQLiteCommand sqlCommand = new SQLiteCommand();
                                sqlCommand.Connection = sqlconnection;
                                sqlCommand.CommandType = CommandType.Text;
                                sqlCommand.CommandText = "DELETE FROM '" + PD.BoardOpened + "' WHERE Name = '" + cbSelector.SelectedItem.ToString() + "'";
                                sqlconnection.Open();
                                sqlCommand.ExecuteNonQuery();
                                sqlconnection.Close();
                                cbSelector.Items.Clear();
                                LoadNotes();
                                txtConfirm.Text = "";
                                this.Close();
                                break;

                            case DialogResult.No:
                                MessageBox.Show("Cancelling...");
                                break;
                        }
                    }
                    break;
                case false:
                    MessageBox.Show("loading the board up now please wait...");
                    config.AppSettings.Settings["BoardToOpen"].Value = cbSelector.Text;
                    config.Save(ConfigurationSaveMode.Modified);
                    ConfigurationManager.RefreshSection("appSettings");
                    allow = true;
                    this.Close();
                    break;
            }
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tlpBottomHold_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

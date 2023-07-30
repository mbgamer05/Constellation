using Constellation.Scripts;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Constellation.Controls
{
    public partial class ToDo : UserControl
    {
        public string BoardName;
        public static Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
        public static string BoardOpened = config.AppSettings.Settings["BoardToOpen"].Value;
        public static string UserDataLocation = config.AppSettings.Settings["UserLoginLocation"].Value;


        public ToDo()
        {
            InitializeComponent();
        }

        private void bsBoards_Load(object sender, EventArgs e)
        {
            bsBoards.Left.Click += bsLeft_Click;
            bsBoards.Right.Click += bsRight_Click;
            bsBoards.BannerText = BoardOpened;
            ReloadListbox();
            VisabilityDisable();
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
            btnMove.Enabled = false;
        }
        private void bsLeft_Click(object sender, EventArgs e)
        {
            (DataRow[] rows, int i) = DataRowBoard.FindBoardInDatabase(bsBoards.BannerText);
            try
            {
                bsBoards.BannerText = rows[i - 1]["name"].ToString();
            }
            catch
            {
                bsBoards.BannerText = rows[i = rows.Length - 1]["name"].ToString();
            }
            ReloadListbox();
            BoardName = bsBoards.BannerText;
        }
        private void bsRight_Click(object sender, EventArgs e)
        {
            (DataRow[] rows, int i) = DataRowBoard.FindBoardInDatabase(bsBoards.BannerText);
            try
            {
                bsBoards.BannerText = rows[i + 1]["name"].ToString();
            }
            catch
            {
                bsBoards.BannerText = rows[0]["name"].ToString();
            }
            ReloadListbox();
            BoardName = bsBoards.BannerText;
        }
        private void ReloadListbox()
        {
            UpdateConfig.NewValue(bsBoards.BannerText, "BoardToOpen");
            ListboxActions.ReloadListbox(lbToDoNoteNames, 0);
        }
        private void ReloadListboxEvent(object sender, EventArgs e)
        {
            ReloadListbox();
        }
        private void lbToDoNoteNames_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool Allow = ListboxActions.CheckSelected(lbToDoNoteNames);
            switch (Allow)
            {
                case true:
                    btnEdit.Enabled = true;
                    btnDelete.Enabled = true;
                    btnMove.Enabled = true;
                    break;
                case false:
                    btnEdit.Enabled = false;
                    btnDelete.Enabled = false;
                    btnMove.Enabled = false;
                    break;
            }
            
        }

        private void btnMove_Click(object sender, EventArgs e)
        {
            //checks that there is a selected note
            //if nothing is selected display error message
            //if something is selected make movement buttons visable
            if (lbToDoNoteNames.SelectedIndex == -1)
            {
                MessageBox.Show("please select an item first\n you can do this by clicking on the names on the left");
            }
            else
            {
                btnToDo.Visible = true;
                btnDoing.Visible = true;
                btnDone.Visible = true;
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            //checks if there is a note selected
            //if something is selected open the note editor and edit the selected note
            if (lbToDoNoteNames.SelectedIndex == -1)
            {
                MessageBox.Show("please select an item first\n you can do this by clicking on the names on the left");
            }
            else
            {
                Board_F3_.NoteName = lbToDoNoteNames.SelectedItem.ToString();
                Board_F3_.Create = 1;
                NoteExpanded_F4_ NoteExpanded = new NoteExpanded_F4_();
                NoteExpanded.Show();
                NoteExpanded.FormClosed += ReloadListboxEvent;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //cofirms that the user wants to delete the note
            //if yes deletes the selected note
            if (lbToDoNoteNames.SelectedIndex == -1)
            {
                MessageBox.Show("please select an item first\n you can do this by clicking on the names on the left");
            }
            else
            {
                DialogResult dr = MessageBox.Show("Are you sure you want to delete this from the board\n this action cannot be undone", "conformation", MessageBoxButtons.YesNo);
                switch (dr)
                {
                    case DialogResult.Yes:
                        var ConfigLocation = config.AppSettings.Settings["UserLoginLocation"].Value;
                        //connects to the database to remove Data
                        SQLiteConnection sqlconnection = new SQLiteConnection();
                        sqlconnection.ConnectionString = "DataSource = " + ConfigLocation;
                        SQLiteCommand sqlCommand = new SQLiteCommand();
                        sqlCommand.Connection = sqlconnection;
                        sqlCommand.CommandType = CommandType.Text;
                        sqlCommand.CommandText = "DELETE FROM '" + BoardName + "' WHERE Name = '" + lbToDoNoteNames.SelectedItem.ToString() + "'";
                        sqlconnection.Open();
                        sqlCommand.ExecuteNonQuery();
                        sqlconnection.Close();
                        ReloadListbox();
                        break;
                }
            }
        }

        private void btnToDo_Click(object sender, EventArgs e)
        {
            VisabilityDisable();
            UpdateLocation(0);
        }

        private void btnDoing_Click(object sender, EventArgs e)
        {
            VisabilityDisable();
            UpdateLocation(1);
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            VisabilityDisable();
            UpdateLocation(2);
        }
        private void UpdateLocation(int location)
        {
            //updates the location(todo,doing,done) of the note
            (DataRow[] rows, int i) = DataRowNote.FindInDataRowNote(lbToDoNoteNames.SelectedItem.ToString());
            SQLiteConnection sqlconnection = new SQLiteConnection();
            sqlconnection.ConnectionString = "DataSource = " + UserDataLocation;
            SQLiteCommand sqlCommand = new SQLiteCommand();
            sqlCommand.CommandType = CommandType.Text;
            sqlCommand.Connection = sqlconnection;
            sqlCommand.CommandText = "UPDATE '" + BoardOpened + "'" +
                " SET Location = " + location +
                " WHERE Name = " + "'" + rows[i]["Name"].ToString() + "'";
            sqlconnection.Open();
            sqlCommand.ExecuteNonQuery();
            sqlconnection.Close();
            ReloadListbox();
        }
        private void VisabilityDisable()
        {
            btnToDo.Visible = false;
            btnDoing.Visible = false;
            btnDone.Visible = false;
        }
    }
}

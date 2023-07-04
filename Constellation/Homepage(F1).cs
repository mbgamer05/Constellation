using Microsoft.VisualBasic;
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
    public partial class Homepage_F1_ : Form
    {
        public string Action;
        public Homepage_F1_()
        {
            InitializeComponent();
        }
        public string BoardName;
        public static Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
        public static string BoardOpened = config.AppSettings.Settings["BoardToOpen"].Value;

        private void btnSettings_Click(object sender, EventArgs e)
        {
            Settings_F2_ settings = new Settings_F2_();
            settings.FormClosed += Settings_F2__FormClosed;
            this.Hide();
            settings.Show();
        }

        private async void btnBoard_Click(object sender, EventArgs e)
        {
            //opens the selector form up
            //in the selctor form the user selects the board they want to open
            SelectorForm_F5_ selector = new SelectorForm_F5_();
            selector.Action = "FindBoard";
            selector.Show();
            selector.FormClosing += Open_board;
        }
        private void Open_board(object sender, EventArgs e)
        {
            //opens the note board and hides the homepage
            if (SelectorForm_F5_.allow == true)
            {
                Board_F3_ Board = new Board_F3_();
                Board.FormClosed += Board_F3__FormClosed;
                this.Hide();
                Board.Show();
            }
        }
        private void Settings_F2__FormClosed(object sender, EventArgs e)
        {
            this.Show();
        }
        private void Board_F3__FormClosed(object sender, EventArgs e)
        {
            this.Show();
        }

        private void Homepage_F1__Load(object sender, EventArgs e)
        {
            //form set up
            btnToDo.Visible = false;
            btnDoing.Visible = false;
            btnDone.Visible = false;
            LoadColours();
            BoardName = BoardOpened;
            GenerateListBoxEntries();
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
            btnMove.Enabled = false;
        }

        private void GenerateListBoxEntries()
        {
            //allows list box scrolling
            //gets all data from the board that is selected
            lbToDoNoteNames.HorizontalScrollbar = true;
            DataRow[] rows = Class.DataRowReadNote.ReadDatabaseRowNote();
            bool create = true;
            int i = 0;
            while (create == true)
            {
                if (i >= rows.Length)
                {
                    create = false;
                }
                else
                {
                    lbToDoNoteNames.Items.Add(rows[i]["Name"].ToString());
                    i++;
                }
            }
        }
        /// <summary>
        /// loads colours onto form controls
        /// </summary>
        private void LoadColours()
        {

            (int[] PrimaryButtonARGB, int[] SecondaryButtonARGB, int[] TextARGB, int[] BackgroundARGB, int[] TextBoxBackgroundARGB) = MoreSettings.ReadStringData(MoreSettings.ReadData());
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            this.BackColor = Color.FromArgb(BackgroundARGB[0], BackgroundARGB[1], BackgroundARGB[2], BackgroundARGB[3]);
            this.ForeColor = Color.FromArgb(TextARGB[0], TextARGB[1], TextARGB[2], TextARGB[3]);
            Control cn = this;
            cn = Class.LoadColours.SetColours(cn, this);
        }

        private void pbUserIcon_Click(object sender, EventArgs e)
        {

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
                NoteExpanded.FormClosed += Form_Reload;
            }

        }
        private void Form_Reload(object sender, EventArgs e)
        {
            lbToDoNoteNames.Items.Clear();
            GenerateListBoxEntries();
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

                        MessageBox.Show("Deleting note...");
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
                        lbToDoNoteNames.Items.Clear();
                        GenerateListBoxEntries();
                        break;

                    case DialogResult.No:
                        MessageBox.Show("ok canceling action");
                        break;
                }
            }

        }

        private void btnToDo_Click(object sender, EventArgs e)
        {
            btnToDo.Visible = false;
            btnDoing.Visible = false;
            btnDone.Visible = false;
            UpdateLocation(0);
        }

        private void UpdateLocation(int location)
        {
            //updates the location(todo,doing,done) of the note
            (DataRow[] rows, int i) = Class.DataRowReadNote.FindInDataRowNote(lbToDoNoteNames.SelectedItem.ToString());
            SQLiteConnection sqlconnection = new SQLiteConnection();
            SQLiteCommand sqlCommand = new SQLiteCommand();
            sqlCommand.CommandType = CommandType.Text;
            sqlCommand.Connection = sqlconnection;
            sqlCommand.CommandText = "UPDATE '" + BoardOpened + "'" +
                " SET Location = " + location +
                " WHERE Name = " + "'" + rows[i]["Name"].ToString() + "'";

            sqlconnection.Open();
            sqlCommand.ExecuteNonQuery();
            sqlconnection.Close();
        }

        private void btnDoing_Click(object sender, EventArgs e)
        {
            btnToDo.Visible = false;
            btnDoing.Visible = false;
            btnDone.Visible = false;
            UpdateLocation(1);
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            btnToDo.Visible = false;
            btnDoing.Visible = false;
            btnDone.Visible = false;
            UpdateLocation(2);
        }

        private void Homepage_F1__FormClosing(object sender, FormClosingEventArgs e)
        {
            //if quick close is true then close the application on the homepage and don't go back to the login screen
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            string QuickClose = config.AppSettings.Settings["QuickClose"].Value;
            switch (QuickClose)
            {
                case "True":
                    Application.Exit();
                    break;
                case "False":
                    this.Close();
                    break;
            }
        }

        private void btnNewBoard_Click(object sender, EventArgs e)
        {
            string BoardName = Interaction.InputBox("Please enter name of the board", "Board Creation", "");
            if (!string.IsNullOrEmpty(BoardName))
            {
                var ConfigLocation = config.AppSettings.Settings["UserLoginLocation"].Value;
                SQLiteConnection CreateTable = new SQLiteConnection();
                CreateTable.ConnectionString = "DataSource = " + ConfigLocation;
                SQLiteCommand SetUpCommand = new SQLiteCommand();
                SetUpCommand.Connection = CreateTable;
                SetUpCommand.CommandType = CommandType.Text;
                SetUpCommand.CommandText = "CREATE TABLE '" + BoardName + "'" +
                        "(Name TEXT NOT NULL, " +
                        " PreviewBody TEXT NOT NULL," +
                        " FullBody TEXT," +
                        " Date TEXT," +
                        " Location INT," +
                        "PRIMARY KEY (Name))";
                CreateTable.Open();
                SetUpCommand.ExecuteNonQuery();
                CreateTable.Close();
            }
            else
            {

            }
        }

        private void lbToDoNoteNames_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbToDoNoteNames.SelectedIndex == -1)
            {
                btnEdit.Enabled = false;
                btnDelete.Enabled = false;
                btnMove.Enabled = false;
            }
            else
            {
                btnEdit.Enabled = true;
                btnDelete.Enabled = true;
                btnMove.Enabled = true;
            }
        }

        private void bsBoards_Load(object sender, EventArgs e)
        {
            bsBoards.Left.Click += bsLeft_Click;
            bsBoards.Right.Click += bsRight_Click;
            bsBoards.BoardName = BoardOpened;
        }
        private void bsLeft_Click(object sender, EventArgs e)
        {
            (DataRow[] rows, int i) = Class.DataRowReadBoard.FindBoardInDatabase(bsBoards.BoardName);
            try
            {
                bsBoards.BoardName = rows[i - 1]["name"].ToString();
            }
            catch
            {
                bsBoards.BoardName = rows[i = rows.Length-1]["name"].ToString();
            }
            lbToDoNoteNames.Items.Clear();
            Class.UpdateConfig.NewValue(bsBoards.BoardName, "BoardToOpen");
            GenerateListBoxEntries();
        }
        private void bsRight_Click(object sender, EventArgs e)
        {
            (DataRow[] rows, int i) = Class.DataRowReadBoard.FindBoardInDatabase(bsBoards.BoardName);
            try
            {
                bsBoards.BoardName = rows[i + 1]["name"].ToString();
            }
            catch
            {
                bsBoards.BoardName = rows[0]["name"].ToString();
            }
            lbToDoNoteNames.Items.Clear();
            Class.UpdateConfig.NewValue(bsBoards.BoardName, "BoardToOpen");
            GenerateListBoxEntries();
        }
    }
}

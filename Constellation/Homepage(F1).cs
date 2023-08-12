using Constellation.Controls;
using Constellation.Scripts;
using Constellation.UI;
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
using static System.ComponentModel.Design.ObjectSelectorEditor;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;


namespace Constellation
{
    public partial class Homepage_F1_ : Form
    {
        public string Action;
        public Homepage_F1_()
        {
            InitializeComponent();
        }
        public static Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
        public string Username;
        public bool Allow;
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
            if (SelectorForm_F5_.allow == true || Allow == true)
            {
                Board_F3_ Board = new Board_F3_();
                Board.FormClosed += Homepage_F1__Load;
                this.Hide();
                Board.Show();
            }
        }
        private void Settings_F2__FormClosed(object sender, EventArgs e)
        {
            this.Show();
            LoadColours();

        }
        private void Homepage_F1__Load(object sender, EventArgs e)
        {
            //form set up
            this.Show();
            this.Text = "Homepage";
            ToDo todo = new ToDo();
            todo.Dock = DockStyle.Fill;
            ComingUp comingUp = new ComingUp();
            comingUp.Dock = DockStyle.Fill;
            tlpRight.Controls.Clear();
            tlpRight.Controls.Add(todo);
            tlpRight.Controls.Add(comingUp);
            lblUsername.Text = Username;
            LoadPinnedBoards();
            LoadColours();
        }

        private void LoadPinnedBoards()
        {
            plQuickSelect.Controls.Clear();
            foreach (DataRow row in DataRowBoard.GetAllDatabaseBoards())
            {
                DataRow[] rows = DataRowNote.ReadSelectedBoardsNotes(row["name"].ToString());
                try
                {
                    if (rows[0]["PBoard"].ToString() == "1")
                    {
                        Button btn = new Button();
                        btn.Text = row["name"].ToString();
                        btn.Height = 31;
                        btn.Tag = "Secondary";
                        plQuickSelect.Controls.Add(btn);
                        btn.Dock = DockStyle.Top;
                        btn.Click += btnQuickBoard_Click;
                    }
                }
                catch
                {
                    continue;
                }
            }
            Class.LoadColours.SetColours(plQuickSelect, this);
        }

        private void btnQuickBoard_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            string BoardOpening = btn.Text;
            UpdateConfig.NewValue(BoardOpening, "BoardToOpen");
            Allow = true;
            Open_board(sender, e);

        }

        /// <summary>
        /// loads colours onto form controls
        /// </summary>
        private void LoadColours()
        {
            (int[] PrimaryButtonARGB, int[] SecondaryButtonARGB, int[] TextARGB, int[] BackgroundARGB, int[] TextBoxBackgroundARGB) = GetColours.ReadStringData(GetColours.ReadData());
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            this.BackColor = Color.FromArgb(BackgroundARGB[0], BackgroundARGB[1], BackgroundARGB[2], BackgroundARGB[3]);
            this.ForeColor = Color.FromArgb(TextARGB[0], TextARGB[1], TextARGB[2], TextARGB[3]);
            Control cn = this;
            cn = Class.LoadColours.SetColours(cn, this);
        }

        private void pbUserIcon_Click(object sender, EventArgs e)
        {

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
            string BoardName = Interaction.InputBox("Please enter name of the board you wish to create", "Board Creation", "");
            if (!string.IsNullOrEmpty(BoardName))
            {
                string Path = config.AppSettings.Settings["UserLoginLocation"].Value;
                BoardName = Setups.CreateBoard(BoardName, Path);
                Board_F3_ board_F3 = new Board_F3_();

            }
            else
            {

            }
        }

        private void Homepage_F1__Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized) 
            {
                NI.Visible = true;
            }
        }
    }
}

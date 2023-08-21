using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;
using System.Diagnostics;
using Microsoft.VisualBasic.Devices;
using System.Net.NetworkInformation;
using Constellation.Scripts;
using Constellation.UI;
using Microsoft.VisualBasic;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using System.Diagnostics.CodeAnalysis;

namespace Constellation
{
    public partial class Board_F3_ : Form
    {
        static class DataLocation
        {
            public static Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            public static string UserDataLocation = config.AppSettings.Settings["UserLoginLocation"].Value;
            public static string BoardOpened = config.AppSettings.Settings["BoardToOpen"].Value;
        }
        public string SelectedNote;
        public static string NoteName;
        public static int Create;
        public static string Action;
        public Board_F3_()
        {
            InitializeComponent();
        }
        private Point MouseDownLocation;
        Point ptOriginal = Point.Empty;
        private void Board_F3__Load(object sender, EventArgs e)
        {
            GenerateNotes(true);
            LoadColours();
        }
        private void LoadColours()
        {
            (int[] PrimaryButtonARGB, int[] SecondaryButtonARGB, int[] TextARGB, int[] BackgroundARGB, int[] TextBoxBackgroundARGB) = GetColours.ReadStringData(GetColours.ReadData());
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            this.BackColor = Color.FromArgb(BackgroundARGB[0], BackgroundARGB[1], BackgroundARGB[2], BackgroundARGB[3]);
            this.ForeColor = Color.FromArgb(TextARGB[0], TextARGB[1], TextARGB[2], TextARGB[3]);
            Control cn = tlpTopBar;
            cn = Class.LoadColours.SetColours(cn, this);
        }
        private void ClearNotes()
        {
            //clears all contros in all the pannels in notegrid
            foreach (Panel pl in ng.AllPanels)
            {
                pl.Controls.Clear();
            }
        }
        private void GenerateNotes(bool UA)
        {
            foreach (Panel pl in ng.AllPanels)
            {
                pl.Controls.Clear();

            }
            if (UA == true)
            {
                DataRow[] rows = DataRowNote.ReadCurrentBoardsNotes();
                bool create = true;
                int i = 0;
                NoteGrid ng = new NoteGrid();
                while (create == true)
                {
                    if (i >= rows.Length)
                    {
                        create = false;
                    }
                    else
                    {
                        //generates note data and puts in appropriate panel
                        Note nt = new Note();
                        nt.NoteName = rows[i]["Name"].ToString();
                        nt.TextPreview = rows[i]["PreviewBody"].ToString();
                        nt.AutoSize = true;
                        nt.AutoSizeMode = AutoSizeMode.GrowAndShrink;
                        nt.BackColor = SystemColors.ActiveCaption;
                        nt.Location = new Point(0, 0);
                        nt.Name = "Note" + i;
                        nt.Size = new Size(282, 125);
                        nt.Dock = DockStyle.Top;
                        nt.MouseDown += Note_MouseDown;
                        nt.btnExpand.Click += Note_ButtonClick;
                        nt.btnExpand.Tag = nt.NoteName;
                        nt.MouseMove += Note_MouseMove_1;
                        nt.MouseUp += Note_MouseUp;
                        nt.DoubleClick += Note_DoubleClick;
                        switch (rows[i]["Location"].ToString())
                        {
                            case "0":
                                this.ng.ToDoPanel.Controls.Add(nt);
                                break;
                            case "1":
                                this.ng.DoingPanel.Controls.Add(nt);
                                break;
                            case "2":
                                this.ng.DonePanel.Controls.Add(nt);
                                break;
                        }
                        i++;
                        nt.Show();
                    }
                }
                if (i == 0)
                {
                    btnPinBoard.Enabled = false;
                }
                else
                {
                    btnPinBoard.Enabled = true;
                }
            }
            else if (UA == false)
            {

                foreach (Panel pl in ng.AllPanels)
                {
                    foreach (Note nt in pl.Controls)
                    {
                        if (nt.NoteName == NoteName)
                        {
                            (DataRow[] rows, int i) = DataRowNote.FindInDataRowNote(NoteName);
                            nt.NoteName = rows[i]["Name"].ToString();
                            nt.TextPreview = rows[i]["PreviewBody"].ToString();
                        }
                    }
                }
            }

        }

        private void Note_DoubleClick(object sender, EventArgs e)
        {
            //when the note is double clicked make sure that
            //create = 1 so that form 4 knows that the note already has data
            //put note name into variale so that form 4 knows what note is being opened
            Note nt = (Note)sender;
            SelectedNote = nt.Name;
            Create = 1;
            NoteName = nt.NoteName.ToString();
            NoteExpanded_F4_ NoteExpanded = new NoteExpanded_F4_();
            NoteExpanded.Show();
            NoteExpanded.FormClosed += Form_Reload;
        }
        private void Note_ButtonClick(object sender, EventArgs e)
        {
            //when the note is double clicked make sure that
            //create = 1 so that form 4 knows that the note already has data
            //put note name into variale so that form 4 knows what note is being opened
            Button bt = (Button)sender;
            SelectedNote = bt.Parent.ToString();
            Create = 1;
            NoteName = bt.Tag.ToString();
            NoteExpanded_F4_ NoteExpanded = new NoteExpanded_F4_();
            NoteExpanded.Show();
            NoteExpanded.FormClosed += Form_Reload;
        }
        public void Form_Reload(object sender, EventArgs e)
        {
            //reloads the form by removing all notes and recreating them 
            GenerateNotes(true);
        }

        private void Note_MouseMove_1(object sender, MouseEventArgs e)
        {
            Note nt = (Note)sender;
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                nt.BringToFront();
                nt.Left = e.X + nt.Left - MouseDownLocation.X;
                nt.Top = e.Y + nt.Top - MouseDownLocation.Y;
            }
        }
        private void Note_MouseDown(object sender, MouseEventArgs e)
        {
            //when the mouse is pressed down it removes the note from all controls and adds it back to the form
            //while the mouse is down the note will follow the cursor 
            Note nt = (Note)sender;
            nt.Dock = DockStyle.None;
            foreach (Panel pl in ng.AllPanels)
            {
                pl.Controls.Remove(nt);
            }
            this.Controls.Add(nt);
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                MouseDownLocation = e.Location;
            }
        }
        private void Note_MouseUp(object sender, EventArgs e)
        {
            //if the note is touching any of the boards panels add the control to panel that the note is most over
            Note nt = (Note)sender;
            int location = 0;
            if (nt.Bounds.IntersectsWith(ng.ToDoPanel.Bounds))
            {
                location = 0;
                nt.Dock = DockStyle.Top;
                ng.ToDoPanel.Controls.Add(nt);
                UpdateLocation(nt, location);

            }
            if (nt.Bounds.IntersectsWith(ng.DoingPanel.Bounds))
            {
                location = 1;
                nt.Dock = DockStyle.Top;
                ng.DoingPanel.Controls.Add(nt);
                UpdateLocation(nt, location);

            }
            if (nt.Bounds.IntersectsWith(ng.DonePanel.Bounds))
            {
                location = 2;
                nt.Dock = DockStyle.Top;
                ng.DonePanel.Controls.Add(nt);
                UpdateLocation(nt, location);

            }
        }

        private void UpdateLocation(Note nt, int location)
        {
            //updates the Database location where the name is equal to the note name
            //the update changes where the Note is stored on the board
            (DataRow[] rows, int i) = DataRowNote.FindInDataRowNote(nt.NoteName);
            SQLiteConnection sqlconnection = new SQLiteConnection();
            SQLiteCommand sqlCommand = new SQLiteCommand();
            sqlconnection.ConnectionString = "DataSource = " + DataLocation.UserDataLocation;
            sqlCommand.CommandType = CommandType.Text;
            sqlCommand.Connection = sqlconnection;
            sqlCommand.CommandText = "UPDATE '" + DataLocation.BoardOpened + "'" +
                " SET Location = " + location +
                " WHERE Name = " + "'" + rows[i]["Name"].ToString() + "'";
            sqlconnection.Open();
            sqlCommand.ExecuteNonQuery();
            sqlconnection.Close();
        }

        private void btnAddNote_Click(object sender, EventArgs e)
        {
            NoteExpanded_F4_ NoteExpanded = new NoteExpanded_F4_();
            Create = 0;
            NoteExpanded.FormClosed += Form_Reload;
            NoteExpanded.Show();


        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure you want to close the application", "Conformation", MessageBoxButtons.YesNo);
            switch (dr)
            {
                case DialogResult.Yes:
                    Application.Exit();
                    break;

                case DialogResult.No:
                    break;
            }
        }

        private void btnDeleteNote_Click(object sender, EventArgs e)
        {
            string NoteName = Interaction.InputBox("Please enter name of the Note you wish to Delete\nThis action cannot be reverse", "Note Deletion", "");
            foreach (Panel pl in ng.AllPanels)
            {
                foreach (Note nt in pl.Controls.OfType<Note>())
                {
                    if (NoteName == nt.NoteName)
                    {
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
                        sqlCommand.CommandText = "DELETE FROM '" + PD.BoardOpened + "' WHERE Name = '" + NoteName + "'";
                        sqlconnection.Open();
                        sqlCommand.ExecuteNonQuery();
                        sqlconnection.Close();
                    }
                }
            }
            Form_Reload(sender, e);

        }

        private void btnPinBoard_Click(object sender, EventArgs e)
        {
            DataRow[] rows = DataRowNote.ReadCurrentBoardsNotes();
            if (rows[0]["PBoard"].ToString() == "0")
            {
                DialogResult dr = MessageBox.Show("Do you want to pin this board?", "Pin Board", MessageBoxButtons.YesNo);
                switch (dr)
                {
                    case DialogResult.Yes:
                        SQLiteConnection sqlconnection = new SQLiteConnection();
                        SQLiteCommand sqlCommand = new SQLiteCommand();
                        sqlconnection.ConnectionString = "DataSource = " + DataLocation.UserDataLocation;
                        sqlCommand.CommandType = CommandType.Text;
                        sqlCommand.Connection = sqlconnection;
                        sqlCommand.CommandText = "UPDATE '" + DataLocation.BoardOpened + "'" +
                            " SET PBoard = 1";
                        sqlconnection.Open();
                        sqlCommand.ExecuteNonQuery();
                        sqlconnection.Close();
                        break;

                    case DialogResult.No:
                        break;
                }
            }
            else
            {
                DialogResult dr = MessageBox.Show("Do you want to unpin this board?", "Pin Board", MessageBoxButtons.YesNo);
                switch (dr)
                {
                    case DialogResult.Yes:
                        SQLiteConnection sqlconnection = new SQLiteConnection();
                        SQLiteCommand sqlCommand = new SQLiteCommand();
                        sqlconnection.ConnectionString = "DataSource = " + DataLocation.UserDataLocation;
                        sqlCommand.CommandType = CommandType.Text;
                        sqlCommand.Connection = sqlconnection;
                        sqlCommand.CommandText = "UPDATE '" + DataLocation.BoardOpened + "'" +
                            " SET PBoard = 0";
                        sqlconnection.Open();
                        sqlCommand.ExecuteNonQuery();
                        sqlconnection.Close();
                        break;

                    case DialogResult.No:
                        break;
                }
            }

        }
    }
}

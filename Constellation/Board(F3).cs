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

namespace Constellation
{
    public partial class Board_F3_ : Form
    {
        public string SelectedNote;
        static class DataLocation
        {
            public static Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            public static string Location = config.AppSettings.Settings["UserLoginLocation"].Value;
        }
        public static string NoteName;
        public Board_F3_()
        {
            InitializeComponent();

        }
        private Point MouseDownLocation;
        Point ptOriginal = Point.Empty;
        private void Board_F3__Load(object sender, EventArgs e)
        {
            GenerateNotes();

        }
        private void ClearNotes()
        {
            //puts controls into array that are in the notegrid
            var ControlsToRemove = ng.AllPanels.Controls.OfType<Note>().ToArray();
            foreach (var Control in ControlsToRemove)
            {
                //removes the control and disposes them
                Controls.Remove(Control);
                Control.Dispose();
            }
        }
        private void GenerateNotes()
        {
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            var ConfigLocation = config.AppSettings.Settings["UserLoginLocation"].Value;
            SQLiteConnection sqlconnection = new SQLiteConnection();
            sqlconnection.ConnectionString = "DataSource = " + ConfigLocation;
            string commandText = "SELECT * FROM Board1";
            DataTable table = new DataTable();
            SQLiteDataAdapter myDataAdapter = new SQLiteDataAdapter(commandText, sqlconnection);
            sqlconnection.Open();
            myDataAdapter.Fill(table);
            //put all data from the database into datarow
            DataRow[] rows = table.Select();
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
                    nt.Size = new Size(250, 125);
                    nt.Dock = DockStyle.Top;
                    nt.Show();
                    nt.MouseDown += Note_MouseDown;
                    nt.MouseMove += Note_MouseMove_1;
                    nt.MouseUp += Note_MouseUp;
                    nt.DoubleClick += Note_DoubleClick;
                    
                    this.ng.ToDoPanel.Controls.Add(nt);
                    i++;
                }
            }
        }

        private void TLPDragEnter(object sender, DragEventArgs e)
        {

        }

        private void TLPDragDrop(object sender, DragEventArgs e)
        {

        }



        private void Panel_DragDrop(object sender, DragEventArgs e)
        {

        }
        private void Note_DoubleClick(object sender, EventArgs e)
        {
            Note nt = (Note)sender;
            SelectedNote = nt.Name;

            NoteName = nt.NoteName.ToString();
            NoteExpanded_F4_ NoteExpanded = new NoteExpanded_F4_();
            NoteExpanded.Show();
            NoteExpanded.FormClosed += Form_Reload;
        }
        private void Form_Reload(object sender, EventArgs e)
        {
            //reloads the form by removing all notes and recreating them 
            ClearNotes();
            GenerateNotes();
        }
        private void ReloadNote(object sender)
        {
            MessageBox.Show(sender.ToString());
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
            Note nt = (Note)sender;
            nt.Dock = DockStyle.None;
            ng.AllPanels.Controls.Remove(nt);
            this.Controls.Add(nt);
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                MouseDownLocation = e.Location;
            }





        }

        private void Note_MouseUp(object sender, EventArgs e)
        {
            Note nt = (Note)sender;
            if (nt.Bounds.IntersectsWith(ng.ToDoPanel.Bounds))
            {
                nt.Dock = DockStyle.Top;
                ng.ToDoPanel.Controls.Add(nt);
            }
            if (nt.Bounds.IntersectsWith(ng.DoingPanel.Bounds))
            {
                nt.Dock = DockStyle.Top;
                ng.DoingPanel.Controls.Add(nt);
            }
            if (nt.Bounds.IntersectsWith(ng.DonePanel.Bounds))
            {
                nt.Dock = DockStyle.Top;
                ng.DonePanel.Controls.Add(nt);
            }
        }


        public void AddNoteToNoteGrid(Note nt, NoteGrid ng)
        {

        }
        private void tlpBoard1_DragEnter(object sender, DragEventArgs e)
        {

        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }


    }
}

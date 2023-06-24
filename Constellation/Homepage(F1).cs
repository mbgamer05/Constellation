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
        public Homepage_F1_()
        {
            InitializeComponent();
        }
        public string BoardName;
        private void btnSettings_Click(object sender, EventArgs e)
        {
            Settings_F2_ settings = new Settings_F2_();
            settings.FormClosed += Settings_F2__FormClosed;
            this.Hide();
            settings.Show();
        }

        private void btnBoard_Click(object sender, EventArgs e)
        {
            Board_F3_ Board = new Board_F3_();
            Board.FormClosed += Board_F3__FormClosed;
            this.Hide();
            Board.Show();
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
            LoadColours();
            BoardName = "Board1";
            GenerateListBoxEntries();

        }

        private void GenerateListBoxEntries()
        {
            lbToDoNoteNames.HorizontalScrollbar = true;
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            var ConfigLocation = config.AppSettings.Settings["UserLoginLocation"].Value;
            SQLiteConnection sqlconnection = new SQLiteConnection();
            sqlconnection.ConnectionString = "DataSource = " + ConfigLocation;
            string commandText = "SELECT * FROM " + BoardName;
            DataTable table = new DataTable();
            SQLiteDataAdapter myDataAdapter = new SQLiteDataAdapter(commandText, sqlconnection);
            sqlconnection.Open();
            myDataAdapter.Fill(table);
            //put all data from the database into datarow
            DataRow[] rows = table.Select();
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
            sqlconnection.Close();
        }

        private void LoadColours()
        {
            (int[] PrimaryButtonARGB, int[] SecondaryButtonARGB, int[] TextARGB, int[] BackgroundARGB, int[] TextBoxBackgroundARGB) = MoreSettings.ReadStringData(MoreSettings.ReadData());
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            this.BackColor = Color.FromArgb(BackgroundARGB[0], BackgroundARGB[1], BackgroundARGB[2], BackgroundARGB[3]);
            this.ForeColor = Color.FromArgb(TextARGB[0], TextARGB[1], TextARGB[2], TextARGB[3]);
            foreach (Panel pn in this.Controls.OfType<Panel>())
            {
                foreach (Button bn in pn.Controls.OfType<Button>())
                {
                    if (bn.Tag.Equals("Primary"))
                    {
                        bn.BackColor = Color.FromArgb(PrimaryButtonARGB[1], PrimaryButtonARGB[2], PrimaryButtonARGB[3]);
                        bn.FlatStyle = FlatStyle.Popup;
                        bn.FlatAppearance.BorderSize = 0;
                        bn.FlatAppearance.BorderColor = Color.FromArgb(PrimaryButtonARGB[1], PrimaryButtonARGB[2], PrimaryButtonARGB[3]);
                        bn.ForeColor = this.ForeColor;
                    }
                    else
                    {
                        bn.BackColor = Color.FromArgb(SecondaryButtonARGB[0], SecondaryButtonARGB[1], SecondaryButtonARGB[2], SecondaryButtonARGB[3]);
                        bn.FlatStyle = FlatStyle.Popup;
                        bn.FlatAppearance.BorderSize = 0;
                        bn.FlatAppearance.BorderColor = Color.FromArgb(SecondaryButtonARGB[1], SecondaryButtonARGB[2], SecondaryButtonARGB[3]);
                        bn.ForeColor = this.ForeColor;
                    }
                }
                foreach (TextBox tb in this.Controls.OfType<TextBox>())
                {
                    tb.BackColor = Color.FromArgb(TextBoxBackgroundARGB[0], TextBoxBackgroundARGB[1], TextBoxBackgroundARGB[2], TextBoxBackgroundARGB[3]);
                    tb.ForeColor = this.ForeColor;
                }
            }

        }

        private void pbUserIcon_Click(object sender, EventArgs e)
        {

        }

        private void btnMove_Click(object sender, EventArgs e)
        {

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Board_F3_.NoteName = lbToDoNoteNames.SelectedItem.ToString();
            Board_F3_.Create = 1;
            NoteExpanded_F4_ NoteExpanded = new NoteExpanded_F4_();
            NoteExpanded.Show();
            NoteExpanded.FormClosed += Form_Reload;
        }
        private void Form_Reload(object sender, EventArgs e)
        {
            lbToDoNoteNames.Items.Clear();
            GenerateListBoxEntries();
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {

        }
    }
}

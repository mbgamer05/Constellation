using Constellation.Scripts;
using Constellation.UI;
using Microsoft.VisualBasic;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using System.Diagnostics.Tracing;
using System.Drawing;
using System.Drawing.Text;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Constellation
{
    public partial class Settings_F2_ : Form
    {
        static string FolderPath = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
        static string OptionsPath = FolderPath + "\\Constellation\\\\Options.ini";
        private string FileCreatePath = FolderPath + "\\Constellation";
        Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
        public string ColourSelected = "Preview1";
        List<string> ColourList = new List<string>();


        public Settings_F2_()
        {
            InitializeComponent();
            InstalledFontCollection foundfonts = new InstalledFontCollection();
            FontFamily[] font = foundfonts.Families.ToArray();
            int i = 0;
            foreach (FontFamily family in font)
            {
                combFont.Items.Add(font[i].Name);
                i++;
            }
            combFont.SelectedIndex = 0;
            var ConfigFont = config.AppSettings.Settings["FontType"].Value;
            this.Font = new Font(ConfigFont, this.Font.Size);

        }

        private void cbStartUp_CheckedChanged(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader(OptionsPath);
            RegistryKey rk = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true);
            string line = sr.ReadLine();
            sr.Close();
            StreamWriter sw = new StreamWriter(OptionsPath);
            if (cbStartUp.Checked)
            {
                rk.SetValue("Constellation", Application.ExecutablePath);
                sw.WriteLine("Startup = True");
            }
            if (!cbStartUp.Checked)
            {
                rk.DeleteValue("Constellation", throwOnMissingValue: false);
                sw.WriteLine("Startup = False");
            }
            sw.Close();
        }

        private void combFont_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Settings_F2__Load(object sender, EventArgs e)
        {
            DataRow[] rows = DataRowBoard.GetAllDatabaseColours();
            foreach (DataRow row in rows)
            {
                cbColourScheme.Items.Add(row["name"]);
            }
            LoadColours();
            string documents = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            string[] paths = new string[2] { documents, "Constellation" };
            string folderPath = Path.Combine(paths);
            try
            {
                StreamReader sr = new StreamReader(OptionsPath);
                string line = sr.ReadLine();
                sr.Close();
                if (string.IsNullOrEmpty(line))
                {
                    StreamWriter sw2 = new StreamWriter(OptionsPath);
                    sw2.WriteLine("Startup = False");
                    sw2.Close();
                    cbStartUp.Checked = false;
                }
                if (line.Contains("True"))
                {
                    cbStartUp.Checked = true;
                }
                if (line.Contains("False"))
                {
                    cbStartUp.Checked = false;
                }
            }
            catch
            {
                Directory.CreateDirectory(folderPath);
                StreamWriter sw = new StreamWriter(OptionsPath);
                sw.WriteLine("temp");
                sw.Close();
            }
            string newfont = ConfigurationManager.AppSettings["FontType"];
            Font font = (Font = new Font(newfont, 9f));

            string colour = ConfigurationManager.AppSettings["ColourScheme"];
            switch (colour)
            {
                case "Preview1":
                    rbSchemeOne.Checked = true;
                    break;

                case "Preview2":
                    rbSchemeTwo.Checked = true;
                    break;

                case "Preview3":
                    rbSchemeThree.Checked = true;
                    break;

                default:
                    cbColourScheme.Text = colour;
                    break;

            }
            string QuickClose = ConfigurationManager.AppSettings["QuickClose"];
            switch (QuickClose)
            {
                case "True":
                    cbQuickClose.Checked = true;
                    break;
                case "False":
                    cbQuickClose.Checked = false;
                    break;
            }
            
        }
        public void LoadColours()
        {
            (int[] PrimaryButtonARGB, int[] SecondaryButtonARGB, int[] TextARGB, int[] BackgroundARGB, int[] TextBoxBackgroundARGB) = GetColours.ReadStringData(GetColours.ReadData());
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            this.BackColor = Color.FromArgb(BackgroundARGB[0], BackgroundARGB[1], BackgroundARGB[2], BackgroundARGB[3]);
            this.ForeColor = Color.FromArgb(TextARGB[0], TextARGB[1], TextARGB[2], TextARGB[3]);
            Control cn = this;
            cn = Class.LoadColours.SetColours(cn, this);
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private int[] ChangeColor(string input)
        {
            string temp = input;
            int[] output = new int[4];
            int j = 0;
            foreach (string r in temp.Split(","))
            {
                output[j] = int.Parse(r);
                j++;
            }
            return output;
        }
        private void btnPrimaryColour_Click(object sender, EventArgs e)
        {
            if (ColourD.ShowDialog() == DialogResult.OK)
            {
                string PrimaryButtonColour =FindARGBValues();
                ColourList.Insert(0,PrimaryButtonColour);
                ChangeColor(FindARGBValues());
                int[] NewColour = ChangeColor(FindARGBValues());
                btnPrimary.BackColor = Color.FromArgb(NewColour[0], NewColour[1], NewColour[2], NewColour[3]);
            }
        }

        private string FindARGBValues()
        {
            var cn = ColourD.Color;
            cn = Color.FromArgb(cn.ToArgb());
            string colorname = ColourD.Color.ToString();
            string BSplit = cn.ToString().Replace("[", "").Replace("]", "").Replace("Color", ",");
            string[] temp = BSplit.Split(",");
            string StringToRemove = "";
            temp = temp.Where(val => val != StringToRemove).ToArray();
            int i = 0;
            string ARGBValues = "";
            foreach (var s in temp)
            {
                temp[i] = temp[i][3..];
                ARGBValues = ARGBValues + temp[i] + ",";
                i++;
            }
            ARGBValues = ARGBValues.Remove(ARGBValues.Length - 1);
            return ARGBValues;

        }

        private void btnSecondaryColour_Click(object sender, EventArgs e)
        {
            if (ColourD.ShowDialog() == DialogResult.OK)
            {
                string SecondaryButtonColour = FindARGBValues();
                ColourList.Insert(1, SecondaryButtonColour);
                int[] NewColour = ChangeColor(SecondaryButtonColour);
                btnSecondary.BackColor = Color.FromArgb(NewColour[0], NewColour[1], NewColour[2], NewColour[3]);
            }
        }

        private void btnBackgroundColour_Click(object sender, EventArgs e)
        {
            if (ColourD.ShowDialog() == DialogResult.OK)
            {
                string BackgroundColour = FindARGBValues();
                ColourList.Insert(2, BackgroundColour);
                int[] NewColour = ChangeColor(BackgroundColour);
                panelPreview.BackColor = Color.FromArgb(NewColour[0], NewColour[1], NewColour[2], NewColour[3]);
            }
        }

        private void btnTextColour_Click(object sender, EventArgs e)
        {
            if (ColourD.ShowDialog() == DialogResult.OK)
            {
                string TextColourColour = FindARGBValues();
                ColourList.Insert(3, TextColourColour);
                int[] NewColour = ChangeColor(TextColourColour);
                txtPreview.ForeColor = Color.FromArgb(NewColour[0], NewColour[1], NewColour[2], NewColour[3]);
            }
        }

        private void btnTextboxBackgroundColour_Click(object sender, EventArgs e)
        {
            if (ColourD.ShowDialog() == DialogResult.OK)
            {
                string TextBoxBackgroundColour = FindARGBValues();
                ColourList.Insert(4, TextBoxBackgroundColour);
                int[] NewColour = ChangeColor(TextBoxBackgroundColour);
                txtPreview.BackColor = Color.FromArgb(NewColour[0], NewColour[1], NewColour[2], NewColour[3]);
            }
        }

        private void rbSchemeOne_CheckedChanged(object sender, EventArgs e)
        {
            ColourSelected = "Preview1";

        }

        private void rbSchemeTwo_CheckedChanged(object sender, EventArgs e)
        {
            ColourSelected = "Preview2";
        }

        private void rbSchemeThree_CheckedChanged(object sender, EventArgs e)
        {
            ColourSelected = "Preview3";
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            int clear = 0;
            foreach (var item in ColourList)
            {
                if (item != string.Empty)
                {
                    clear++;
                }
            }
            if (clear == 5)
            {
                string ColourName = Interaction.InputBox("please enter name for colour scheme", "scheme creation", "");
                string[] colourpathFind = new string[2] { FileCreatePath, "Colour" };
                string ColourPath = Path.Combine(colourpathFind) + ".db";
                SQLiteConnection ColourConnection = new SQLiteConnection();
                ColourConnection.ConnectionString = "DataSource = " + ColourPath;
                SQLiteCommand ColourAddCommand = new SQLiteCommand();
                ColourAddCommand.Connection = ColourConnection;
                ColourAddCommand.CommandType = CommandType.Text;
                ColourAddCommand.CommandText = "CREATE TABLE '" + ColourName +
                    "' (PrimaryButton TEXT," +
                    " SecondaryButton TEXT," +
                    " BackgroundColour TEXT," +
                    " TextColour TEXT," +
                    "TextboxBackgroundColour TEXT)";
                ColourConnection.Open();
                ColourAddCommand.ExecuteNonQuery();
                ColourConnection.Close();
                ColourAddCommand.CommandText = "INSERT INTO '" + ColourName +
                    "' (PrimaryButton, SecondaryButton, BackgroundColour, TextColour,TextboxBackgroundColour)" +
                    " Values (@PB, @SB, @BC, @TC, @TBC)";
                ColourAddCommand.Parameters.AddWithValue("@PB", ColourList[0]);
                ColourAddCommand.Parameters.AddWithValue("@SB", ColourList[1]);
                ColourAddCommand.Parameters.AddWithValue("@BC", ColourList[2]);
                ColourAddCommand.Parameters.AddWithValue("@TC", ColourList[3]);
                ColourAddCommand.Parameters.AddWithValue("@TBC", ColourList[4]);
                ColourConnection.Open();
                ColourAddCommand.ExecuteNonQuery();
                ColourConnection.Close();
            }
            DialogResult dr = MessageBox.Show("are you sure you want to do this", "Confirmation", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                //puts the selected font into the app configuration
                Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                config.AppSettings.Settings["FontType"].Value = combFont.Text;
                config.Save(ConfigurationSaveMode.Modified);
                ConfigurationManager.RefreshSection("appSettings");
                //sets colour scheme
                config.AppSettings.Settings["ColourScheme"].Value = ColourSelected;
                config.Save(ConfigurationSaveMode.Modified);
                ConfigurationManager.RefreshSection("appSettings");
                //writes the current user into the config file
                MessageBox.Show("Applying changes");
                LoadColours();
            }
            else
            {
            }
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("You have unsaved changes you sure you want to close", "Closing", MessageBoxButtons.YesNo);

            if (dr == DialogResult.Yes)
            {
                this.Close();
            }
            if (dr == DialogResult.No)
            {

            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbQuickClose_CheckedChanged(object sender, EventArgs e)
        {
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            config.AppSettings.Settings["QuickClose"].Value = cbQuickClose.Checked.ToString();
            config.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection("appSettings");
        }

        private void cbColourScheme_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (RadioButton rb in Graphics.Controls.OfType<RadioButton>())
            {
                rb.Checked = false;
            }
            ColourSelected = cbColourScheme.SelectedItem.ToString();
        }
    }
}

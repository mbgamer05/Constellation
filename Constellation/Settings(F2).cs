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
        Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
        public string PreviewFont = "Preview1";
        List<string> ColourList = new List<string>();


        public Settings_F2_()
        {
            MoreSettings MS = new MoreSettings();
            InitializeComponent();
            InstalledFontCollection foundfonts = new InstalledFontCollection();
            FontFamily[] font = foundfonts.Families.ToArray();
            int i = 0;
            foreach (FontFamily family in font)
            {
                combFont.Items.Add(font[i].Name);
                i++;
            }

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

        }
        public void LoadColours()
        {
            (int[] PrimaryButtonARGB, int[] SecondaryButtonARGB, int[] TextARGB, int[] BackgroundARGB, int[] TextBoxBackgroundARGB) = MoreSettings.ReadStringData(MoreSettings.ReadData());
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            Graphics.BackColor = Color.FromArgb(BackgroundARGB[0], BackgroundARGB[1], BackgroundARGB[2], BackgroundARGB[3]);
            Graphics.ForeColor = Color.FromArgb(TextARGB[0], TextARGB[1], TextARGB[2], TextARGB[3]);
            foreach (TabPage tp in tcSettings.TabPages)
            {
                foreach (Button bn in tp.Controls.OfType<Button>())
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
                foreach (TextBox tb in tp.Controls.OfType<TextBox>())
                {
                    tb.BackColor = Color.FromArgb(TextBoxBackgroundARGB[0], TextBoxBackgroundARGB[1], TextBoxBackgroundARGB[2], TextBoxBackgroundARGB[3]);
                    tb.ForeColor = this.ForeColor;
                }
            }

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnPrimaryColour_Click(object sender, EventArgs e)
        {
            if (ColourD.ShowDialog() == DialogResult.OK)
            {


                string PrimaryButtonColour = FindARGBValues();
                ColourList.Add(PrimaryButtonColour);
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
                ARGBValues = ARGBValues + temp[i] +",";
                i++;
            }
            
            return ARGBValues;
            
        }

        private void btnSecondaryColour_Click(object sender, EventArgs e)
        {
            if (ColourD.ShowDialog() == DialogResult.OK)
            {
                string SecondaryButtonColour = FindARGBValues();
                ColourList.Add(SecondaryButtonColour);

            }
        }

        private void btnBackgroundColour_Click(object sender, EventArgs e)
        {
            if (ColourD.ShowDialog() == DialogResult.OK)
            {
                string BackgroundColour = FindARGBValues();
                ColourList.Add(BackgroundColour);
            }
        }

        private void btnTextColour_Click(object sender, EventArgs e)
        {
            if (ColourD.ShowDialog() == DialogResult.OK)
            {
                string TextColourColour = FindARGBValues();
                ColourList.Add(TextColourColour);
            }
        }

        private void btnTextboxBackgroundColour_Click(object sender, EventArgs e)
        {
            if (ColourD.ShowDialog() == DialogResult.OK)
            {
                string TextBoxBackgroundColour = FindARGBValues();
                ColourList.Add(TextBoxBackgroundColour);
            }
        }

        private void rbSchemeOne_CheckedChanged(object sender, EventArgs e)
        {
            PreviewFont = "Preview1";

        }

        private void rbSchemeTwo_CheckedChanged(object sender, EventArgs e)
        {
            PreviewFont = "Preview2";
        }

        private void rbSchemeThree_CheckedChanged(object sender, EventArgs e)
        {
            PreviewFont = "Preview3";

        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("are you sure you want to do this", "Confirmation", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                //puts the selected font into the app configuration
                Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                config.AppSettings.Settings["FontType"].Value = combFont.Text;
                config.Save(ConfigurationSaveMode.Modified);
                ConfigurationManager.RefreshSection("appSettings");
                //sets colour scheme
                config.AppSettings.Settings["ColourScheme"].Value = PreviewFont;
                config.Save(ConfigurationSaveMode.Modified);
                ConfigurationManager.RefreshSection("appSettings");
                //writes the current user into the config file
                MessageBox.Show("The application will restart soon");
                //restarts application
                Application.Restart();
            }
            else
            {
                MessageBox.Show("ok");
            }
        }
    }
}

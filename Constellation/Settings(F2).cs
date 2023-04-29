using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
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
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            var ConfigFont = config.AppSettings.Settings["FontType"].Value;
            this.Font = new Font(ConfigFont, this.Font.Size);
        }

        private void cbStartUp_CheckedChanged(object sender, EventArgs e)
        {
            //when the checkbox state is changed it rewrites to the file
            StreamReader sr = new StreamReader("Options.ini");
            RegistryKey rk = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
            string line = sr.ReadLine();
            sr.Close();
            StreamWriter sw = new StreamWriter("Options.ini");
            if (cbStartUp.Checked == true)
            {       
                rk.SetValue("Constellation", Application.ExecutablePath);
                sw.WriteLine("Startup = True");
            }
            if (cbStartUp.Checked == false)
            {
                rk.DeleteValue("Constellation", false);
                sw.WriteLine("Startup = False");
            }
            sw.Close();
        }
        private void combFont_SelectedIndexChanged(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("are you sure  you want to do this", "Confirmation", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                config.AppSettings.Settings["FontType"].Value = combFont.Text;
                config.Save(ConfigurationSaveMode.Modified);
                ConfigurationManager.RefreshSection("appSettings");

                MessageBox.Show("The application will restart soon");
                StreamWriter sw = new StreamWriter("State.txt");
                sw.WriteLine("State = SettingsForm");
                sw.Close();
                Application.Restart();
            }
            else
            {
                MessageBox.Show("ok");
            }
        }

        private void Settings_F2__Load(object sender, EventArgs e)
        {
            //checks if file exists and reads what state it is in to change the checkboxes state
            if (File.Exists("Options.ini"))
            {
                StreamReader sr = new StreamReader("Options.ini");
                string line = sr.ReadLine();
                sr.Close();
                if (string.IsNullOrEmpty(line))
                {
                    StreamWriter sw = new StreamWriter("Options.ini");
                    sw.WriteLine("Startup = False");
                    sw.Close();
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
            else
            {
                File.Create("Options.ini");
                StreamWriter sw = new StreamWriter("Options.ini");
                sw.WriteLine("Startup = False");
                sw.Close();
            }
            var newfont = ConfigurationManager.AppSettings["FontType"];
            Font font = new Font(newfont, 9);
            this.Font = font;

        }
    }
}

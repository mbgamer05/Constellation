using System.Configuration;
using System.Data;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Linq.Expressions;
using Microsoft.VisualBasic;
using System.Security.Cryptography.X509Certificates;
using System;
using System.Runtime.CompilerServices;

namespace Constellation
{
    public partial class Form1 : Form
    {
        private static string FolderPath = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
        private static string FileCreatePath = FolderPath + "\\Constellation";
        static Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
        public static PublicData PD = new PublicData();

        public Form1()
        {
            InitializeComponent();
            var ConfigFont = config.AppSettings.Settings["FontType"].Value;
            this.Font = new Font(ConfigFont, this.Font.Size);
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            string[] colourpathFind = new string[2] { FileCreatePath, "Colour" };
            string ColourPath = Path.Combine(colourpathFind) + ".db";
            if (!File.Exists(FileCreatePath))
            {
                MessageBox.Show("Creating directory for application");
                Directory.CreateDirectory(FileCreatePath);
            }
            if (!File.Exists(ColourPath))
            {
                    SQLiteConnection.CreateFile(ColourPath);
                    for (int i = 1; i < 4; i++)
                    {
                        SQLiteConnection NewDatabaseConnection = new SQLiteConnection();
                        NewDatabaseConnection.ConnectionString = "DataSource = " + ColourPath;
                        SQLiteCommand SetUpCommand = new SQLiteCommand();
                        SetUpCommand.Connection = NewDatabaseConnection;
                        SetUpCommand.CommandType = CommandType.Text;
                        SetUpCommand.CommandText = "CREATE TABLE Preview" + i +
                        "(PrimaryButton TEXT," +
                        " SecondaryButton TEXT," +
                        " BackgroundColour TEXT," +
                        " TextColour TEXT," +
                        "TextboxBackgroundColour TEXT)";
                        NewDatabaseConnection.Open();
                        SetUpCommand.ExecuteNonQuery();
                        NewDatabaseConnection.Close();
                    }
                    if (File.Exists(ColourPath))
                    {
                        MessageBox.Show("Preview Colours made");
                        SQLiteConnection NewDatabaseConnection = new SQLiteConnection();
                        NewDatabaseConnection.ConnectionString = "DataSource = " + ColourPath;
                        SQLiteCommand SetUpCommand = new SQLiteCommand();
                        SetUpCommand.Connection = NewDatabaseConnection;
                        SetUpCommand.CommandText = "INSERT INTO Preview1 " +
                        "(PrimaryButton, SecondaryButton, BackgroundColour, TextColour,TextboxBackgroundColour)" +
                        " Values (@PB, @SB, @BC, @TC, @TBC)";
                        SetUpCommand.Parameters.AddWithValue("@PB", "255, 219, 80, 6");
                        SetUpCommand.Parameters.AddWithValue("@SB", "255, 180, 228, 253");
                        SetUpCommand.Parameters.AddWithValue("@BC", "255, 210, 239, 254");
                        SetUpCommand.Parameters.AddWithValue("@TC", "255, 1, 16, 25");
                        SetUpCommand.Parameters.AddWithValue("@TBC", "255, 199, 228, 242");
                        NewDatabaseConnection.Open();
                        SetUpCommand.ExecuteNonQuery();
                        NewDatabaseConnection.Close();

                        SetUpCommand.CommandText = "INSERT INTO Preview2 " +
                        "(PrimaryButton, SecondaryButton, BackgroundColour, TextColour,TextboxBackgroundColour)" +
                        " Values (@PB, @SB, @BC, @TC, @TBC)";
                        SetUpCommand.Parameters.AddWithValue("@PB", "255, 108, 140, 105");
                        SetUpCommand.Parameters.AddWithValue("@SB", "255, 251, 249, 251");
                        SetUpCommand.Parameters.AddWithValue("@BC", "255, 242, 238, 242");
                        SetUpCommand.Parameters.AddWithValue("@TC", "255, 6, 4, 6");
                        SetUpCommand.Parameters.AddWithValue("@TBC", "255, 230, 226, 230");
                        NewDatabaseConnection.Open();
                        SetUpCommand.ExecuteNonQuery();
                        NewDatabaseConnection.Close();

                        SetUpCommand.CommandText = "INSERT INTO Preview3 " +
                        "(PrimaryButton, SecondaryButton, BackgroundColour, TextColour,TextboxBackgroundColour)" +
                        " Values (@PB, @SB, @BC, @TC, @TBC)";
                        SetUpCommand.Parameters.AddWithValue("@PB", "255, 204, 197, 133");
                        SetUpCommand.Parameters.AddWithValue("@SB", "255, 44, 20, 47");
                        SetUpCommand.Parameters.AddWithValue("@BC", "255, 24, 11, 25");
                        SetUpCommand.Parameters.AddWithValue("@TC", "255, 240, 223, 241");
                        SetUpCommand.Parameters.AddWithValue("@TBC", "255, 35, 21, 36");
                        NewDatabaseConnection.Open();
                        SetUpCommand.ExecuteNonQuery();
                        NewDatabaseConnection.Close();
                    }
                
            }
            if (File.Exists(ColourPath))
            {
                string findit = config.AppSettings.Settings["ColourScheme"].Value;
                if (string.IsNullOrEmpty(findit))
                {
                    config.AppSettings.Settings["ColourScheme"].Value = "Preview1";
                    config.Save(ConfigurationSaveMode.Modified);
                    ConfigurationManager.RefreshSection("appSettings");

                }
                LoadColours();
            }
            string[] paths = new string[2] { FileCreatePath, "Main" };
            string comPaths = Path.Combine(paths) + ".db";
            if (!File.Exists(comPaths))
            {
                SQLiteConnection.CreateFile(comPaths);
                SQLiteConnection NewDatabaseConnection = new SQLiteConnection();
                NewDatabaseConnection.ConnectionString = "DataSource = " + comPaths;
                SQLiteCommand SetUpCommand = new SQLiteCommand();
                SetUpCommand.Connection = NewDatabaseConnection;
                SetUpCommand.CommandType = CommandType.Text;
                SetUpCommand.CommandText = "CREATE TABLE Users" +
                    "(ID INTEGER NOT NULL UNIQUE," +
                    "Username TEXT NOT NULL UNIQUE," +
                    "Password TEXT NOT NULL," +
                    "PRIMARY KEY (ID AUTOINCREMENT))";
                NewDatabaseConnection.Open();
                SetUpCommand.ExecuteNonQuery();
                NewDatabaseConnection.Close();
                MessageBox.Show("created user database");

            }
            config.AppSettings.Settings["UserLocation"].Value = comPaths;
            config.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection("appSettings");
        }

        private void LoadColours()
        {
            (int[] PrimaryButtonARGB, int[] SecondaryButtonARGB, int[] TextARGB, int[] BackgroundARGB, int[] TextBoxBackgroundARGB) = MoreSettings.ReadStringData(MoreSettings.ReadData());
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            this.BackColor = Color.FromArgb(BackgroundARGB[0], BackgroundARGB[1], BackgroundARGB[2], BackgroundARGB[3]);
            this.ForeColor = Color.FromArgb(TextARGB[0], TextARGB[1], TextARGB[2], TextARGB[3]);
            foreach (Control cn in this.Controls)
            {
                foreach (Button bn in this.Controls.OfType<Button>())
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

        private void Settings_F2__Load(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            string[] Userdata = new string[2];
            Userdata[0] = txtUsername.Text;
            Userdata[1] = txtPassword.Text;
            SQLiteConnection sqlconnection = new SQLiteConnection();
            sqlconnection.ConnectionString = "DataSource = " + PD.UserLocation;
            SQLiteCommand sqlCommand = new SQLiteCommand();
            sqlCommand.Connection = sqlconnection;
            sqlCommand.CommandType = CommandType.Text;
            sqlCommand.CommandText = "INSERT INTO Users (Username,Password) Values (@Username, @Password)";
            sqlCommand.Parameters.AddWithValue("@Username", Userdata[0]);
            sqlCommand.Parameters.AddWithValue("@Password", Userdata[1]);
            sqlconnection.Open();
            sqlCommand.ExecuteNonQuery();
            sqlconnection.Close();

            //Gets the user ID and encrypts the data
            string IDFind = ReadDataID(Userdata);
            string encodedFileName = Convert.ToBase64String(Encoding.UTF8.GetBytes(Userdata[0]));
            string encodedFileNameFull = encodedFileName.Replace('/', '-');
            string fileName = IDFind + encodedFileNameFull;
            string[] paths = new string[2] { FileCreatePath, fileName };
            string DatabasePath = Path.Combine(paths) + ".db";

            //checks if password exists
            if (File.Exists(DatabasePath))
            {
                MessageBox.Show("hmm seems like the user already exists please login");
                return;
            }
            else
            {
                CreateDatabase(DatabasePath);
                AllowUserIn(DatabasePath);
            }
        }

        private static void CreateDatabase(string DatabasePath)
        {
            //creates database
            SQLiteConnection.CreateFile(DatabasePath);
            SQLiteConnection NewDatabaseConnection = new SQLiteConnection();
            NewDatabaseConnection.ConnectionString = "DataSource = " + DatabasePath;
            SQLiteCommand SetUpCommand = new SQLiteCommand();
            SetUpCommand.Connection = NewDatabaseConnection;
            SetUpCommand.CommandType = CommandType.Text;
            //creates sample table
            SetUpCommand.CommandText = "CREATE TABLE Board1" +
                "(Name TEXT NOT NULL," +
                "PreviewBody TEXT NOT NULL," +
                "FullBody TEXT," +
                "Date TEXT," +
                "Location INT," +
                "PRIMARY KEY (Name))";
            NewDatabaseConnection.Open();
            SetUpCommand.ExecuteNonQuery();
            NewDatabaseConnection.Close();
            //checks if database exists 
            if (File.Exists(DatabasePath))
            {
                MessageBox.Show("Database created");
                for (int i = 0; i < 3; i++)
                {
                    //puts sample data into database
                    SetUpCommand.CommandText = "INSERT INTO Board1 " +
                    "(Name, PreviewBody, FullBody, Date, Location)" +
                    " Values (@Name, @PreviewBody, @FullBody, @Date, @Location)";
                    SetUpCommand.Parameters.AddWithValue("@Name", "Note " + (i + 1));
                    SetUpCommand.Parameters.AddWithValue("@PreviewBody", "Preview data is shown here it's a small blurb about you note");
                    SetUpCommand.Parameters.AddWithValue("@FullBody", "data shown here is bigger and larger than the preview message, this is great for large projects where you need to write down what you need to do,\n also the date stamp is when the idea/work needs to be done by");
                    SetUpCommand.Parameters.AddWithValue("@Date", DateTime.Today.AddDays(7));
                    SetUpCommand.Parameters.AddWithValue("@Location", i);
                    NewDatabaseConnection.Open();
                    SetUpCommand.ExecuteNonQuery();
                    NewDatabaseConnection.Close();
                }
            }
            else
            {
                MessageBox.Show("user not created\n" +
                    "an error occured please check the help button(Coming soon) for possible fixes");
            }
        }
        private static string ReadDataID(string[] Userdata)
        {
            SQLiteConnection sqlconnection = new SQLiteConnection();
            sqlconnection.ConnectionString = "DataSource = " + PD.UserLocation;
            string commandText = "SELECT * FROM Users";
            DataTable table = new DataTable();
            SQLiteDataAdapter myDataAdapter = new SQLiteDataAdapter(commandText, sqlconnection);
            sqlconnection.Open();
            myDataAdapter.Fill(table);
            //put all data from the database into datarow
            DataRow[] rows = table.Select();
            int i = 0;
            bool found = false;
            //search datarow until the usernames match
            while (!found)
            {
                if (rows[i]["Username"].ToString() == Userdata[0])
                {
                    found = true;
                }
                else
                {
                    i++;
                }
            }
            //return ID of the username location
            string ToCreate = rows[i]["ID"].ToString();
            sqlconnection.Close();
            return ToCreate;
        }
        private static string ReadDataPass(string[] Userdata)
        {
            SQLiteConnection sqlconnection = new SQLiteConnection();
            sqlconnection.ConnectionString = "DataSource = " + PD.UserLocation;
            string commandText = "SELECT * FROM Users";
            DataTable table = new DataTable();
            SQLiteDataAdapter myDataAdapter = new SQLiteDataAdapter(commandText, sqlconnection);
            sqlconnection.Open();
            myDataAdapter.Fill(table);
            //put all data from the database into datarow
            DataRow[] rows = table.Select();
            int i = 0;
            bool found = false;
            //search datarow until the usernames match and passwords match
            while (!found)
            {
                try
                {
                    if (rows[i]["Password"].ToString() == Userdata[1] && rows[i]["Username"].ToString() == Userdata[0])
                    {
                        found = true;
                    }
                    else
                    {
                        i++;
                    }
                }
                catch
                {
                    string fail = "failed";
                    return fail;
                }
            }
            //return password
            string ToPassword = rows[i]["Password"].ToString();
            sqlconnection.Close();
            return ToPassword;
        }


        private void btnLogin_Click(object sender, EventArgs e)
        {

            string[] Userdata = new string[2];
            Userdata[0] = txtUsername.Text;
            Userdata[1] = txtPassword.Text;
            string[] array = Userdata;
            //checks if inputs are not empty
            foreach (string s in array)
            {
                if (string.IsNullOrEmpty(s))
                {
                    MessageBox.Show("please fill in all boxes");
                    return;
                }
            }
            //attempts login by check username and password
            string PasswordToFind = ReadDataPass(Userdata);
            MessageBox.Show("attempting login");
            if (PasswordToFind.Contains("failed"))
            {
                MessageBox.Show("couldn't find a username or password are you sure you have made an account?\n" +
                    "maybe make sure you're putting the right username and passwords in");
            }
            else if (Userdata[1] == PasswordToFind)
            {
                //logs user in
                MessageBox.Show("we found your data please wait");
                //encrypts user data
                string IDFind = ReadDataID(Userdata);
                string encodedFileName = Convert.ToBase64String(Encoding.UTF8.GetBytes(Userdata[0]));
                string encodedFileNameFull = encodedFileName.Replace('/', '-');
                string fileName = IDFind + encodedFileNameFull;
                string[] paths = new string[2] { FileCreatePath, fileName };
                string DatabasePath = Path.Combine(paths) + ".db";
                //if database exists allow user in
                if (File.Exists(DatabasePath))
                {
                    AllowUserIn(DatabasePath);
                    return;
                }
                else
                {
                    //create database
                    CreateDatabase(DatabasePath);
                }
            }
        }

        private void AllowUserIn(string DatabasePath)
        {
            MessageBox.Show("checking you in now");
            //logs the user into the app config(encrypted username)
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            config.AppSettings.Settings["UserLoginLocation"].Value = DatabasePath;
            config.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection("appSettings");
            this.Hide();
            Homepage_F1_ homepage = new Homepage_F1_();
            homepage.Show();
            homepage.FormClosed += Homepage_F1__FormClosed;
            
        }

        private void Homepage_F1__FormClosed(object sender, EventArgs e)
        {
            this.Show();
        }

    }
}
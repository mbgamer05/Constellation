using Constellation.Scripts;
using Constellation.UI;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using System.Text;

namespace Constellation
{
    public partial class Form1 : Form
    {
        private static string FolderPath = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
        private static string FileCreatePath = FolderPath + "\\Constellation";
        public static string UserLocation = FileCreatePath + "\\Main.db";
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
            //checks if it is the applications first run and restarts to allow the database and files to adjust
            bool.TryParse(Environment.GetEnvironmentVariable("ClickOnce_IsNetworkDeployed"), out bool isNetworkDeployed);
            bool.TryParse(Environment.GetEnvironmentVariable("ClickOnce_IsFirstRun"), out bool IsFirstRun);
            if (isNetworkDeployed == true && IsFirstRun == true)
            {
                var newestrun = Int32.Parse(config.AppSettings.Settings["FirstRunOfNewUPdate"].Value);
                if (newestrun == 0)
                {
                    MessageBox.Show("Applying update....\n application will now restart");
                    config.AppSettings.Settings["FirstRunOfNewUPdate"].Value = "1";
                    config.Save(ConfigurationSaveMode.Modified);
                    ConfigurationManager.RefreshSection("appSettings");
                    Application.Restart();
                }
            }
            //creats a file path to where the application files are saved
            string[] colourpathFind = new string[2] { FileCreatePath, "Colour" };
            string ColourPath = Path.Combine(colourpathFind) + ".db";
            if (!File.Exists(FileCreatePath))
            {
                Directory.CreateDirectory(FileCreatePath);
            }
            if (!File.Exists(ColourPath))
            {
                //adds preview colours
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
            LoadSplash();
        }
        private void LoadSplash()
        {
            TimeSpan Now = DateTime.Now.TimeOfDay;
            TimeSpan Morning = new TimeSpan(0, 0, 0);
            TimeSpan Midday = new TimeSpan(11, 0, 0);
            TimeSpan Night = new TimeSpan(17, 30, 0);
            if ((Now >= Morning) && (Now <= Midday))
            {
                lblHello.Text = "Good Morning!";
                lblHelloSplash.Text = "Ready for a day of work!";
            }
            else if (Now >= Midday && Now <= Night)
            {
                lblHello.Text = "Good Afternoon!";
                lblHelloSplash.Text = "Productive day I see";
            }
            else
            {
                lblHello.Text = "Good Night";
                lblHelloSplash.Text = "Perfect night to get some more work done";
            }
        }
        private void LoadColours()
        {
            (int[] PrimaryButtonARGB, int[] SecondaryButtonARGB, int[] TextARGB, int[] BackgroundARGB, int[] TextBoxBackgroundARGB) = GetColours.ReadStringData(GetColours.ReadData());
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            this.BackColor = Color.FromArgb(BackgroundARGB[0], BackgroundARGB[1], BackgroundARGB[2], BackgroundARGB[3]);
            this.ForeColor = Color.FromArgb(TextARGB[0], TextARGB[1], TextARGB[2], TextARGB[3]);
            Control cn = this;
            cn = Class.LoadColours.SetColours(cn, this);
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
            //try to create a new user
            //if an error is thrown because the username is already taken let the user know
            try
            {
                SQLiteConnection sqlconnection = new SQLiteConnection();
                sqlconnection.ConnectionString = "DataSource = " + UserLocation;
                SQLiteCommand sqlCommand = new SQLiteCommand();
                sqlCommand.Connection = sqlconnection;
                sqlCommand.CommandType = CommandType.Text;
                sqlCommand.CommandText = "INSERT INTO Users (Username,Password) Values (@Username, @Password)";
                sqlCommand.Parameters.AddWithValue("@Username", Userdata[0]);
                sqlCommand.Parameters.AddWithValue("@Password", Userdata[1]);
                sqlconnection.Open();
                sqlCommand.ExecuteNonQuery();
                sqlconnection.Close();

                //Gets the user ID and encrypts the data and logs the user in 
                string IDFind = ReadDataID(Userdata);
                string encodedFileName = Convert.ToBase64String(Encoding.UTF8.GetBytes(Userdata[0]));
                string encodedFileNameFull = encodedFileName.Replace('/', '-');
                string fileName = IDFind + encodedFileNameFull;
                string[] paths = new string[2] { FileCreatePath, fileName };
                string DatabasePath = Path.Combine(paths) + ".db";
                CreateDatabase(DatabasePath);
                AllowUserIn(DatabasePath);
            }
            catch
            {
                MessageBox.Show("hmm seems like the user already exists please login");
            }

        }

        private static void CreateDatabase(string DatabasePath)
        {
            string BoardName = "Board1";
            BoardName = Setups.CreateBoard(BoardName, DatabasePath);
            //checks if database exists 
            SQLiteConnection NewDatabaseConnection = new SQLiteConnection();
            SQLiteCommand SetUpCommand = new SQLiteCommand();
            SetUpCommand.Connection = NewDatabaseConnection;
            NewDatabaseConnection.ConnectionString = "DataSource = " + DatabasePath;
            if (File.Exists(DatabasePath))
            {
                MessageBox.Show("Database created");
                for (int i = 0; i < 3; i++)
                {
                    //puts sample data into database
                    SetUpCommand.CommandText = "INSERT INTO Board1 " +
                    "(Name, PreviewBody, FullBody, Date, Location, PBoard)" +
                    " Values (@Name, @PreviewBody, @FullBody, @Date, @Location, @PBoard)";
                    SetUpCommand.Parameters.AddWithValue("@Name", "Note " + (i + 1));
                    SetUpCommand.Parameters.AddWithValue("@PreviewBody", "Preview data is shown here it's a small blurb about you note");
                    SetUpCommand.Parameters.AddWithValue("@FullBody", "data shown here is bigger and larger than the preview message, this is great for large projects where you need to write down what you need to do,\n also the date stamp is when the idea/work needs to be done by");
                    SetUpCommand.Parameters.AddWithValue("@Date", DateTime.Today.AddDays(7).ToString("dddd, dd MMMM yyyy"));
                    SetUpCommand.Parameters.AddWithValue("@Location", i);
                    SetUpCommand.Parameters.AddWithValue("@PBoard", 1);
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
            sqlconnection.ConnectionString = "DataSource = " + UserLocation;
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
            sqlconnection.ConnectionString = "DataSource = " + UserLocation;
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
            string PasswordToFind = ReadDataPass (Userdata);
            if (PasswordToFind.Contains("failed"))
            {
                MessageBox.Show("couldn't find a username or password are you sure you have made an account?\n" +
                    "maybe make sure you're putting the right username and passwords in");
            }
            else if (Userdata[1] == PasswordToFind)
            {
                //logs user in
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
            //logs the user into the app config(encrypted username)
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            config.AppSettings.Settings["UserLoginLocation"].Value = DatabasePath;
            config.Save(ConfigurationSaveMode.Modified);
            UpdateConfig.NewValue("Board1", "BoardToOpen");
            ConfigurationManager.RefreshSection("appSettings");
            this.Hide();
            Homepage_F1_ homepage = new Homepage_F1_();
            homepage.Username = txtUsername.Text;
            homepage.Show();
            homepage.FormClosed += Homepage_F1__FormClosed;

        }

        private void Homepage_F1__FormClosed(object sender, EventArgs e)
        {
            this.Show();
        }

        private void lblHelloSplash_Click(object sender, EventArgs e)
        {

        }

        private void TextSelected(object sender, EventArgs e)
        {
            TextBox tb = sender as TextBox;
            tb.SelectionStart = 0;
            tb.SelectionLength = tb.Text.Length;
        }
    }
}
using System.Configuration;
using System.IO;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Data.Common;
using System.Data;

namespace Constellation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            var ConfigFont = config.AppSettings.Settings["FontType"].Value;
            this.Font = new Font(ConfigFont, this.Font.Size);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            using (StreamReader sr = new StreamReader("State.txt"))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    if (line.Contains("State"))
                    {
                        if (line.Contains("Settings"))
                        {
                            Settings_F2_ settings = new Settings_F2_();
                            settings.FormClosed += Settings_F2__Load;
                            settings.Show();
                            this.SendToBack();
                            this.Hide();
                        }
                    }
                }
            }
            lineChanger("State = Home", "State.txt", 1);
            static void lineChanger(string newText, string fileName, int line_to_edit)
            {
                string[] arrLine = File.ReadAllLines(fileName);
                arrLine[line_to_edit - 1] = newText;
                File.WriteAllLines(fileName, arrLine);
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {

            //qS3oV1TQPe2yQIql
            /*
            var settings = MongoClientSettings.FromConnectionString("mongodb+srv://matthewderrick2005:qS3oV1TQPe2yQIql@cluster0.l9xqdzv.mongodb.net/?retryWrites=true&w=majority");
            settings.ServerApi = new ServerApi(ServerApiVersion.V1);
            var client = new MongoClient(settings);
            var db = client.GetDatabase("Main");
            var coll = db.GetCollection<Data>("UsersData");
            */

            string[] Userdata = new string[2];
            Userdata[0] = txtUsername.Text;
            Userdata[1] = txtPassword.Text;


            SQLiteConnection sqlconnection = new SQLiteConnection();
            sqlconnection.ConnectionString = "DataSource = Main.db";
            SQLiteCommand sqlCommand = new SQLiteCommand();
            sqlCommand.Connection = sqlconnection;
            sqlCommand.CommandType = System.Data.CommandType.Text;
            sqlCommand.CommandText = "INSERT INTO Users (Username,Password) Values (@Username, @Password)";
            sqlCommand.Parameters.AddWithValue("@Username", Userdata[0]);
            sqlCommand.Parameters.AddWithValue("@Password", Userdata[1]);

            sqlconnection.Open();
            sqlCommand.ExecuteNonQuery();
            sqlconnection.Close();

            //File.Create("User" + +".db")

        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            Settings_F2_ settings = new Settings_F2_();
            settings.FormClosed += Settings_F2__FormClosed;
            this.Hide();
            settings.Show();
        }
        private void Settings_F2__FormClosed(object sender, EventArgs e)
        {
            this.Show();
        }
        private void Settings_F2__Load(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnBoard_Click(object sender, EventArgs e)
        {
            Board_F3_ Board = new Board_F3_();
            Board.FormClosed += Board_F3__FormClosed;
            this.Hide();
            Board.Show();
        }

        private void Board_F3__FormClosed(object sender, EventArgs e)
        {
            this.Show();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string[] Userdata = new string[2];
            Userdata[0] = txtUsername.Text;
            Userdata[1] = txtPassword.Text;

            SQLiteConnection sqlconnection = new SQLiteConnection();
            sqlconnection.ConnectionString = "DataSource = Main.db";
            string commandText = "SELECT Password FROM Users";
            var datatable = new DataTable();
            SQLiteDataAdapter myDataAdapter = new SQLiteDataAdapter(commandText, sqlconnection);
            sqlconnection.Open();
            myDataAdapter.Fill(datatable);
            sqlconnection.Close();
            txtUsername.Text = datatable.Rows[0].ToString();

            
        }
    }
}
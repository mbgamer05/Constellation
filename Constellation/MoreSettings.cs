using System.Data;
using System.Data.SQLite;

namespace Constellation
{

    public class MoreSettings
    {
        static PublicData PD = new PublicData();
        
        static string[] colourpathFind = new string[2] { PD.FileCreatePath, "Colour" };
        static string ColourPath = Path.Combine(colourpathFind) + ".db";


        public static DataRow[] ReadData()
        {
            SQLiteConnection sqlconnection = new SQLiteConnection();
            sqlconnection.ConnectionString = "DataSource = " + ColourPath;
            string commandText = "SELECT * FROM " + PD.ColourScheme;
            DataTable table = new DataTable();
            SQLiteDataAdapter myDataAdapter = new SQLiteDataAdapter(commandText, sqlconnection);
            sqlconnection.Open();
            myDataAdapter.Fill(table);
            //put all data from the database into datarow
            DataRow[] rows = table.Select();
            sqlconnection.Close();
            return rows;
        }

        public static (int[], int[], int[], int[], int[]) ReadStringData(DataRow[] rows)
        {
            int[] PrimaryButtonARGB = new int[4];
            int[] SecondaryButtonARGB = new int[4];
            int[] TextARGB = new int[4];
            int[] BackgroundARGB = new int[4];
            int[] TextBoxBackgroundARGB = new int[4];
            bool done = false;
            int i = 0;
            while (!done)
            {
                string temp = rows[i]["PrimaryButton"].ToString();
                int j = 0;
                foreach (string r in temp.Split(","))
                {
                    PrimaryButtonARGB[j] = int.Parse(r);
                    j++;
                }

                temp = rows[i]["SecondaryButton"].ToString();
                j = 0;
                foreach (string r in temp.Split(","))
                {
                    SecondaryButtonARGB[j] = int.Parse(r);
                    j++;
                }

                temp = rows[i]["BackgroundColour"].ToString();
                j = 0;

                foreach (string r in temp.Split(","))
                {
                    BackgroundARGB[j] = int.Parse(r);
                    j++;
                }

                temp = rows[i]["TextColour"].ToString();
                j = 0;

                foreach (string r in temp.Split(","))
                {
                    TextARGB[j] = int.Parse(r);
                    j++;
                }

                temp = rows[i]["TextboxBackgroundColour"].ToString();
                j = 0;

                foreach (string r in temp.Split(","))
                {
                    TextBoxBackgroundARGB[j] = int.Parse(r);
                    j++;
                }
                done = true;
            }
            return (PrimaryButtonARGB, SecondaryButtonARGB, TextARGB, BackgroundARGB, TextBoxBackgroundARGB);
        }
    }
}

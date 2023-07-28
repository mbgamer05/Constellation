using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Constellation.Scripts;

namespace Constellation.Controls
{
    public partial class ComingUp : UserControl
    {
        public List<DataRow> rows = new List<DataRow>();
        public string SeletedDate;
        public ComingUp()
        {
            InitializeComponent();
        }

        public TextBox TextBoxBody
        {
            get { return txtComingUpBody; }
            set { txtComingUpBody = value; }
        }
        public Label LabelBoard
        {
            get { return lblComingUpBoardName; }
            set { lblComingUpBoardName = value; }
        }

        private void GenerateListBoxEntries(string SelectedDate)
        {
            //allows list box scrolling
            //gets all data from all boards that have notes where the dates are equal
            rows = DataRowNote.ReadAllBoardsNotes(DataRowBoard.GetAllDatabaseBoards());
            foreach (DataRow row in rows)
            {

                if (SelectedDate == row["date"].ToString())
                {
                    lbComingUpNote.Items.Add(row["Name"]);
                }
            }
        }
        private void txtComingUpBody_TextChanged(object sender, EventArgs e)
        {

        }
        private void dtpComingUpDate_CloseUp(object sender, EventArgs e)
        {
            //gets the current date and converts it into a string that is readable for the software
            DateTime current = dtpComingUpDate.Value;
            SeletedDate = current.ToString("dddd dd MMMM yyyy");
            //clears the listbox and generates the new entires for it
            lbComingUpNote.Items.Clear();
            GenerateListBoxEntries(SeletedDate);
        }

        private void lbComingUpNote_SelectedIndexChanged(object sender, EventArgs e)
        {
            string SelectedNote = lbComingUpNote.SelectedItem.ToString();
            foreach (DataRow row in rows)
            {
                if (row["Name"] == SelectedNote)
                {
                    lblComingUpBoardName.Text = row["Board"].ToString();
                    txtComingUpBody.Text = row["FullBody"].ToString();
                }
            }
        }
    }
}

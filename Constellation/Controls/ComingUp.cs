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

        private void GenerateListBoxEntries()
        {
            //allows list box scrolling
            //gets all data from the board that is selected
            DataRow[] rows = DataRowReadNote.ReadDatabaseRowNoteAll(DataRowReadBoard.ReadDatabaseRowBoard());
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
                    if (rows[i]["Date"] == SeletedDate)
                    {
                        lbComingUpNote.Items.Add(rows[i]["Name"].ToString());
                    }
                    i++;
                }
            }
        }
        private void txtComingUpBody_TextChanged(object sender, EventArgs e)
        {

        }
        private void dtpComingUpDate_CloseUp(object sender, EventArgs e)
        {
            DateTime current = dtpComingUpDate.Value;
            SeletedDate = current.ToString("dddd, dd MMMM yyyy");
            lbComingUpNote.Items.Clear();
            GenerateListBoxEntries();
        }
    }
}

﻿using System;
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

        private void GenerateListBoxEntries(string SeletedDate)
        {
            //allows list box scrolling
            //gets all data from all boards that have notes where the dates are equal
            List<DataRow> rows = DataRowReadNote.ReadDatabaseRowNoteAll(DataRowReadBoard.ReadDatabaseBoards());
            foreach (DataRow row in rows)
            {
                lbComingUpNote.Items.Add(row["Name"]);
            }
        }
        private void txtComingUpBody_TextChanged(object sender, EventArgs e)
        {

        }
        private void dtpComingUpDate_CloseUp(object sender, EventArgs e)
        {
            //gets the current date and converts it into a string that is readable for the software
            DateTime current = dtpComingUpDate.Value;
            SeletedDate = current.ToString("dddd, dd MMMM yyyy");
            //clears the listbox and generates the new entires for it
            lbComingUpNote.Items.Clear();
            GenerateListBoxEntries(SeletedDate);
        }
    }
}

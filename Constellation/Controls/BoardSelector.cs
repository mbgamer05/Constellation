using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Constellation
{
    public partial class BoardSelector : UserControl
    {
        public BoardSelector()
        {
            InitializeComponent();
        }
        public string BoardName
        {
            get { return lblBoardName.Text; }
            set { lblBoardName.Text = value; }
        }
        public Button Left
        {
            get { return btnLeft; }
            set { btnLeft = value; }
        }
        public Button Right
        {
            get { return btnRight; }
            set { btnRight = value; }
        }
        private void btnLeft_Click(object sender, EventArgs e)
        {

        }

        private void btnRight_Click(object sender, EventArgs e)
        {

        }
    }
}

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
    public partial class BannerSelector : UserControl
    {
        public BannerSelector()
        {
            InitializeComponent();
        }
        public string BannerText
        {
            get { return lblBannerText.Text; }
            set { lblBannerText.Text = value; }
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

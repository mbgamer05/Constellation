using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Constellation.Controls
{
    public partial class ComingUp : UserControl
    {
        public ComingUp()
        {
            InitializeComponent();
        }

        private void bsDateSelector_Load(object sender, EventArgs e)
        {
            bsDateSelector.Left.Click += bsLeft_Click;
            bsDateSelector.Right.Click += bsRight_Click;
        }
        private void bsLeft_Click(object sender, EventArgs e)
        {


        }
        private void bsRight_Click(object sender, EventArgs e)
        {

        }
    }
}

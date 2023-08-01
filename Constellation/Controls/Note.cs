using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Constellation
{
    public partial class Note : UserControl
    {
        public Note()
        {
            InitializeComponent();
        }

        public string TextPreview
        {
            get { return txtPreview.Text; }
            set { txtPreview.Text = value; }
        }
        public string NoteName
        {
            get { return lblNoteName.Text; }
            set { lblNoteName.Text = value; }
        }
    }
}

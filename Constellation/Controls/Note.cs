using Constellation.Class;
using Constellation.Scripts;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
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
        private void Note_Load(object sender, EventArgs e)
        {
        }
        protected virtual void MouseDownProc(EventArgs e)
        {
        }
        private void MouseDownNote(object sender, MouseEventArgs e)
        {

        }
        public void MouseMoveNote(object sender, MouseEventArgs e)
        {

        }
        public System.Windows.Forms.Button btnExpand
        {
            get { return btnSettings; }
            set { btnSettings = value; }
        }
        private void btnSettings_Click(object sender, EventArgs e)
        {
        }
    }
}

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
    public partial class Board_F3_ : Form
    {
        public Board_F3_()
        {
            InitializeComponent();
        }

        private void Board_F3__Load(object sender, EventArgs e)
        {
            foreach (Panel pl in this.Controls.OfType<Panel>())
            {
                if (pl is TableLayoutPanel)
                {
                    continue;
                }
                pl.MouseDown += Panel_MouseDown;
                pl.MouseMove += Panel_MouseMove_1;
                pl.DragDrop += Panel_DragDrop;
            }

            tableLayoutPanel1.DragDrop += new DragEventHandler(TLPDragDrop);
            tableLayoutPanel1.DragDrop += new DragEventHandler(TLPDragEnter);
        }

        private void TLPDragEnter(object sender, DragEventArgs e)
        {
           
        }

        private void TLPDragDrop(object sender, DragEventArgs e)
        {

        }

        private Point MouseDownLocation;
        private void Panel_DragDrop(object sender, DragEventArgs e)
        {

        }
        private void Panel_MouseMove_1(object sender, MouseEventArgs e)
        {
            Panel pl = (Panel)sender;
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                pl.Left = e.X + pl.Left - MouseDownLocation.X;
                pl.Top = e.Y + pl.Top - MouseDownLocation.Y;
            }
        }
        private void Panel_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                MouseDownLocation = e.Location;
            }
        }
        private void tlpBoard1_DragEnter(object sender, DragEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

    }
}

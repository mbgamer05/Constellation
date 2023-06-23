using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Constellation
{
    public partial class NoteGrid : UserControl
    {
        public NoteGrid()
        {
            InitializeComponent();
        }

        private void tlpPriorityHold_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblDone_Click(object sender, EventArgs e)
        {

        }

        private void DragDrop(object sender, DragEventArgs e)
        {

        }

        private void DragEnter(object sender, DragEventArgs e)
        {

        }

        private void DragLeave(object sender, EventArgs e)
        {

        }

        private void DragOver(object sender, DragEventArgs e)
        {

        }

        private void Doing_Paint(object sender, PaintEventArgs e)
        {

        }

        public Color ToDoColor
        {
            get { return ToDo.BackColor; }
            set { ToDo.BackColor = value; }
        }
        public Color DoingColor
        {
            get { return Doing.BackColor; }
            set { Doing.BackColor = value; }
        }
        public Color DoneColor
        {
            get { return Done.BackColor; }
            set { Done.BackColor = value; }
        }
        public Panel ToDoPanel
        {
            get { return ToDo; }
            set { ToDo = value; }
        }
        public Panel DoingPanel
        {
            get { return Doing; }
            set { Doing = value; }
        }
        public Panel DonePanel
        {
            get { return Done; }
            set { Done = value; }
        }
        public Panel[] AllPanels 
        {
            get 
            {
                return this.tlpStation.Controls.OfType<Panel>().ToArray();

            }
            set
            {
             
            }
            set { ToDo = value; Doing = value; Done = value; }
        }

        
    }
}

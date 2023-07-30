using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constellation.Scripts
{
    internal class ListboxActions
    {
        /// <summary>
        /// generates the items for the list box based on the location selected and the notes provided
        /// </summary>
        /// <param name="lb">the list box to generate entires for</param>
        /// <param name="Location">the location that need notes need to be pulled from</param>
        /// <returns></returns>
        public static ListBox GenerateEntires(ListBox lb, int Location)
        {
            //allows list box scrolling
            //gets all data from the board that is selected
            DataRow[] rows = DataRowNote.ReadCurrentBoardsNotes();
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
                    if (int.Parse(rows[i]["Location"].ToString()) == Location)
                    {
                        lb.Items.Add(rows[i]["Name"].ToString());
                    }
                    i++;
                }
            }
            return lb;
        }
        /// <summary>
        /// Relaods the listbox
        /// </summary>
        /// <param name="lb">the list box to be reloaded</param>
        /// <param name="Location"> where the location is to be reloaded</param>
        /// <returns></returns>
        public static ListBox ReloadListbox (ListBox lb, int Location)
        {
            lb.Items.Clear();
            GenerateEntires(lb, Location);
            return lb;
        }
        public static bool CheckSelected (ListBox lb)
        {
            if (lb.SelectedIndex == -1)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}

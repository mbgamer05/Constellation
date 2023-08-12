using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Constellation.UI;

namespace Constellation.Class
{
    internal class LoadColours
    {
        //gets all the children of the control given to it(even child controls of controls)
        public static IEnumerable<Control> GetAllChildrens(Control control)
        {
            var controls = control.Controls.Cast<Control>();
            return controls.SelectMany(c => GetAllChildrens(c)).Concat(controls);
        }
        /// <summary>
        /// Sets each of the controls in the form to their selected colours
        /// goes through each of the controls provided through the parent control
        /// </summary>
        /// <param name="Control">The parent control selected</param>
        /// <param name="form">the form selected</param>
        /// <returns>returns the parent control and all control data associated with it</returns>
        public static Control SetColours (Control Control, Form form)
        {
            (int[] PrimaryButtonARGB, int[] SecondaryButtonARGB, int[] TextARGB, int[] BackgroundARGB, int[] TextBoxBackgroundARGB) = GetColours.ReadStringData(GetColours.ReadData());
            foreach (Control cn in LoadColours.GetAllChildrens(Control))
            {
                if (cn != null)
                {
                    switch (cn)
                    {
                        case Button bn:
                            if (bn.Tag != null && bn.Tag.Equals("Primary"))
                            {
                                bn.BackColor = Color.FromArgb(PrimaryButtonARGB[1], PrimaryButtonARGB[2], PrimaryButtonARGB[3]);
                                bn.FlatStyle = FlatStyle.Popup;
                                bn.FlatAppearance.BorderSize = 0;
                                bn.FlatAppearance.BorderColor = Color.FromArgb(PrimaryButtonARGB[1], PrimaryButtonARGB[2], PrimaryButtonARGB[3]);
                                bn.ForeColor = form.ForeColor;
                            }
                            else
                            {
                                bn.BackColor = Color.FromArgb(SecondaryButtonARGB[0], SecondaryButtonARGB[1], SecondaryButtonARGB[2], SecondaryButtonARGB[3]);
                                bn.FlatStyle = FlatStyle.Popup;
                                bn.FlatAppearance.BorderSize = 0;
                                bn.FlatAppearance.BorderColor = Color.FromArgb(SecondaryButtonARGB[1], SecondaryButtonARGB[2], SecondaryButtonARGB[3]);
                                bn.ForeColor = form.ForeColor;
                            }
                            break;
                        case TextBox tb:
                            tb.BackColor = Color.FromArgb(TextBoxBackgroundARGB[0], TextBoxBackgroundARGB[1], TextBoxBackgroundARGB[2], TextBoxBackgroundARGB[3]);
                            tb.ForeColor = form.ForeColor;
                            break;
                    }
                }

            }
            return Control;
        }
    }
}

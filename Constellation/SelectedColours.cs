using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constellation
{
    internal class SelectedColours
    {
        public int Location { get; set; }
        public string ARGBvalues { get; set; }
        public SelectedColours(int SetLocation, string SetARGVvalues) 
        {
            SetLocation = Location;
            SetARGVvalues = ARGBvalues;
        }
    }
}

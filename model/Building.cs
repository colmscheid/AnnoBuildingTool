using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// A building in the Anno game:
// - every building has an building area
// - and a range for its functionality

namespace AnnoBuildingTool.model
{
    class Building
    {
        public class Buidling() 
        {
        }

        public String Name { get; set; }
        public Area Area { get; set; }
        public Range Range { get; set; }
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// The map where the building are placed on.

namespace AnnoBuildingTool.model
{
    class Map
    {
        public Rectangle rectangle { get; set; }
        public Hashtable buildings { get; set; }
        public ArrayList streets { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// The area a bulding is build on.

namespace AnnoBuildingTool.model
{
    class Area : Rectangle
    {
        public Area(int width, int height) : base(width, height)
        {
            Width = width;
            Height = height;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Most building has an influence range.

namespace AnnoBuildingTool.model
{
    class Range : Rectangle
    {
        public Range(int width, int height) : base(width, height)
        {
            Width = width;
            Height = height;
        }
    }
}

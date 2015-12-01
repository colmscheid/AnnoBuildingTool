using AnnoBuildingTool.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnnoBuildingTool
{
    static class Program
    {
        /// <summary>
        /// Der Haupteinstiegspunkt für die Anwendung.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            Area rec = new Area(1, 1);
            rec.Height = 2;
            rec.Width = 2;

            Console.WriteLine("This program lists all the files in the directory:");
            Console.WriteLine(rec.Height);
            Console.WriteLine(rec.Width);
        }
    }
}

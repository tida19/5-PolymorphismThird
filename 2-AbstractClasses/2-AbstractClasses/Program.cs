using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_AbstractClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            //var shape = new Shape();

            var c = new Circle();
            c.Draw();

            var r = new Rectangle();
            r.Draw();
        }
    }
}

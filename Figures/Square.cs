using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures
{
    class Square : Figure
    {
        public double Side { get; private set; }

        public Square(double side)
        {
            Side = side;
        }

        public override double Area()
        {
            return Math.Pow(Side, 2);
        }

        public override double Perimeter()
        {
            return 4 * Side;
        }

        public double Diagonal()
        {
            return Math.Sqrt(2) * Side;
        }

        public override void Print()
        {
            Console.WriteLine("I'm Square");
            base.Print();
        }
    }
}

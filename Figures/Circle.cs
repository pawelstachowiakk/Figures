using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures
{
    class Circle : Figure
    {
        public double Radius { get; set; }

        public Circle(double radius)
        {
            Radius = radius;
        }

        public override double Area()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }

        public override double Perimeter()
        {
            return 2 * Math.PI * Radius;
        }

        public override void Print()
        {
            Console.WriteLine("I'm Circle");
            base.Print();
        }
    }
}

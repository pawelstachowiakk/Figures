using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures
{
    abstract class Figure
    {
        public abstract double Area();
        public abstract double Perimeter();
        public virtual void Print()
        {
            Console.WriteLine($"Area: {Area()} Perimeter: {Perimeter()}\n");
        }
    }
}

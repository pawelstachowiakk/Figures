using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures
{
    class Program
    {
        static void Main(string[] args)
        {
            Figure[] figures = new Figure[3];

            figures[0] = new Square(2);
            figures[1] = new Circle(2);
            figures[2] = new Square(3);

            foreach (Figure figure in figures)
            {
                figure.Print();
            }

            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Polymorphism
{
    public class Square: Shape
    {
        public int edge;

        public override void CalculateArea()
        {
            int squareArea = edge * edge;
            Console.WriteLine("Square Area: " + squareArea);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Polymorphism
{
    public class Rectangle: Shape
    {
        public int shortEdge { get; set; }
        public int longEdge { get; set; }

        public override void CalculateArea()
        {
            int rectangleArea = shortEdge * longEdge;
            Console.WriteLine("Rectangle Area: " +  rectangleArea); 
        }
    }
}

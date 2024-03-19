using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Polymorphism
{
    public class Circle: Shape
    {
        public int Radius { get; set; }
        public override void CalculateArea()
        {
            double circleArea = Math.Round((Math.PI * Math.Pow(Radius,2)),2);
            Console.WriteLine("Circle Area: " + circleArea);
        }
    }
}

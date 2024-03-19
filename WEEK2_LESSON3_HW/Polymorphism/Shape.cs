using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Polymorphism
{
    public class Shape
    {
        public string ShapeName { get; set; }
        public virtual void CalculateArea()
        {
            Console.WriteLine("Calculated");
        }
    }
}

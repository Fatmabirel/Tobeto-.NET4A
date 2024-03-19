using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Polymorphism2
{
    public class PhilosophicBook: Book
    {
        public override void CalculateTheTimeOfBook()
        {
            // average time to finish philosophic book is pagenumber/90 day
            double time = BookPageNumber / 90;
            Console.WriteLine("You will finish this philosophic book in :" + time + " days");

        }
    }
}

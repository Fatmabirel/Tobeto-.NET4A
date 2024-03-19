using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Polymorphism2
{
    public class FantasticBook: Book
    {
        public override void CalculateTheTimeOfBook()
        {
            // average time to finish fantastic book is pagenumber/100 day
            double time = BookPageNumber / 100;
            Console.WriteLine("You will finish this fantastic book in :" + time + " days");

        }
    }
}

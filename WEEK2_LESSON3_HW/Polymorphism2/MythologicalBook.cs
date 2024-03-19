using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Polymorphism2
{
    public class MythologicalBook: Book
    {
        public override void CalculateTheTimeOfBook()
        {
            // average time to finish mythological book is pagenumber/80 day
            double time = BookPageNumber / 80;
            Console.WriteLine("You will finish this mythological book in :" + time + " days");

        }
    }
}

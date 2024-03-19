using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Polymorphism2
{
    public class Book
    {
        public string BookName { get; set; }
        public string BookAuthor { get; set; }
        public int BookPageNumber { get; set; }

        public virtual void CalculateTheTimeOfBook()
        {
            Console.WriteLine("Calculated");
        }
    }
}

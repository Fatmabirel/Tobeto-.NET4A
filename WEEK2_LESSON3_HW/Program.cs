using OOP.Inheritance;
using OOP.Inheritance2;
using OOP.Polymorphism2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Polymorphism
{
    public class Program
    {
        static void Main(string[] args)
        {

            //Circle circle = new Circle();
            //circle.ShapeName = "Circle";
            //circle.Radius = 5;
            //circle.CalculateArea();

            //Rectangle rectangle = new Rectangle();
            //rectangle.ShapeName = "Rectangle";
            //rectangle.longEdge = 20;
            //rectangle.shortEdge = 15;
            //rectangle.CalculateArea();

            //Square square = new Square();
            //square.ShapeName = "Square";
            //square.edge = 15;
            //square.CalculateArea();

            //FantasticBook fantasticBook = new FantasticBook();
            //fantasticBook.BookName = "Dördüncü Kanat";
            //fantasticBook.BookAuthor = "Rebecca Yarros";
            //fantasticBook.BookPageNumber = 626;
            //fantasticBook.CalculateTheTimeOfBook();

            //PhilosophicBook philosophicBook = new PhilosophicBook();
            //philosophicBook.BookName = "Mutluluğun Kazanılması";
            //philosophicBook.BookAuthor = "Farabi";
            //philosophicBook.BookPageNumber = 184;
            //philosophicBook.CalculateTheTimeOfBook();

            //MythologicalBook mythologicalBook = new MythologicalBook();
            //mythologicalBook.BookName = "İyi Hissetmek";
            //mythologicalBook.BookAuthor = "David Burns";
            //mythologicalBook.BookPageNumber = 421;
            //mythologicalBook.CalculateTheTimeOfBook();


            /// INHERITANCE ///

            //Bird bird = new Bird();
            //bird.Name = "Cücük";
            //bird.Age = 2;
            //bird.Color = "Brown";
            //bird.Noise();

            //Console.WriteLine($"Name: {bird.Name}, Age: {bird.Age}, Color: {bird.Color}");

            //Car car = new Car();
            //car.Name = "Car";
            //car.Brand = "BMW";
            //car.WheelNumber = 4;

            //Console.WriteLine($"Name: {car.Name}, Brand: {car.Brand}, WheelNumber: {car.WheelNumber}");

            // ----------------------- GENERIC -------------------

            //MyList<int> intList = new MyList<int>(5);
            //intList.Add(10);
            //intList.Add(20);
            //intList.Add(30);

            //Console.WriteLine("Item at index 0: " + intList.Get(0));
            //Console.WriteLine("Item at index 1: " + intList.Get(1));
            //Console.WriteLine("Total items in the list: " + intList.Count());

            // ABSCTRACT - INHERITANCE 

            //Abstract class, soyut ve somut üyeler içerebilirken, interface sadece üye bildirimlerini içerir; soyut class'lar bir sınıfın genel yapısını tanımlamak için kullanılırken, interface'ler belirli bir davranışı garanti etmek için kullanılır; soyut class'lar tek bir sınıftan türeyebilirken, interface'ler bir sınıfın birden fazla davranışı garanti etmesini sağlar ve çoklu mirası destekler; bu farklar, tasarımın gereksinimlerine ve amaçlarına göre tercih edilmelerine yol açar.

            // -------------- ENCAPSULATION -------------

            //Kisi kisi = new Kisi("Ahmet", 30);

            //kisi.BilgileriGoster(); // Ad: Ahmet, Yaş: 30

            //kisi.YasArttir();
            //kisi.AdDegistir("Mehmet");

            //kisi.BilgileriGoster(); // Ad: Mehmet, Yaş: 31


        }
    }
}

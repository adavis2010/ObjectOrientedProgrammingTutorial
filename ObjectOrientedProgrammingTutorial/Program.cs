using System;

namespace ObjectOrientedProgrammingTutorial {
    class Program {


        static void Main(string[] args) {

            var sqr1 = new Sqr(7);
            Console.WriteLine($"SQR : Perimeter is {sqr1.Perimeter()}");
            Console.WriteLine($"SQR : Area is {sqr1.Area()}");


            var rect1 = new Rect(5, 7);
            

            Console.WriteLine($"Perimeter is {rect1.Perimeter()}");
            Console.WriteLine($"Area is {rect1.Area()}");
            //Console.WriteLine ($"About is {rect1.About"});


        }



    }
}

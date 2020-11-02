using System;
using System.Collections.Generic;
using System.Drawing;

namespace Geometri_Arv
{
    class Program
    {
        static void Main(string[] args)
        {
            //I create the objects
            Square square = new Square();
            Parallelogram parallelogram = new Parallelogram();
            Trapez trapez = new Trapez();
            Triangle triangle = new Triangle();
            Rektangel rektangel = new Rektangel();

            //Sets site for a square
            square.SiteA = 10;

            //Sets sites and angle for a parallelogram
            parallelogram.SiteA = 3;
            parallelogram.SiteB = 5;
            parallelogram.Angle = 20;

            //sets sites for a Trapezoid
            trapez.SiteA = 10;
            trapez.SiteB = 9;
            trapez.SiteC = 8;
            trapez.SiteD = 9;

            //Sets sites for a Triangle
            triangle.SiteA = 15;
            triangle.SiteB = 10;

            //Sets sites for a Rectangle
            rektangel.SiteA = 12;
            rektangel.SiteB = 16;

            //Creates a list and adds the shapes to the list
            List<Square> shapeList = new List<Square>();
            shapeList.Add(square);
            shapeList.Add(parallelogram);
            shapeList.Add(trapez);
            shapeList.Add(triangle);

            //Prints the calculations made on the items in the list with the methods from the respective classes
            foreach(Square item in shapeList)
            {
                Console.WriteLine(item.ArealCalc());
                Console.WriteLine(item.CircCalc());
            }

         
            //Pauses the program so you have time to read my beautiful results.
            Console.ReadKey();
        }
    }
}

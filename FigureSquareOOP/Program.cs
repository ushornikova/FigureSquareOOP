using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureSquareOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Shape> shapes = new List<Shape>(); //створили список
            Triangle t1 = new Triangle(3, 5); // потрібно створити обєкт
            shapes.Add(t1);//додаємо

            Console.WriteLine("Please enter A");
            string A = Console.ReadLine();
            int a1;
            bool success = Int32.TryParse(A, out a1);
            if (success)
            {
                a1 = Convert.ToInt32(A);
            }
            else
            {
                Console.WriteLine("площа не може бути обчислена бо введено не число у А");
            }

            Console.WriteLine("Please enter B");
            string B = Console.ReadLine();
            int b1;
            bool successb = Int32.TryParse(B, out b1);
            if (successb)
            {
                b1 = Convert.ToInt32(B);
            }
            else
            {
                Console.WriteLine("площа не може бути обчислена бо введено не число у В");
            }

            Rectangle r1 = new Rectangle(a1, b1);
            shapes.Add(r1);

            Circle c1 = new Circle(5);
            shapes.Add(c1);

            foreach (var item in shapes)
            {
                item.PrintSquare();
            }
            Console.ReadKey();
        }

        abstract class Shape
        {
            public abstract void PrintSquare();
        }

        class Triangle : Shape
        {
            public int side { get; set; }
            public int Height { get; set; }
            public int TriangleSquare { get; set; }

            public Triangle(int side, int height)
            {
                Height = height;
                TriangleSquare = side * height / 2;
            }

            public override void PrintSquare()
            {
                Console.WriteLine("Площа трикутника" + TriangleSquare);
            }
        }



        class Rectangle : Shape
        {
            public int SideA { get; set; }
            public int SideB { get; set; }
            public int RectangleSquare { get; set; }

            public Rectangle(int side, int sideb)
            {
                SideB = sideb;
                RectangleSquare = side * sideb;
            }
            public override void PrintSquare()
            {
                Console.WriteLine("Площа прямокутника" + RectangleSquare);
            }
        }


        class Circle : Shape
        {
            public static double P = 3.14;
            public double CircleSquare { get; set; }
            public int Radius { get; set; }

            public Circle(int side)
            {
                CircleSquare = P * side * side;
            }

            public override void PrintSquare()
            {
                Console.WriteLine("Площа кола" + CircleSquare);
            }
        }
    }
}

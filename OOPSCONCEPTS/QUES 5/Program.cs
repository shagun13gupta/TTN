using System;

namespace QUES_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("QUES 5: What is virtual method in c# ? Explain with program .........!!!\n");
            Shape obj = new Square();       //calling override area method of square derived class
            obj.area();
            Shape obj1 = new Rectangle();   //calling override area method of rectangle derived class
            obj1.area();
            Shape obj2 = new Shape();       //calling virtual method of base class
            obj2.area();
        }
    }

    public class Shape
    {
        public virtual void area()
        {
            Console.WriteLine("This is the area of the shape class....");
        }
    }
    public class Square:Shape
    {
        public override void area()
        {
            int s,a;
            Console.WriteLine("enter the side of a square.....");
            s = Convert.ToInt32(Console.ReadLine());
            a = s * s;
            Console.WriteLine("Area of square is {0}   ", a);
            Console.WriteLine("\n\n");
        }
    }

    public class Rectangle :Shape
    {
        public override void area()
        {
            int l, b,x;
            Console.WriteLine("enter the length of rectangle.....");
            l =Convert.ToInt32( Console.ReadLine());
            Console.WriteLine("enter the breadth of rectangle.....");
            b = Convert.ToInt32(Console.ReadLine());
            x = l * b;
            Console.WriteLine("Area of Rectangle is {0} ", x);
            Console.WriteLine("\n\n");


        }
    }
}

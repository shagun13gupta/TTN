using System;

namespace QUES2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("QUES 2:  What is method overloading and methodoverriding ? write a program .........!!");

            Area s = new Area();
            int a= s.area(2);      
            Console.WriteLine("area of square is {0} ",a);

            int b= s.area(3, 4);
            Console.WriteLine("area of rectangle is {0} ",b);

            Polygon pol = new Polygon();
            pol.show();            //calling show function of base class

            Polygon pol1 = new Quadrilateral();
            pol1.show();           //calling show function of derived class
        }
    }

    //Method overloading

    public class Area
    {
        public int area(int s)        
        {
            return 4 * s;
        }
        public int area(int a, int b)
        {           
            return a*b;
        }
    }


    //method overriding

    public class Polygon
    {
        public virtual void show()          //virtual method is used to override in the derived class
        {
            Console.WriteLine("It is a polygon class....");
        }
    }

    public class Quadrilateral:Polygon
    {
        public override void show()            //show function is override in the quadrilateral class
        {
            Console.WriteLine("It is a quadrilateral class.....");
        }
    }
}

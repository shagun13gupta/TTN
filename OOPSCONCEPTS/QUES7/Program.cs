using System;

namespace QUES7
{
    public class Shape
    {
        public Shape()
        {
            Console.WriteLine("default constructor of shape class....");
        }
        public Shape(string name)
        {
            Console.WriteLine("parametrized constructor with 1 parameter of Shape class");
        }
    }

    public class Hexagon:Shape
    {
        public Hexagon()
        {
            Console.WriteLine("default constructor of hexagon class.....");
        }
        public Hexagon(string name):base(name)     /*using base keyword now it will call the base class parametrized 
                                                     constructor first and then derived class constructor.
                                                     Otherwise first it calls the base class default constructor and 
                                                     then derived class parameterized constructor.*/
        {
            Console.WriteLine("parametrized constructor with 1 parameter of Hexagon class");
     
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("QUES 7: Write a program to for parameterised constructor and call the same from derived call.........!!!!\n\n");

            Hexagon hex = new Hexagon("hexagon");
            
        }
    }
}

using System;

namespace QUES6
{

    class A
    {
        public virtual void display()
        {
            Console.WriteLine("This is a virtual display method of A class");
        }
        public virtual void print()
        {
            Console.WriteLine("Print A class");
        }

    }
    class B : A
    {
        public override void display()
        {
            Console.WriteLine("This is a overriden display method of B class");
        }
        public sealed override void print()
        {
            Console.WriteLine("Print B class");
        }
    }
    class C:B
    {
        public override void display()
        {
            Console.WriteLine("This is a overriden display method of C class");
        }

        /*public override void print()
        { 
          we cannot override the print() method in this C class because it is sealed in the B class

        }*/
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("QUES 6: How to preventing Derived class from overriding virtual members?...........!!!!\n\n");
            A a = new B();
            a.display();     //display() method of B class is called
            a.print();       //print() method of B class is called
        
            C c = new C();
            c.display();     // display() method of C class is called
            c.print();       /*in this it will called Parent class print() method because it is sealed in parent class 
                               which cannot be inherited.*/
            Console.WriteLine("");
        }
    }
}

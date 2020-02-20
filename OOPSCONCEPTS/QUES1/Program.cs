using System;

namespace QUES1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("QUES 1:  What is the difference between abstract class and interface ? write a sample program to explain \n");
            AbstractClass abstractClass= new Circle();
            abstractClass.show();
            AbstractClass abstractClass1 = new Polygon();
            abstractClass1.show();
            B b = new B();
            b.display();
            C c = new C();
            c.display();
            
        }
    }
    public abstract class AbstractClass     
    {
        public abstract void show();  


    }
    public class Circle : AbstractClass
    {
        public override void show()
        {
            Console.WriteLine("This is a Circle class.......");
        }
    }
    public class Polygon : AbstractClass
    {
        public override void show()
        {
            Console.WriteLine("This is a polygon class........");
        }
    }
    public interface A
    {
        void display();          /*By default all the members of the interface are abstract.We can't create the object 
                                  of the interface .And interface can't be inherited.*/
    }
    public class B : A
    {
        public void display()
        {
            Console.WriteLine("This is B class...");
        }
    }
    public class C : A
    {
        public void display()
        {
            Console.WriteLine("This is C class.....");
        }
    }

}

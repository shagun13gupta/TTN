using System;

namespace QUES1
{
    class Program
    {
        static void Main(string[] args)
        {

            NonStaticClass obj = new NonStaticClass();
            Console.WriteLine(" QUES 1:   Difference between static and instance members.....................!!!!!\n\n");
            
            Console.WriteLine("The value of a is   " + StaticClass.a);    //accessed static member using  class name
            Console.WriteLine("The value of b is   " + obj.b);       //accessed instance member using object 
        }
    }

    public static class StaticClass
    {
        public static int a = 10;     /* STATIC MEMBER ( when a member is declared as static then a single copy of that 
                                                         variable is created and shared among all objects. 
                                                         Static members are called by the class name without creating
                                                         the instance of class) */
    }

    public class NonStaticClass
    {
        public int b = 20;        /*INSTANCE MEMBER( instance member are those members which are called by creating the 
                                                     objects of that class ) */

    }
}

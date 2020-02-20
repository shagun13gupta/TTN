using System;

namespace QUES4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("QUES 4:  What are the different ways a method can be overloaded ? write a program ..........!!!!\n\n");

            Test test = new Test();

            test.func(10);        //integer type single parameter constructor called
            test.func("shagun");  //string type single parameter constructor called
            test.func(10, 2.1);   //two parameterized constructor of integer and double type called
            test.func(10, "priya");  //two parametrized constructor of integer and string type called
            test.func(10, 2.1, "sneha");  //three parametrized constructor of integer,double and string called
                              
        }
    }

    public class Test
    {
        public void func(int a)
        {
            Console.WriteLine("Integer type constructor called\n");
        }
        public void func(string a)
        {
            Console.WriteLine("String type constructor called\n");
        }
        public void func(int a, double b)
        {
            Console.WriteLine("Integer and float type constructor called\n");
        }
        public void func(int a,string b)
        {
            Console.WriteLine("Integer and string type constructor called\n");
        }
        public void func(int a,double b,string c)
        {
            Console.WriteLine("Integer,float and string type constructor called\n");
        }
    }
}

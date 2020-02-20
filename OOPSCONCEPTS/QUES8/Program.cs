using System;

namespace QUES8
{
    
    class Arithmetic
    {
        private int a, b;       //members declared as private
        
        public Arithmetic()
        {
            a = 0;
            b = 0;
        }
        
        public int add(int a,int b)    //private members are used within a public method of same class
        {
            return a + b;
        }
               
    }    
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("QUES 8: - Write a program to explain encapsulation and abstraction........!!!!\n\n");

            int input1, input2,sum=0;
            Console.WriteLine("enter first input");
            input1=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter second input");
            input2 = Convert.ToInt32(Console.ReadLine());

            Arithmetic arithmetic = new Arithmetic();
            sum=arithmetic.add(input1, input2);
            Console.WriteLine("the sum of two numbers is {0}", sum);
            
        }
    }
}

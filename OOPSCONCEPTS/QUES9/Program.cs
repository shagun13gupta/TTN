using System;

namespace QUES9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("  QUES 9: OPERATOR OVERLOADING..........!!!!!\n");

            Overloading overloading = new Overloading(3, 4);
            //overloading.display();
            Overloading overloading1 = new Overloading(6, 7);
            //overloading1.display();
            Overloading overloading2 = new Overloading();
            overloading2 = overloading * overloading1;
            overloading2.display();

        }
    }
    class Overloading
    {
        public int num1,num2;

        public Overloading()
        {
            num1 = 0;
            num2 = 0;
        }
        public Overloading(int a,int b)
        {
            num1 = a;
            num2 = b;
        }
        public static Overloading operator *(Overloading overloading1,Overloading overloading2)
        {
            Overloading over = new Overloading();
            over.num1 = overloading1.num1 * overloading1.num2;
            over.num2 = overloading2.num1 * overloading2.num2;
            return over;

        }
        public void display()
        {
            Console.WriteLine("{0} {1}", num1, num2);
        }

    }
}

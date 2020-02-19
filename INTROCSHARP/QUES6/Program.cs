using System;

namespace QUES6
{

    public class ModifierClass
    {
        private int x= 10;         //private access modifier
        public int y = 20;         //public access modifier
        protected int z ;          //protected access modifier
        internal int a = 40;       //internal access modifier
        protected internal int b = 50;             //protected internal access modifier

        public void print()
        {
            Console.WriteLine("the value of x i.e (using private modifier used within the class only) is {0}", x);
        }
        
       

    }

    public class DerivedClass:ModifierClass
    {
        public DerivedClass()
        {
            z = 30;
        }
        public void show()
        {
            Console.WriteLine("the value of z i.e (using protected modifier used in the derived class only) is {0}", z);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            ModifierClass obj = new ModifierClass();
            DerivedClass obj1 = new DerivedClass();
            
            Console.WriteLine("QUES 6:  Write a program to define the scope of different access modifiers?.................!!!\n");
            obj.print();
            Console.WriteLine("the value of y i.e (using public modifier access from anywhhere) is {0} ", obj.y);
            obj1.show();
            Console.WriteLine("the value of a i.e (using internal modifier access only within the same asssembly) is {0}  ",obj.a);
            Console.WriteLine("the value of b i.e (using protected internal modifier) is  {0}  ", obj.b);

        }
    }
}

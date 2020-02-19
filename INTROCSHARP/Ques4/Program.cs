using System;

namespace Ques4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("QUES 4:  Write a program to define the boxing and unboxing concepts?......................!!!\n");
            int num = 20;
            object obj = (int)num;    //BOXING
                                      /* The process of converting the value type into the refrence type is called boxing
                                         The value type is stored in stack whereas reference type is stored in heap*/
            Console.WriteLine("After boxing the value of object is {0} \n",obj);
            int i = (int)obj;         //UNBOXING
                                      /* The process of converting the reference type into value type is called unboxing*/
            Console.WriteLine("After unboxing the value of object is {0}", i);
        }
    }
}

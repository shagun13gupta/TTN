using System;

namespace QUES7
{
    class Program
    {
        static void Main(string[] args)
        {
            String str,str1="";
            int len,i;
            Console.WriteLine("QUES 7:   Write a program to reverse your full name without using an inbuilt function? \n\n");
            Console.WriteLine("Enter the string........!!");
            str = Console.ReadLine();
            len = str.Length;         //string length
            for(i=len-1;i>=0;i--)
            {
                str1 = str1 + str[i];
            }
            Console.WriteLine("reverse string is =  {0} ", str1);
        }
    }
}

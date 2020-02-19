using System;

namespace QUES2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" QUES 2:     TO CHECK THE LEAP YEAR  ......................!!!!!!! \n\n");
            Console.WriteLine("Enter the year \n");
            int year = Convert.ToInt32(Console.ReadLine());

            /* Leap year is that year which is divisible by 4 and 400 but not divisible by 100
              Example : because century is not necessary to be leap year unless it is divisible by 400*/

            if( ( (year % 4) == 0) && ( (year % 100) != 0)  || (year % 400 == 0) )
            {
                Console.WriteLine("Year is leap year\n");
            }
            else
            {
                Console.WriteLine("year is ordinary year");
            }

        }
    }
}

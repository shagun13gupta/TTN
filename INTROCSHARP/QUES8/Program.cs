using System;

namespace QUES8
{
    class Program
    {
        static void Main(string[] args)
        {
            int i,j;
            Console.WriteLine("QUES 8: Write a program in C# Sharp to display the multiplication table vertically from 1 to 5 ...............!!!!!!!\n\n");
            
            
            for (i = 1; i <= 10; i++)
            {
                for (j = 1; j <= 5; j++)
                {
                    
                    if (j <= 5)
                        Console.Write("{0}x{1} = {2}, ", j, i, i * j);
                  

                }
                Console.Write("\n");
            }
        }
    }
}

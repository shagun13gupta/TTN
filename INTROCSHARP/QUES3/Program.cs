using System;

namespace QUES3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("QUES 3: . Write a program To find Constant & vowel using both Switch case & if_else?..........!!!! \n");
            Console.WriteLine("enter the choice \n 1 .if_else  \n 2: switch case");
            int choice = Convert.ToInt32(Console.ReadLine());
            Vowel v = new Vowel();
            switch (choice)
            {
                case 1:
                    v.iff_else();
                    break;
                case 2:
                    v.switch_case();
                    break;
                default:
                    Console.WriteLine("entered wrong choice..............");
                    break;
                    
            }
          
        }
    }

    class Vowel
    {
        public void switch_case()
        {
            char choice1;
            do
            {
                Console.Write("Enter the character (A-Z or a-z) : ");
                char ch1 = Convert.ToChar(Console.ReadLine().ToLower());
                int i = ch1;
                if (i >= 48 && i <= 57)
                {
                    Console.Write("You entered a number, Please enter an alpahbet.");
                }
                else
                {
                    switch (ch1)
                    {
                        case 'a':
                            Console.WriteLine("vowel");
                            break;
                        case 'e':
                            Console.WriteLine("vowel");
                            break;
                        case 'i':
                            Console.WriteLine("vowel");
                            break;
                        case 'o':
                            Console.WriteLine("vowel");
                            break;
                        case 'u':
                            Console.WriteLine("vowel");
                            break;
                        default:
                            Console.WriteLine("consonant");
                            break;

                    }
                }

                Console.WriteLine("Do you want to enter more.....?if Yes then enter  'Y' OR 'y'  ....!!\n");
                choice1 = Convert.ToChar(Console.ReadLine());

            } while (choice1 == 'Y' || choice1 == 'y');
        }


        public void iff_else()
        {
            char choice;
            do
            {
                Console.WriteLine("Enter the Character");
                char ch = Convert.ToChar(Console.ReadLine());
                if ((ch >= 'A' && ch <= 'Z') || ch >= 'a' && ch <= 'z')
                {
                    if (ch == 'a' || ch == 'A' || ch == 'e' || ch == 'E' || ch == 'i' || ch == 'I' || ch == 'o' || ch == 'O' || ch == 'u' || ch == 'U')
                    {
                        Console.WriteLine("Charcater {0} is a vowel   ", ch);
                    }
                    else
                    {
                        Console.WriteLine("Character {0} is a consonant  ", ch);
                    }
                }

                Console.WriteLine("Do you want to enter more.....?if Yes then enter  'Y' OR 'y'  ....!!\n");
                choice = Convert.ToChar(Console.ReadLine());
            } while (choice == 'Y' || choice == 'y');

        }
    }
     
}


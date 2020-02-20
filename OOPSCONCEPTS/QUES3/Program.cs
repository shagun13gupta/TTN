using System;

namespace QUES3
{
    interface Square
    {
        void display();          
    }
    interface Rectangle
    {
        void display();        //different interface wwith same method display()
    }

    class Program :Square,Rectangle
    {
        public void display()
        {
            Console.WriteLine("both display function show same defination.....");     //defination of abstract method in the interface
        }
        

        static void Main(string[] args)
        {
            Console.WriteLine("QUES 3:  What would happen in case if the inherited interfaces have conflicting method names\n");
            Program con = new Program();
            con.display();           
        }
    }

 
  
}

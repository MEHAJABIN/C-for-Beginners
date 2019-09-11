using System;

namespace Understanting_Datatypes_Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            //single Datatype with different variables and a + operator

             int x = 7;
             int y = x + 3;
             Console.WriteLine(y);
             Console.ReadLine();
 
        
        /*--------------------------------------------------------------------------------------------*/

            //program using string concatenation
            Console.WriteLine("What is Your Name: ");
            Console.Write("Type your FirstName: ");
            string myFirstName;
            myFirstName = Console.ReadLine();

            /* Console.Write("Type your LastName:");
             string myLastName;
             myLastName = Console.ReadLine();*/

            //The simplest form of myLastname
            Console.WriteLine("Type Your LastName: ");
            string myLastName = Console.ReadLine();

            Console.WriteLine("Hello," + myFirstName + " " + myLastName +" ");
            Console.ReadLine();
        }
    }
}

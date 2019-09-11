using System;

namespace If_statement
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Console.WriteLine("Hi iam mehjabin");
              Console.Write("choose a no. 1,2 or 3 :");
             string userValue = Console.ReadLine();
             string Message = "";
             if (userValue == "1")
             {
                  Message = "She is good";
             }
             else if (userValue == "2")
             {
                Message = "she is awesome";


             }
             else if (userValue == "3")
             {
                 Message = "she is intelligent";

             }
             else
             {
                  Message = "We didn't get";
                 Message += "You Lose";    // using assignment operator

             }
             Console.WriteLine(Message);
             Console.ReadLine();*/

            Console.WriteLine("Hi iam mehjabin");
            Console.Write("choose a no. 1,2 or 3 :");
            string userValue = Console.ReadLine();

            string Message = (userValue == "1") ?  "boat": "Its Luxuries"; //using Conditional opertor
          /* Console.Write("You Won a ");
           Console.Write(Message);
           Console.Write(".");*/
                                                            


            //Another simple method for value distribution
            Console.WriteLine("You entered: {0}, therefore You won a {1}.", userValue, Message);
                       

            Console.ReadLine();
        }
        
    }
}

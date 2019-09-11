using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //Array program using int Datatype
            int[] numbers = new int[5];

            numbers[0] = 4;
            numbers[1] = 8;
            numbers[2] = 15;
            numbers[3] = 16;
            numbers[4] = 23;

            Console.WriteLine(numbers[3]);   //To get corresponding array value.
            Console.WriteLine(numbers.Length); // To get total length of the array.
            Console.ReadLine();


            int[] numbers = new int[] { 4, 8, 15, 16, 23, 25 };

            Console.WriteLine(numbers[5]);   //To get corresponding array value.

            Console.WriteLine(numbers.Length); // To get total length of the array.
            Console.ReadLine();


            //Array program using string Datatype
            string[] names = new string[] { "Anu", "Neenu", "Ancy", "Riny", "Akku" };


            //Another simplest code for list of names
            foreach (string name in names)
            {
               Console.WriteLine(name);
            }
            Console.ReadLine();



            //Reverse of a Array string

            string zig = "She is pretty"; //using simple string


            //string zig = "She is pretty" + "she is intelligent"; //using concatenation
            char[] charArray = zig.ToCharArray();
            Array.Reverse(charArray);

            foreach(char zigChar in charArray)
            {
                Console.WriteLine(zigChar);
            }
            Console.ReadLine();

          
        }
    }
}

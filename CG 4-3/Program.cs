using System;

namespace CG_4_3
{
    class Program
    {
        static void Main(string[] args)
        {
            // ask the user for a number value
            Console.Write("Hello there, please enter a numer:  ");
            
            // convert the user input to an int 
            string userValue = Console.ReadLine();
            int Value = int.Parse(userValue);

            // set total to zero for upcoming math
            int total = 0;

            // setting the loop to run from 2 to 20
            for (int i = 2; i < 21; i++)
            {
                // multiplying the user input by the about run
                Console.WriteLine(i * Value);
                //for grand total we're saying add all i's * user input for grand total
                total += i * Value;
            }
            // outputting the grand total
            Console.Write(total);
            Console.ReadLine();

        }
    }
}

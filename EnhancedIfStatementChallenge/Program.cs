using System;

namespace EnhancedIfStatementChallenge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the current temperature in Celcius.");
            string tempInput = Console.ReadLine();

            //test to make sure can convert the input to an int
            bool converted = int.TryParse(tempInput, out int result); 
            if (converted)
            {
                //if able to convert, displays the message
                string tempMessage = result <= 15 ? "it is too cold here" : result > 28 ? "it is hot here" : "it is ok";
                Console.WriteLine(tempMessage);
            }
            else
            {
                // displays if the input is not an int
                Console.WriteLine("Not a valid Temperature.  Please enter a whole number.");
            }

            Console.Read();
        }


    }
}

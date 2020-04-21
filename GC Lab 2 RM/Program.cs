using System;

namespace GC_Lab_2
{
    class Program
    {
        static void Main(string[] args)
        {

            string prompt;

            // INTRODUCTION to the user
            Console.WriteLine("Welcome to the Grand Circus Room Detail Generator!");
            Console.WriteLine("You will be prompted for the dimensions of a room.");
            Console.WriteLine("");
            Console.WriteLine("Please enter all values as decimals, not feet and inches.");

            do
            {
               
                // INPUT - prompting user for input
                Console.WriteLine("Enter Room Length: ");
                string inputLength = Console.ReadLine();

                Console.WriteLine("Enter Room Width: ");
                string inputWidth = Console.ReadLine();

                Console.WriteLine("Enter Room Height: ");
                string inputHeight = Console.ReadLine();


                // Calculating Area, Perimiter, and Volume
                double length = double.Parse(inputLength);
                double width = double.Parse(inputWidth);
                double height = double.Parse(inputHeight);

                double perimeter = 2 * length + 2 * width;
                double area = length * width;
                double volume = area * height;


                // Output room calculations to user
                Console.WriteLine("");
                Console.WriteLine($"Room area: {area}");
                Console.WriteLine($"Room perimeter: {perimeter}");
                Console.WriteLine($"Room volume: {volume}");


                //Prompt for calculating additional rooms
                Console.WriteLine("");
                Console.WriteLine("Would you like to calculate another room? Y/N");
                prompt = Console.ReadLine();

            } while (prompt.Contains("y"));

            Console.WriteLine("Okay, thanks, bye!");

        }
    }
}

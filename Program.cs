using System;

namespace PackageExpress
{
    class Program
    {
        static void Main(string[] args)
        {
            // Display the welcome message
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

            // Prompt user to enter the package weight
            Console.Write("Please enter the package weight: ");
            double weight = Convert.ToDouble(Console.ReadLine());

            // Check if the weight is over the limit
            if (weight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                // Exit the program
                return;
            }

            // Prompt user to enter package width
            Console.Write("Please enter the package width: ");
            double width = Convert.ToDouble(Console.ReadLine());

            // Prompt user to enter package height
            Console.Write("Please enter the package height: ");
            double height = Convert.ToDouble(Console.ReadLine());

            // Prompt user to enter package length
            Console.Write("Please enter the package length: ");
            double length = Convert.ToDouble(Console.ReadLine());

            // Calculate the sum of dimensions
            double dimensionTotal = width + height + length;

            // Check if the total dimension is too large
            if (dimensionTotal > 50)
            {
                Console.WriteLine("Package too big to be shipped via Package Express.");
                // Exit the program
                return;
            }

            // Calculate the shipping quote using the formula
            double quote = (width * height * length * weight) / 100;

            // Display the calculated quote with formatting
            Console.WriteLine("Your estimated total for shipping this package is: $" + quote.ToString("F2"));
            Console.WriteLine("Thank you!");
        }
    }
}

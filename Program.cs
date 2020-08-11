using System;

namespace VariablesCS
{
    class Program
    {
        static void Main(string[] args)
        {
            var numberOfCupsOfCoffee = 2;
            var fullName = "Michael Rushing";
            var today = "08/11/2020";
            Console.WriteLine($"{numberOfCupsOfCoffee}, {fullName}, {today}");

            Console.WriteLine("What is you name?");
            var userName = Console.ReadLine();
            Console.WriteLine($"Good day {userName}");

            Console.WriteLine("Please provide two random numbers");
            var firstNumberAsString = Console.ReadLine();
            var secondNumberAsString = Console.ReadLine();

            var firstOperand = Double.Parse(firstNumberAsString);
            var secondOperand = Double.Parse(secondNumberAsString);

            var sum = firstOperand + secondOperand;
            Console.WriteLine($"Your first number plus you second number equals {sum}");

            var difference = firstOperand - secondOperand;
            Console.WriteLine($"Your first number minus your second number equals {difference}");

            var product = firstOperand * secondOperand;
            Console.WriteLine($"Your first number multiplied by your second number equals {product}");

            var quotient = firstOperand / secondOperand;
            Console.WriteLine($"Your first number divided by your second number equals {quotient}");

            var remainder = firstOperand % secondOperand;
            Console.WriteLine($"Your first number divided by your second number leaves a remainder of {remainder}");


        }
    }
}

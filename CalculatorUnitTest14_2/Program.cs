using System;

namespace CalculatorUnitTest14_2
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //try
            //{
                 //Program  for the variables first number, second number, answer and operation.  Using double allows for fractions.
                double firstnumber = 0;
                double secondnumber = 0;
                double answer = 0;
                string operation = " ";

                //Ask the user to input the first number.
                Console.WriteLine("Welcome to a simple calculator. Please enter a simple math calculation " +
                    "using (/, x, +, -). Write the calculation as: number, space, operator, space number, IE: 2 + 2");
                //Print the user input to the console.

                string input = Console.ReadLine();

                var parts = input.Split(" ");

                if (parts != null)
                {
                    firstnumber = Convert.ToDouble(parts[0]);
                    operation = parts[1];
                    secondnumber = Convert.ToDouble(parts[2]);
                }
                //Checks if the variable to the cases, if not the default is selected. Break has to be used to exit the curly brackets.
                switch (operation)
                {
                    case "x":
                        answer = Operators.Multiply(firstnumber, secondnumber);
                        Console.WriteLine(firstnumber + " x " + secondnumber + " = " + answer);
                        break;

                    case "/":
                        answer = Operators.Divide(firstnumber, secondnumber);
                        Console.WriteLine(firstnumber + " / " + secondnumber + " = " + answer);
                        if (secondnumber == 0)
                        {
                            Console.WriteLine("Cannot divide by 0, please try again.");
                        }
                        break;

                    case "+":
                        answer = Operators.Addition(firstnumber, secondnumber);
                        Console.WriteLine(firstnumber + " + " + secondnumber + " = " + answer);
                        break;

                    case "-":
                        answer = Operators.Minus(firstnumber, secondnumber);
                        Console.WriteLine(firstnumber + " - " + secondnumber + " = " + answer);
                        break;

                    default:
                        Console.WriteLine("Invalid operator");
                        break;
                }
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine("Incorrect format.  Must be number, operator, number with spaces in between each.");
            //}
            Console.ReadLine();
        }
    }
}
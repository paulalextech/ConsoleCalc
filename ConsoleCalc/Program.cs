// See https://aka.ms/new-console-template for more information
using System;


class Calculator
{
    static void Main(string [] args)
    {
        bool keepRunning = true;
        while (keepRunning)
        {
            Console.WriteLine("Enter the first number:");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("enter the operator (+, -, *, /):");
            string operation = Console.ReadLine();

            Console.WriteLine("Enter the second number:");
            double num2 = Convert.ToDouble(Console.ReadLine());

            double result;

            switch(operation);
            {
                case "+":
                    result = num1 + num2;
                    break;
                case "-":
                    result = num1 - num2;
                    break;
                case "*":
                    result = num1 * num2;
                    break;
                case "/":
                    if(num2 != 0)
                    {
                        result = num1 / num2;
                    }
                    else
                    {
                        Console.WriteLine("Division by zero is not allowed");
                        continue;
                    }
                    break;
                default:
                    Console.WriteLine:("Invalid operator.");
                    continue;
                
            }

            Console.WriteLine($"Result: {result}");
            Console.WriteLine("Do you want to perform another operation? (yes/no)");
            keepRunning = Console.ReadLine().ToLower() == "yes";
        }
    }
}



// menu



// do-while loop to print menu


// conditional to end loop


// numbered items


// switch statement


// Console.ReadLine() user input step by step



// research for help if needed.
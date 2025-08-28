using System;

namespace Calculator
{
    public class CalculatorApp
    {
        
        public static double Add(double a, double b) => a + b;

        public static double Subtract(double a, double b) => a - b;

        public static double Multiply(double a, double b) => a * b;

        public static double Divide(double a, double b)
        {
            if (b == 0)
            {
                Console.WriteLine("Error: Cannot divide by zero.");
                return double.NaN;
            }
            return a / b;
        }

        public static void Main()
        {
            bool running = true;

            while (running)
            {
                Console.WriteLine("\n--- Calculator Menu ---");
                Console.WriteLine("1. Add");
                Console.WriteLine("2. Subtract");
                Console.WriteLine("3. Multiply");
                Console.WriteLine("4. Divide");
                Console.WriteLine("5. Exit");
                Console.Write("Choose an option: ");
                string? choice = Console.ReadLine();

                if (choice == "5")
                {
                    Console.WriteLine("Goodbye!");
                    break;
                }

                Console.Write("Enter the first number: ");
                double num1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter the second number: ");
                double num2 = Convert.ToDouble(Console.ReadLine());

                double result = 0;

                switch (choice)
                {
                    case "1":
                        result = Add(num1, num2);
                        break;
                    case "2":
                        result = Subtract(num1, num2);
                        break;
                    case "3":
                        result = Multiply(num1, num2);
                        break;
                    case "4":
                        result = Divide(num1, num2);
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        continue;
                }

                if (!double.IsNaN(result))
                    Console.WriteLine($"Result: {result}");
            }
        }
    }
}

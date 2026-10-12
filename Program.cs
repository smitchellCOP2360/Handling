using System;

namespace DivisionExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Division and Conversion Exception Handler ===");
            Console.WriteLine("Type 'exit' at any prompt to quit.\n");

            while (true)
            {
                Console.Write("Enter the first number (numerator): ");
                string input1 = Console.ReadLine();
                if (input1.Equals("exit", StringComparison.OrdinalIgnoreCase)) break;

                Console.Write("Enter the second number (denominator): ");
                string input2 = Console.ReadLine();
                if (input2.Equals("exit", StringComparison.OrdinalIgnoreCase)) break;

                // Call the custom division function
                ConvertAndDivide(input1, input2);
                Console.WriteLine(new string('-', 40));
            }
        }

        public static void ConvertAndDivide(string strNumerator, string strDenominator)
        {
            try
            {
                int numerator = Convert.ToInt32(strNumerator);
                int denominator = Convert.ToInt32(strDenominator);

                int result = numerator / denominator;
                Console.WriteLine($"Success: {numerator} / {denominator} = {result}");
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Error: One or both inputs are not valid integers.");
                Console.WriteLine($"System Message: {ex.Message}");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Error: You cannot divide a number by zero.");
                Console.WriteLine($"System Message: {ex.Message}");
            }
            catch (OverflowException ex)
            {
                Console.WriteLine("Error: One of the numbers entered falls outside the range of a 32-bit integer.");
                Console.WriteLine($"System Message: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine("An unexpected error occurred.");
                Console.WriteLine($"System Message: {ex.Message}");
            }
        }
    }
}

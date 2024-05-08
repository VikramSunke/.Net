using Recursion.Operations;
namespace Recursion.OperationsHelper
{
    public class RecursionHelper
    {
        RecursionOperations recursionOperations = new RecursionOperations();
        public void CalculateFactorial()
        {
            try
            {
                Console.WriteLine("\nEnter a number to find its factorial: ");
                long number = long.Parse(Console.ReadLine());
                long result = recursionOperations.Factorial(number);
                Console.WriteLine($"\nFactorial of {number} is {result}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }

        public void CalculateFibonacci()
        {
            try
            {
                Console.WriteLine("\nEnter the number to find its Fibonacci number: ");
                long number = long.Parse(Console.ReadLine());
                long result = recursionOperations.Fibonacci(number);
                Console.WriteLine($"\nFibonacci number of {number} is {result}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }
    }
}

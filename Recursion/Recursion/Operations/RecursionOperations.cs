namespace Recursion.Operations
{
    public class RecursionOperations
    {
        public long Factorial(long number)
        {
            if(number == 0)
                return 1;
            return number * Factorial(number - 1);
        }
        public long Fibonacci(long number)
        {
            if (number <= 1)
                return number;
            return Fibonacci(number - 1) + Fibonacci(number - 2);
        }
    }
}

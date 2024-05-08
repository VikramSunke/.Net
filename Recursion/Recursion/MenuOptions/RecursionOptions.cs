using Recursion.OperationsHelper;
namespace Recursion.MenuOptions
{
    public enum MenuOptions
    {
        FactorialOfInteger,
        FibonacciNumber,
        Quit
    }

    public class RecursionOptions
    {
        public static void userOptions()
        {
            bool executeMethod = true;
            while(executeMethod)
            {
                Console.WriteLine("\nChoose your option \n0.Factorial of integer\n1.Fibonacci Number\n2.Quit");
                try
                {
                    RecursionHelper recursionHelper = new RecursionHelper();

                    int choice = GetUserInput();

                    MenuOptions selectedOption = (MenuOptions)choice;
                    switch (selectedOption)
                    {
                        case MenuOptions.FactorialOfInteger:
                            recursionHelper.CalculateFactorial();
                            break;
                        case MenuOptions.FibonacciNumber:
                            recursionHelper.CalculateFibonacci();
                            break;
                        case MenuOptions.Quit:
                            executeMethod = false;
                            Console.WriteLine("\nExiting program...");
                            break;
                        default:
                            Console.WriteLine("\nInvalid option selected.");
                            break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
        static int GetUserInput()
        {
            while (true)
            {
                try
                {
                    return Convert.ToInt32(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.WriteLine("\nInvalid input. Please enter integer value: ");
                }
            }
        }
    }
   
}

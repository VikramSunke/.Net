namespace Loops
{
    public class Program
    {
        static void Main(string[] args)
        {
            Task1 task1 = new Task1();

            bool continueOperations = true;
            while (continueOperations)
            {
                Console.WriteLine(" \n\nChoose your option: \n 1.PrintNumbers \n 2.PrintEvenNumbers \n 3.MultiplicationTable \n " +
                    "4.FactorialCalculation \n 5.ReverseString \n 6.PrimeNumbers \n 7.SumOfDigits \n " +
                    "8.FibonacciSequence \n 9.PatternPrinting() \n 10.SumOfSeries \n 11.Quit\n");
                int option = Convert.ToInt32(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        task1.PrintNumbers();
                        break;
                    case 2:
                        task1.PrintEvenNumbers();
                        break;
                    case 3:
                        task1.MultiplicationTable();
                        break;
                    case 4:
                        task1.FactorialCalculation();
                        break;
                    case 5:
                        task1.ReverseString();
                        break;
                    case 6:
                        task1.PrimeNumbers();
                        break;
                    case 7:
                        task1.SumOfDigits();
                        break;
                    case 8:
                        task1.FibonacciSequence();
                        break;
                    case 9:
                        task1.PatternPrinting();
                        break;
                    case 10:
                        task1.SumOfSeries();
                        break;
                    case 11:
                        Console.WriteLine("\nYou have exited");
                        continueOperations = false;
                        break;
                    default:
                        Console.WriteLine("\nInvalid option. Please choose again.");
                        break;
                }
            }
        }
    }
}

namespace Loops
{
    public class Task1
    {
        public void PrintNumbers()
        {
            int n = 100;
            Console.WriteLine("\nSeries of numbers from 1 to 100 : ");
            for (int i = 1; i <= n; i++)
            {
                Console.Write($"{i}\t");
            }
        }
        public void PrintEvenNumbers()
        {
            int n = 100;
            Console.Write("\nEven Numbers from 1 to 100: ");
            for (int i = 1; i <= n; i++)
            {
                if (i % 2 == 0)
                    Console.Write($"{i}\t");

            }
        }
        public void MultiplicationTable()
        {
            Console.Write("Enter table number: ");
            int tableNumber = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter table limit(e.g .. 10): ");
            int n = Convert.ToInt32(Console.ReadLine());
            int i = 1;
            while (i <= n)
            {
                Console.WriteLine($"{tableNumber} * {i} = {tableNumber * i}");
                i++;
            }
        }

        public void FactorialCalculation()
        {
            Console.WriteLine("Enter number for factorial calculation: ");
            int num = Convert.ToInt32(Console.ReadLine());
            int factOfNum = 1;
            for (int i = num; i > 0; i--)
            {
                factOfNum *= i;

            }
            Console.WriteLine($"Factorial of {num} is {factOfNum}");

        }

        public void ReverseString()
        {
            Console.WriteLine("Enter the text you want to reverse");
            string text = Console.ReadLine();
            string reversedText = "";

            for (int i = text.Length - 1; i >= 0; i--)
            {
                reversedText += text[i];
            }
            Console.WriteLine("Reversed text: " + reversedText);
        }
        public void PrimeNumbers()
        {
            int n = 100;

            Console.WriteLine("Prime Numbers: ");
            for (int i = 2; i <= n; i++)
            {
                bool isPrime = true;
                for (int j = 2; j <= Math.Sqrt(i); j++)
                {
                    if (i % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                {
                    Console.Write(i + " ");
                }
            }
        }

        public void SumOfDigits()
        {
            Console.WriteLine("Enter number to do sum of its digits: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int rem,sum=0;
            while(n>0)
            {
                rem = n % 10;
                sum = sum + rem;
                n = n/10;
               
            }
            Console.WriteLine($"Sum of its digits of a given number: {sum}");
        }

        public void FibonacciSequence()
        {
            Console.WriteLine("Enter the limit of the fibonacci sequence : ");
            int n= Convert.ToInt32(Console.ReadLine());
            int i = 0,a=0,b=1,c;
            Console.Write($"{a}\t{b}\t");
            while (i<n)
            {
                c = a + b;
                a = b;
                b = c;
                Console.Write($"{c}\t");
                i++;
            }
        }

        public void PatternPrinting()
        {
            for(int i=0;i<5;i++)
            {
                for(int j=0;j<=i;j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }

        public void SumOfSeries()
        {
            Console.WriteLine("Enter nth number to do sum of series: ");
            float n = Convert.ToSingle(Console.ReadLine());
            float sum = 1f; 
            for (int i = 2; i <= n; i++)
            {
                sum += 1f / i;
            }
            Console.WriteLine($"Sum of series: {sum}");
        }

    }
}

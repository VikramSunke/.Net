using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    public class Task1
    {
        public void PrintNumbers()
        {
            int n = 100;
            Console.WriteLine("\nseries of Numbers : ");
            for (int i = 1; i <= n; i++)
            {
                Console.Write(i + " ");
            }
        }
        public void PrintEvenNumbers()
        {
            int n = 100;
            Console.Write("\nEven Numbers: ");
            for (int i = 1; i <= n; i++)
            {
                if (i % 2 == 0)
                { Console.Write(i + " "); }
            }
        }
        public void MultiplicationTable()
        {
            Console.Write("Enter Table Number: ");
            int tableNumber = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Table limit(e.g .. 10): ");
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
            for(int i = 1; i < n; i++)
            {
                int count = 0;
                for(int j=1;j<= i; j++)
                {
                    if(i%j==0)
                    {
                        count += 1;
                    }

                }
                if(count==2)
                {
                    Console.Write(i+" ");
                }
                
            }
        }

        public void SumOfDigits()
        {
            Console.WriteLine("Enter number to do Sum of its digits: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int rem,sum=0;
            while(n>0)
            {
                rem = n % 10;
                sum =sum+ rem;
                n = n/10;
               
            }
            Console.WriteLine($"sum of Digits of a given number: {sum}");
        }

        public void FibonacciSequence()
        {
            Console.WriteLine("Enter the Limit of the Fibonacci Sequence : ");
            int n= Convert.ToInt32(Console.ReadLine());
            int i = 0,a=0,b=1,c;
            Console.Write($"{a} {b} ");
            while (i<n)
            {
                c = a + b;
                a = b;
                b = c;
                Console.Write(c + " ");
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
            Console.WriteLine("Enter nth number to sum of series: ");
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

using System.Reflection.Metadata.Ecma335;

namespace Permutations
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the text: ");
            string str = Console.ReadLine();

            char[] charArray = str.ToCharArray();
            Console.WriteLine($"All possible permutations of the {str} : ");
            GeneratePermutations(charArray.Length, charArray);
        }
        static void GeneratePermutations(int k, char[] A)
        {
            if (k == 1)
                Console.WriteLine(A);  
            else
            {
                GeneratePermutations(k - 1, A);
                for (int i = 0; i < k - 1; i++)
                {
                    if (k % 2 == 0)
                    {
                        char temp = A[i];
                        A[i] = A[k - 1];
                        A[k - 1] = temp;
                    }
                    else
                    {
                        char temp = A[0];
                        A[0] = A[k - 1];
                        A[k - 1] = temp;
                    }
                    GeneratePermutations(k - 1, A);
                }
            }
        }
    }
}

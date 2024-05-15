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
        static void GeneratePermutations(int length, char[] charArray)
        {
            if (length == 1)
                Console.WriteLine(charArray);  
            else
            {
                GeneratePermutations(length - 1, charArray);
                for (int i = 0; i < length - 1; i++)
                {
                    if (length % 2 == 0)
                    {
                        char temp = charArray[i];
                        charArray[i] = charArray[length - 1];
                        charArray[length - 1] = temp;
                    }
                    else
                    {
                        char temp = charArray[0];
                        charArray[0] = charArray[length - 1];
                        charArray[length - 1] = temp;
                    }
                    GeneratePermutations(length - 1, charArray);
                }
            }
        }
    }
}

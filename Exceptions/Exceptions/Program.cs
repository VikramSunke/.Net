namespace Exceptions
{
    public class Program
    {
        static void Main(string[] args)
        {

            //Basic Exception handling
            try
            {
                Console.WriteLine("Enter first number: ");
                int num1 = GetUserInput();    //It handles Format Exception for user input

                Console.WriteLine("Enter second number: ");
                int num2 = GetUserInput();
                int result = num1 / num2;
                Console.WriteLine($"Result of division is {result}");
            }
           
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch(Exception ex)
            {
                Console.WriteLine($"Error occurred: {ex.Message}");
            }



            //Custom Exception handling
            try
            {
                Console.WriteLine("Enter a value: ");
                int value = GetUserInput();

                if (value < 0)
                {
                    throw new InvalidInputException("Negative value not allowed");
                }


                if (value < 1 || value > 100)
                {
                    throw new ValueOutOfRangeException("Value must be between 1 and 100.");
                }
            }
            catch ( InvalidInputException ex)
            {
                Console.WriteLine($"Invalid Input:{ex.Message}");
            }
            catch(ValueOutOfRangeException ex)
            {
                Console.WriteLine($"Value out of range: {ex.Message}");
            }

            catch(Exception ex)
            {
                Console.WriteLine($"Error occurred: {ex.Message}");
            }
        }

        static int GetUserInput()
        {
            while(true)
            {
                try
                {
                    return Convert.ToInt32(Console.ReadLine());
                }
                catch(FormatException)
                {
                    Console.WriteLine("Invalid input. Please enter integer value: ");
                }
            }
        }
    }
}
            
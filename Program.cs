/*
Write a program in C# Sharp to check whether a given string is Palindrome or not using recursion.
    Test Data :
        Input a string : RADAR
        Expected Output :
            The string is Palindrome. 
*/

namespace Assignment_5._2._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("User-Defined Input Test");
            string userInput;
            while (true)
            {
                Console.Write("Input a string: ");
                userInput = Console.ReadLine().Trim();
                
                if (userInput.Length > 0)
                    break;
            }
            
            Console.Write($"The string \"{userInput}\" is ");
            IsPalindrome(userInput.ToLower().Replace(" ","")); // Remove spaces and make case insensitive; e.g., "Taco Cat" is a palindrome

            userInput = "taco Cat";
            Console.WriteLine($"\nTest 1: s = \"{userInput}\"");
            Console.Write($"The string \"{userInput}\" is ");
            IsPalindrome(userInput.ToLower().Replace(" ", ""));

            userInput = "Programming";
            Console.WriteLine($"\nTest 2: s = \"{userInput}\"");
            Console.Write($"The string \"{userInput}\" is ");
            IsPalindrome(userInput.ToLower().Replace(" ", ""));

            userInput = " 123   4 32    1  ";
            Console.WriteLine($"\nTest 3: s = \"{userInput}\"");
            Console.Write($"The string \"{userInput}\" is ");
            IsPalindrome(userInput.ToLower().Replace(" ", ""));
        }

        static void IsPalindrome(string input)
        {
            char first = input[0];
            char last = input[input.Length - 1];

            // If input is <= 1 (1 for odd-length strings, 0 for even), return "true"
            if (input.Length <= 1)
            {
                Console.WriteLine("a palindrome.");
                return;
            }

            // If first and last letters do not match, return "false", otherwise remove first and last letters and rerun function
            if (first != last)
                Console.WriteLine("NOT a palindrome.");
            else
            {
                input = input.Substring(1, input.Length - 2);
                IsPalindrome(input);
            }    
        }
    }
}

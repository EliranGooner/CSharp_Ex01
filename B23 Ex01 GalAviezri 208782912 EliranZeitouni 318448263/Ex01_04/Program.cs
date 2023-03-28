using System;
using System.Text;

namespace Ex01_04
{
    class Program
    {
        public static void Main()
        {
            getInputFromUser(out string userInput);
            printInputAnalysis(userInput, isPalindrome(userInput), isDivisibleBy3(userInput), getAmountOfUppercaseLetters(userInput));
        }

        private static void getInputFromUser(out string o_UserInput)
        {
            Console.WriteLine("Please a 6 character string (letters-only) or a 6 digit number (digits-only):");
            o_UserInput = Console.ReadLine();
            while (!isDigitsOrLettersOnly(o_UserInput, "Digits") && !isDigitsOrLettersOnly(o_UserInput, "Letters"))
            {
                o_UserInput = Console.ReadLine();
            }
        }

        private static bool isDigitsOrLettersOnly(string i_UserInput, string i_DigitsOrLetters)
        {
            for (int i = 0; i < i_UserInput.Length; i++)
            {
                if (i_DigitsOrLetters == "Digits" && (i_UserInput[i] > '9' || i_UserInput[i] < '0'))
                {
                    return false;
                }
                if (i_DigitsOrLetters == "Letters" && (i_UserInput[i] <= '9' && i_UserInput[i] >= '0'))
                {
                    return false;
                }
            }
            return true;
        }

        private static bool isDivisibleBy3(string i_UserInput)
        {
            if (isDigitsOrLettersOnly(i_UserInput, "Digits"))
            {
                int.TryParse(i_UserInput, out int inputNumber);
                return inputNumber % 3 == 0;
            }
            return false;
        }

        private static int getAmountOfUppercaseLetters(string i_UserInput)
        {
            int amountOfUpperCaseLetters = 0;
            if (isDigitsOrLettersOnly(i_UserInput, "Letters"))
            {
                for (int i = 0; i < i_UserInput.Length; i++)
                {
                    if(i_UserInput[i] >= 'A' && i_UserInput[i] <= 'Z')
                    {
                        amountOfUpperCaseLetters++;
                    }
                }
            }
            return amountOfUpperCaseLetters;
        }

        private static bool isPalindrome(string i_UserInput)
        {
            if (i_UserInput.Length <= 1)
            {
                return true;
            }
            if (i_UserInput[0] != i_UserInput[i_UserInput.Length - 1])
            {
                return false;
            }
            return isPalindrome(i_UserInput.Substring(1, i_UserInput.Length - 2));
        }

        private static void printInputAnalysis(string i_UserInput, bool i_IsPalindrome, bool i_IsDivisibleBy3,
                                               int i_AmountOfUppercaseLetters)
        {
            StringBuilder outputMessage = new StringBuilder();
            if (i_IsPalindrome)
            {
                outputMessage.Append("The input is a palindrome\n");
            }
            else
            {
                outputMessage.Append("The input isn't a palindrome\n");
            }
            if (isDigitsOrLettersOnly(i_UserInput, "Digits"))
            {
                if (i_IsDivisibleBy3)
                {
                    outputMessage.Append("The input is divisible by 3\n");
                }
                else
                {
                    outputMessage.Append("The input isn't divisible by 3\n");
                }
            }
            else
            {
                outputMessage.Append("The amount of uppercase letters in the input is " + i_AmountOfUppercaseLetters);
            }
            Console.WriteLine(outputMessage.ToString());
        }
    }
}

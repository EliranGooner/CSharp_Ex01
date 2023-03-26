using NumbersStatistics;

namespace NumberStatistics
{
    public class TUI
    {
        private static bool isValidNumber(string i_numberstring)
        {
            for (int i = 0; i < i_numberstring.Length; i++)
            {
                if (i_numberstring[i] < '0' || i_numberstring[i] > '9')
                {
                    return false;
                }
            }
            return true;
        }
        public static string GetInputFromUser(string i_prompt)
        {
        
            bool isValidInput = false;
            string userInput = string.Empty;

            while (!isValidInput)
            {
                System.Console.WriteLine(i_prompt);
                userInput = System.Console.ReadLine();

                isValidInput = userInput.Length == 6 && isValidNumber(userInput);
                if (!isValidInput)
                {
                    System.Console.Clear();
                    System.Console.WriteLine("Invalid input");
                }
            }
            System.Console.Clear();
            return userInput;
        }

        public static void PrintNumberStatistics(NumberStats i_numberstatistics)
        {
            System.Console.WriteLine("1. There are {0} digits which are bigger than the one's digit.",
                                      i_numberstatistics.GetCountBiggerThanOnesDigit());

            System.Console.WriteLine("2. The smallest digit is {0}.", i_numberstatistics.GetMinimalDigit());

            System.Console.WriteLine("3. There are {0} digits which are divisible by 3.",
                                                     i_numberstatistics.GetCountDivisbleBy3());

            System.Console.WriteLine("4. The average of the digits is {0}.", i_numberstatistics.GetAverage());

            System.Console.WriteLine("Thank you, Bye!");
        }

    }

    
}

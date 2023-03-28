public class Program
{
    private static short k_ASCIIOffset = 48;
    public static void Main()
    {
        printNumberStatistics();
    }
    private static void printNumberStatistics()
    {
        string userInput = getInputFromUser("Please enter a 6 digit number and press enter:");
        System.Console.WriteLine("1. There are {0} digits which are bigger than the one's digit.",
                                  getCountBiggerThanOnesDigit(userInput));
        System.Console.WriteLine("2. The smallest digit is {0}.", getMinimalDigit(userInput));
        System.Console.WriteLine("3. There are {0} digits which are divisible by 3.",
                                                getCountDivisibleBy3(userInput));
        System.Console.WriteLine("4. The average of the digits is {0}.", getAverage(userInput));
    }

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

    public static string getInputFromUser(string i_prompt)
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

    private static float getAverage(string i_NumberString)
    {
        int sumOfDigits = 0;
        int digitCount = i_NumberString.Length;
        for (short i = 0; i < digitCount; i++)
        {
            sumOfDigits += digitToShort(i, i_NumberString);
        }
        return sumOfDigits / Convert.ToSingle(digitCount);
    }

    private static int digitToShort(int i, string i_NumberString)
    {
        int plainValue = Convert.ToInt32(i_NumberString[i]);
        return plainValue - k_ASCIIOffset;
    }

    private static short getCountBiggerThanOnesDigit(string i_NumberString)
    {
        short biggerThan = 0;
        for (int i = i_NumberString.Length - 1; i > 0; --i)
        {
            if (i_NumberString[i] > i_NumberString[i_NumberString.Length - 1])
            {
                ++biggerThan;
            }
        }
        return biggerThan;
    }

    private static short getCountDivisibleBy3(string i_NumberString)
    {
        short divisible = 0;
        for (int i = 0; i < 6; i++)
        {
            if (digitToShort(i, i_NumberString) % 3 == 0)
            {
                ++divisible;
            }
        }
        return divisible;
    }

    public static char getMinimalDigit(string i_NumberString)
    {
        char min = i_NumberString[0];
        for (int i = 1; i < i_NumberString.Length; ++i)
        {
            min = (char)Math.Min(min, i_NumberString[i]);
        }
        return min;
    }
}
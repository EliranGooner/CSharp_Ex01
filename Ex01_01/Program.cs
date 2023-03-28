using System;

namespace Ex01_01
{
    class Program
    {
        public static void Main()
        {
            getInputFromUser(out string firstInputNumber, out string secondInputNumber, out string thirdInputNumber);
            convertInputToDecimal(
                firstInputNumber, secondInputNumber, thirdInputNumber, 
                out double firstDecimalNumber, out double secondDecimalNumber, 
                out double thirdDecimalNumber);
            sortDecimalInputNumbersDescending(
                firstDecimalNumber, secondDecimalNumber, thirdDecimalNumber,
                out double largestNumber, out double secondLargestNumber, 
                out double thirdLargestNumber);
            getNumsAverageOfDigits(firstInputNumber, secondInputNumber, thirdInputNumber,
                out float averageOfZeros, out float averageOfOnes);
            getDivisibleBy4Numbers(firstDecimalNumber, secondDecimalNumber, thirdDecimalNumber, 
                out int amountOfDivisibleBy4Numbers);
            getDescendingSeriesNumbers(firstDecimalNumber, secondDecimalNumber, thirdDecimalNumber,
                out int amountOfDescendingSeriesNumbers);
            getPalindromeNumbers(firstDecimalNumber, secondDecimalNumber, thirdDecimalNumber, 
                out int amountOfPalindromeNumbers);
            printDecimalNumbers(largestNumber, secondLargestNumber, thirdLargestNumber);
            printDecimalNumbersStatistics(averageOfZeros, averageOfOnes, amountOfDivisibleBy4Numbers,
                amountOfDescendingSeriesNumbers, amountOfPalindromeNumbers);
        }

        private static void getInputFromUser(out string o_FirstInputNumber, out string o_SecondInputNumber, 
                                             out string o_ThirdInputNumber)
        {
            Console.WriteLine("Please enter 3 binary numbers with 8 digits each (press enter after each number):");
            o_FirstInputNumber = getBinaryNumberFromUser();
            o_SecondInputNumber = getBinaryNumberFromUser();
            o_ThirdInputNumber = getBinaryNumberFromUser();
        }


        private static double convertBinaryToDecimal(string i_BinaryNumber)
        {
            double decimalNumber = 0;
            double currentPowerOf2 = 0;
            for (int i = i_BinaryNumber.Length - 1; i >= 0; i--)
            {
                int.TryParse(i_BinaryNumber[i].ToString(), out int currentDigitExtracted);

                if (currentDigitExtracted == 1)
                {
                    decimalNumber += Math.Pow(2, currentPowerOf2);
                }

                currentPowerOf2++;
            }
            return decimalNumber;
        }

        private static void convertInputToDecimal(string i_FirstInputNumber, string i_SecondInputNumber, 
                                                  string i_ThirdInputNumber, out double o_FirstDecimalNumber, 
                                                  out double o_SecondDecimalNumber, out double o_ThirdDecimalNumber)
        {
            o_FirstDecimalNumber = convertBinaryToDecimal(i_FirstInputNumber);
            o_SecondDecimalNumber = convertBinaryToDecimal(i_SecondInputNumber);
            o_ThirdDecimalNumber = convertBinaryToDecimal(i_ThirdInputNumber);
        }

        private static string getBinaryNumberFromUser()
        {
            string userInput = Console.ReadLine();
            while (!isValidInput(userInput))
            {
                Console.WriteLine("Please enter a binary number (containing only 0s and 1s) and press enter:");
                userInput = Console.ReadLine();
            }
            return userInput;
        }

        private static bool isValidInput(string i_UserInput)
        {
            if (i_UserInput.Length != 8)
            {
                return false;
            }
            for (int i = 0; i < 8; i++)
            {
                if (i_UserInput[i] != '0' && i_UserInput[i] != '1')
                {
                    return false;
                }
            }
            return true;
        }

        private static void sortDecimalInputNumbersDescending(double i_FirstInputNumber, double i_SecondInputNumber,
                                                              double i_ThirdInputNumber, out double o_LargestNumber,
                                                              out double o_SecondLargestNumber, out double o_ThirdLargestNumber)
        {
            if (i_FirstInputNumber >= i_SecondInputNumber && i_FirstInputNumber >= i_ThirdInputNumber)
            {
                o_LargestNumber = i_FirstInputNumber;
                if (i_SecondInputNumber >= i_ThirdInputNumber)
                {
                    o_SecondLargestNumber = i_SecondInputNumber;
                    o_ThirdLargestNumber = i_ThirdInputNumber;
                }
                else
                {
                    o_SecondLargestNumber = i_ThirdInputNumber;
                    o_ThirdLargestNumber = i_SecondInputNumber;
                }
            }
            else if (i_SecondInputNumber >= i_FirstInputNumber && i_SecondInputNumber >= i_ThirdInputNumber)
            {
                o_LargestNumber = i_SecondInputNumber;
                if(i_FirstInputNumber >= i_ThirdInputNumber)
                {
                    o_SecondLargestNumber = i_FirstInputNumber;
                    o_ThirdLargestNumber = i_ThirdInputNumber;
                }
                else
                {
                    o_SecondLargestNumber = i_ThirdInputNumber;
                    o_ThirdLargestNumber = i_FirstInputNumber;
                }
            }
            else
            {
                o_LargestNumber = i_ThirdInputNumber;
                if (i_FirstInputNumber >= i_SecondInputNumber)
                {
                    o_SecondLargestNumber = i_FirstInputNumber;
                    o_ThirdLargestNumber = i_SecondInputNumber;
                }
                else
                {
                    o_SecondLargestNumber = i_SecondInputNumber;
                    o_ThirdLargestNumber = i_FirstInputNumber;
                }
            }
        }

        private static void printDecimalNumbers(double i_LargestNumber, double i_SecondLargestNumber,
                                                double i_ThirdLargestNumber)
        {
            Console.WriteLine(string.Format(
                "The input numbers in decimal base by descending order: {0}, {1}, {2}",
                i_LargestNumber,
                i_SecondLargestNumber,
                i_ThirdLargestNumber));
        }

        private static void getNumsAverageOfDigits(string i_FirstInputNumber, string i_SecondInputNumber,
                                                   string i_ThirdInputNumber, out float o_AverageOfZeros,
                                                   out float o_AverageOfOnes)
        {
            double sumOfZeros = amountOfDigitInNumber(i_FirstInputNumber, '0')
                                + amountOfDigitInNumber(i_SecondInputNumber, '0')
                                + amountOfDigitInNumber(i_ThirdInputNumber, '0');
            double sumOfOnes = amountOfDigitInNumber(i_FirstInputNumber, '1')
                                + amountOfDigitInNumber(i_SecondInputNumber, '1')
                                + amountOfDigitInNumber(i_ThirdInputNumber, '1');
            o_AverageOfZeros = (float)sumOfZeros / 3;
            o_AverageOfOnes = (float)sumOfOnes / 3;
        }

        private static double amountOfDigitInNumber(string i_InputNumber, char i_Digit)
        {
            double amountOfDigit = 0;
            for (int i = 0; i < i_InputNumber.Length; i++)
            {
                if (i_InputNumber[i] == i_Digit)
                {
                    amountOfDigit++;
                }
            }
            return amountOfDigit;
        }

        private static void getDivisibleBy4Numbers(double i_FirstDecimalNumber, double i_SecondDecimalNumber,
                                                  double i_ThirdDecimalNumber, out int o_AmountOfDivisibleBy4Numbers)
        {
            o_AmountOfDivisibleBy4Numbers = 0;
            if (i_FirstDecimalNumber % 4 == 0)
                o_AmountOfDivisibleBy4Numbers++;
            if (i_SecondDecimalNumber % 4 == 0)
                o_AmountOfDivisibleBy4Numbers++;
            if (i_ThirdDecimalNumber % 4 == 0)
                o_AmountOfDivisibleBy4Numbers++;
        }

        private static void getDescendingSeriesNumbers(double i_FirstDecimalNumber, double i_SecondDecimalNumber,
                                                       double i_ThirdDecimalNumber, out int o_AmountOfDescendingSeriesNumbers)
        {
            o_AmountOfDescendingSeriesNumbers = 0;
            if (isNumberDescendingSeries(i_FirstDecimalNumber))
                o_AmountOfDescendingSeriesNumbers++;
            if (isNumberDescendingSeries(i_SecondDecimalNumber))
                o_AmountOfDescendingSeriesNumbers++;
            if (isNumberDescendingSeries(i_ThirdDecimalNumber))
                o_AmountOfDescendingSeriesNumbers++;
        }

        private static bool isNumberDescendingSeries(double i_Number)
        {
            double currentDigitValue = i_Number % 10;
            while (i_Number > 0)
            {
                if (i_Number % 10 > currentDigitValue)
                {
                    currentDigitValue = i_Number % 10;
                }
                else
                {
                    return false;
                }
                i_Number /= 10;
            }
            return true;
        }

        private static void getPalindromeNumbers(double i_FirstDecimalNumber, double i_SecondDecimalNumber,
                                                 double i_ThirdDecimalNumber, out int o_AmountOfPalindromeNumbers)
        {
            o_AmountOfPalindromeNumbers = 0;
            if (isNumberPalindrome(i_FirstDecimalNumber))
                o_AmountOfPalindromeNumbers++;
            if (isNumberPalindrome(i_SecondDecimalNumber))
                o_AmountOfPalindromeNumbers++;
            if (isNumberPalindrome(i_ThirdDecimalNumber))
                o_AmountOfPalindromeNumbers++;
        }

        private static bool isNumberPalindrome(double i_Number)
        {
            string numberAsStr = i_Number.ToString();
            int leftCurrentDigitOrder = 0;
            int rightCurrentDigitOrder = numberAsStr.Length - 1;
            while (leftCurrentDigitOrder < rightCurrentDigitOrder)
            {
                if (numberAsStr[leftCurrentDigitOrder] != numberAsStr[rightCurrentDigitOrder])
                {
                    return false;
                }

                leftCurrentDigitOrder++;
                rightCurrentDigitOrder--;
            }
            return true;
        }

        private static void printDecimalNumbersStatistics(float i_AverageOfZeros, float i_AverageOfOnes,
                                                          int i_AmountOfDivisibleBy4Numbers, int i_AmountOfDescendingSeriesNumbers,
                                                          int i_AmountOfPalindromeNumbers)
        {
            Console.WriteLine("Average amount of zeros in input numbers: " + i_AverageOfZeros);
            Console.WriteLine("Average amount of ones in input numbers: " + i_AverageOfOnes);
            Console.WriteLine("Amount of input numbers divisible by 4: " + i_AmountOfDivisibleBy4Numbers);
            Console.WriteLine("Amount of input numbers which represent a descending series is: " + i_AmountOfDescendingSeriesNumbers);
            Console.WriteLine("Amount of input numbers which represent a palindrome is: " + i_AmountOfPalindromeNumbers);
        }
    }
}
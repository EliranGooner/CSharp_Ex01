using System;

namespace DiamondForTheAdvanced
{
    public class UserInterface
    {
        public static short GetInputFromUser()
        {
            string rawInput = string.Empty;
            short proccessedInput = 0;
            bool isValidInput = false;
            System.Console.Write(
@"Hello There!
Please enter the size for your diamond
(integers only!) and press enter:");

            while (!isValidInput)
            {
                rawInput = System.Console.ReadLine();
                try
                {
                    proccessedInput = short.Parse(rawInput);
                    // only odd numbers are allowed
                    // implicitly increment
                    if (proccessedInput % 2 == 0)
                    {
                        ++proccessedInput;
                    }
                    isValidInput = true;
                }
                catch
                {
                    System.Console.Clear();
                    System.Console.Write(
@"Invalid input, please try again
(integers only!) and press enter:");
                }
            }
            System.Console.Clear();
            return proccessedInput;
        }
    }
}


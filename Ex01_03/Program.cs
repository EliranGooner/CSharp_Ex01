using Ex01_02;

namespace Ex01_03
{
    public class Program
    {
        public static void Main()
        {
            short customDiamondSize = getInputFromUser();
            Ex01_02.Program.PrintDiamond(customDiamondSize);
        }
        private static short getInputFromUser()
        {
            string rawInput = string.Empty;
            short processedInput = 0;
            bool isValidInput = false;
            System.Console.WriteLine("Hello There!");
            while (!isValidInput)
            {
                System.Console.Write("Please enter the size for your diamond\n(integers only!) and press enter:");
                rawInput = System.Console.ReadLine();
                isValidInput = short.TryParse(rawInput, out processedInput);
                if (!isValidInput)
                {
                    System.Console.Clear();
                    System.Console.WriteLine("Invalid input");
                }
            }
            System.Console.Clear();
            return processedInput;
        }
    }
}
using DiamondForBeginners;
public class Program
{
    public static void Main()
    {
        short CustomDiamondSize = GetInputFromUser();
        DiamondForBeginners.Program.PrintDiamond(CustomDiamondSize);
    }
    public static short GetInputFromUser()
    {
        string rawInput = string.Empty;
        short proccessedInput = 0;
        bool isValidInput = false;
        System.Console.WriteLine("Hello There!");
        while (!isValidInput)
        {
            System.Console.Write("Please enter the size for your diamond\n(integers only!) and press enter:");
            rawInput = System.Console.ReadLine(); 
            isValidInput = short.TryParse(rawInput,out proccessedInput);
            
            if (!isValidInput)
            {
                System.Console.Clear();
                System.Console.WriteLine("Invalid input");
            }
        }
        System.Console.Clear();
        return proccessedInput;
    }
    
}

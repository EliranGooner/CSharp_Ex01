using DiamondForBeginners;
public class Program
{
    public static void Main()
    {
<<<<<<< HEAD
        short CustomDiamondSize = GetInputFromUser();
        DiamondForBeginners.Program.PrintDiamond(CustomDiamondSize);
        
=======
        short customDiamondSize = TUI.GetInputFromUser("Please enter the size for your diamond\n" +
                                                       "(integers only!) and press enter:");
        Diamond diamond = new Diamond(customDiamondSize, '*');
        diamond.PrintDiamond();
>>>>>>> 5eef52234fa00385e4b01fb6f5fb27a8c36c6d50
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
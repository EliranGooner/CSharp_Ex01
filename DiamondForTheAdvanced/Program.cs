using DiamondForBeginners;
using DiamondForTheAdvanced;

public class Program
{
    public static void Main()
    {
        short customDiamondSize = UserInterface.GetInputFromUser();
        Diamond diamond = new Diamond(customDiamondSize, '*');
        diamond.PrintDiamond();
    }

}
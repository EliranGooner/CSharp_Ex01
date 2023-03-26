using DiamondForBeginners;
using DiamondForTheAdvanced;

public class Program
{
    public static void Main()
    {
        short customDiamondSize = TUI.GetInputFromUser("Please enter the size for your diamond\n" +
                                                       "(integers only!) and press enter:");
        Diamond diamond = new Diamond(customDiamondSize, '*');
        diamond.PrintDiamond();
    }

}

using NumbersStatistics;
using NumberStatistics;

public class Program
{
    public static void Main()
    {
        NumberStats numberStatistics = new NumberStats(TUI.GetInputFromUser("Please enter a 6 digit number and press enter:"));
        TUI.PrintNumberStatistics(numberStatistics);
    }
}
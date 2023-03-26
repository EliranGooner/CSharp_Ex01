using DiamondForBeginners;

public class Program
{
    private const short k_ShortDiagonalLength = 9;
    private const char k_CharSymbol = '*';

    public static void Main()
    {
        var diamond = new Diamond(k_ShortDiagonalLength, k_CharSymbol);
        diamond.PrintDiamond();
    }
}

using DiamondForBeginners;

public class Program
{
    private const short k_ShortDiagonalLength = 9;
    private const char k_CharSymbol = '*';
    private const short k_Layer = 0;

    public static void Main()
    {
        var diamond = new Diamond(k_ShortDiagonalLength, k_CharSymbol);
        diamond.PrintDiamond(k_Layer);
    }
}

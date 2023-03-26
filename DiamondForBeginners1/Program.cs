namespace DiamondForBeginners
{
    public class Program
    {
        private static short m_ShortDiagonalLength = 9;
        private static char m_CharSymbol = '*';

        public static void Main()
        {
            PrintDiamond(m_ShortDiagonalLength);
        }

        public static void PrintDiamond(int i_DiamondSize)
        {
            if (i_DiamondSize % 2 == 0)
            {
                i_DiamondSize++;
            }
            PrintDiamondRec(0, i_DiamondSize);
        }

        private static void PrintDiamondRec(int i_LayerIdx, int i_DiamondSize)
        {
            if (i_LayerIdx == i_DiamondSize)
            {
                return;
            }

            System.Console.WriteLine(buildLayer(i_LayerIdx, i_DiamondSize));

            PrintDiamondRec(++i_LayerIdx, i_DiamondSize);
        }

        private static bool isGrowing(int i_Layer,int i_DiamondSize)
        {
            return (i_DiamondSize - i_Layer) > (i_DiamondSize / 2 + 1);
        }

        private static char growingPhaseLayerArithmetics(int i_iteration, int i_LayerIdx, int i_DiamondSize)
        {
            return Math.Abs(i_iteration - (i_DiamondSize / 2)) <= i_LayerIdx
                ?
                m_CharSymbol : ' ';
        }

        private static char shrinkingPhaseLayerArithmetics(int i_iteration, int i_LayerIdx, int i_DiamondSize)
        {
            return Math.Abs(i_iteration - (i_DiamondSize / 2)) < (i_DiamondSize - i_LayerIdx)
                ?
                m_CharSymbol : ' ';
        }

        private static string buildLayer(int i_LayerIdx, int i_DiamondSize)
        {
            string layer = string.Empty;
            for (int i = 0; i < i_DiamondSize; i++)
            {
                layer += isGrowing(i_LayerIdx, i_DiamondSize)
                    ? 
                    growingPhaseLayerArithmetics(i, i_LayerIdx, i_DiamondSize)
                    :
                    shrinkingPhaseLayerArithmetics(i, i_LayerIdx, i_DiamondSize);
            }
            return layer;
        }
    }
}
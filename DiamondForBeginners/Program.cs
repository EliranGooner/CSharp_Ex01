
public class Program
{   
    private const short k_shortDiagonalLength = 9;
    private const char k_charSymbol = '*';
    private const short k_layer = 0;
    public class Diamond
    {
        private char m_charSymbol;
        private short m_shortDiagonalLength;
        private bool m_isGrowing;

        public Diamond(short i_shortDiagonalLength, char i_charSymbol)
        {
            m_isGrowing = true;
            m_shortDiagonalLength = i_shortDiagonalLength;
            m_charSymbol = i_charSymbol;
        }

        private bool evaluatePhase(short i_Layer)
        {
            return (m_shortDiagonalLength - i_Layer) > (m_shortDiagonalLength / 2 + 1);
        }

        private char growingPhaseLayerArithmetics(short i_iteration, short i_LayerIdx)
        {
            return Math.Abs(i_iteration - (m_shortDiagonalLength / 2)) <= i_LayerIdx
                ?
                m_charSymbol : ' ';
        }

        private char shrinkingPhaseLayerArithmetics(short i_iteration, short i_LayerIdx)
        {
            return Math.Abs(i_iteration - (m_shortDiagonalLength / 2)) <= (m_shortDiagonalLength - i_LayerIdx)
                ?
                m_charSymbol : ' ';
        }

        private string buildLayer(short i_LayerIdx)
        {
            string layer = string.Empty;
            for (short i = 0; i < m_shortDiagonalLength; i++)
            {
                layer += m_isGrowing
                    ? growingPhaseLayerArithmetics(i, i_LayerIdx) : shrinkingPhaseLayerArithmetics(i, i_LayerIdx); 
            }
            return layer;
        }

        public void PrintDiamond(short i_LayerIdx)
        {
            if (i_LayerIdx == m_shortDiagonalLength + 1)
            {
                return;
            }

            m_isGrowing = evaluatePhase(i_LayerIdx);

            string layer = buildLayer(i_LayerIdx);

            System.Console.WriteLine(layer);

            PrintDiamond(++i_LayerIdx);

        }
    }

    public static void Main()
    {
        var diamond = new Diamond(k_shortDiagonalLength, k_charSymbol);
        diamond.PrintDiamond(k_layer);
    }
}

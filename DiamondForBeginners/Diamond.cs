namespace DiamondForBeginners
{
        public class Diamond
        {
            private char m_charSymbol;
            private short m_shortDiagonalLength;
            private bool m_isGrowing;

            public Diamond(short i_shortDiagonalLength, char i_charSymbol)
            {
                m_isGrowing = true;
                m_shortDiagonalLength = (short)(i_shortDiagonalLength % 2 == 0 ? i_shortDiagonalLength + 1 : i_shortDiagonalLength);
                m_charSymbol = i_charSymbol;
            }

            public void PrintDiamond(short i_LayerIdx = 0)
            {
                if (i_LayerIdx == m_shortDiagonalLength)
                {
                    return;
                }

                m_isGrowing = evaluatePhase(i_LayerIdx);

                string layer = buildLayer(i_LayerIdx);

                System.Console.WriteLine(layer);

                PrintDiamond(++i_LayerIdx);

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
                return Math.Abs(i_iteration - (m_shortDiagonalLength / 2)) < (m_shortDiagonalLength - i_LayerIdx)
                    ?
                    m_charSymbol : ' ';
            }

            private string buildLayer(short i_LayerIdx)
            {
                System.Text.StringBuilder layer = new System.Text.StringBuilder(string.Empty, this.m_shortDiagonalLength);
                for (short i = 0; i < m_shortDiagonalLength; i++)
                {
                    layer.Append(m_isGrowing ?
                        growingPhaseLayerArithmetics(i, i_LayerIdx)
                        :
                        shrinkingPhaseLayerArithmetics(i, i_LayerIdx));
                }

                return layer.ToString();
            }

        }
}

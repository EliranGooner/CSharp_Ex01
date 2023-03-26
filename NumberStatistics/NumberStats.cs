using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumbersStatistics
{
    public class NumberStats
    {
        public static short k_DigitCount = 6;
        public static short k_ASCIIOffset = 48;
        private string m_NumberAsString;
        
        public NumberStats(string i_Number)
        {
            m_NumberAsString = i_Number;
        }
        // .4
        public float GetAverage()
        {
            int sumOfDigits = 0;
            int digitCount = m_NumberAsString.Length;
            for (short i = 0; i < digitCount; i++)
            {
                sumOfDigits += getDigitShort(i);
            }

            return sumOfDigits / Convert.ToSingle(digitCount);
        }

        private int getDigitShort(int i)
        {
            int plainValue = Convert.ToInt32(m_NumberAsString[i]);
            return plainValue - k_ASCIIOffset;
        }

        // .3
        public short GetCountDivisbleBy3()
        {
            short divisble = 0;

            for (int i = 0; i < 6; i++)
            {
                if (getDigitShort(i) % 3 == 0)
                {
                    ++divisble;
                }
            }
            return divisble;
        }
        // .1
        public short GetCountBiggerThanOnesDigit()
        {
            short biggerthan = 0;

            for (int i = m_NumberAsString.Length - 1; i > 0 ; --i)
            {
                if (m_NumberAsString[i] > m_NumberAsString[m_NumberAsString.Length-1])
                {
                    ++biggerthan;
                }
            }
            return biggerthan;
        }
        // .2
        public char GetMinimalDigit()
        {
            char min = m_NumberAsString[0];
            for (int i = 1; i < m_NumberAsString.Length; ++i)
            {
                min = (char)Math.Min(min, m_NumberAsString[i]);
            }
            return min;
        }
    }
}

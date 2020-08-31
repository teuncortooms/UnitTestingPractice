using System;
using System.Collections.Generic;
using System.Text;

namespace RomanNumeralConverterNamespace
{
    public class RomanNumeralConverter
    {
        int maxInput = 3000;
        List<KeyValuePair<string, int>> romans = new List<KeyValuePair<string, int>>
        {
            new KeyValuePair<string, int> ( "M", 1000 ),
            new KeyValuePair<string, int> ( "D", 500 ),
            new KeyValuePair<string, int> ( "C", 100 ),
            new KeyValuePair<string, int> ( "L", 50 ),
            new KeyValuePair<string, int> ( "X", 10 ),
            new KeyValuePair<string, int> ( "V", 5 ),
            new KeyValuePair<string, int> ( "I", 1 )
        };

        public string Convert(int input)
        {
            if (input > maxInput || input <= 0)
                throw new ArgumentOutOfRangeException();

            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < romans.Count; i++)
            {
                while (input >= romans[i].Value)
                {
                    sb.Append(romans[i].Key);
                    input -= romans[i].Value;
                }
            }

            return sb.ToString();
        }
    }
}

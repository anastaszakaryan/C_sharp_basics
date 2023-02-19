﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D_OOP
{
    class RomanNumeral
    {
        private static Dictionary<char, int> map = new Dictionary<char, int>()
        {
           {'I', 1},
           {'V', 5},
           {'X', 10},
           {'L', 50},
           {'C', 100},
           {'D', 500},
           {'M', 1000},
        };
        public static int Parse(string roman)
        {
            int result = 0;
            for (int i = 0; i < roman.Length; i++)
            {
                if (i + 1 < roman.Length && IsSubtractive(roman[i], roman[i + 1]))
                {
                    char letter = roman[i];
                    result -= map[letter];
                }
                else
                {
                    result += map[roman[i]];
                }
            }
            return result;
        }

        private static bool IsSubtractive(char c1, char c2)
        {
            return map[c1] < map[c2];
        }
    }
}

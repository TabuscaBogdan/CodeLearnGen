using System;
using System.Collections.Generic;
using System.Text;

namespace KeyLearner.Models
{
    public class DigitProbability
    {
        public Dictionary<char, decimal> DigitProbabilities;

        public DigitProbability()
        {
            DigitProbabilities= new Dictionary<char, decimal>();
            for (char ch = '0'; ch <= '9'; ch++)
            {
                DigitProbabilities[ch] = 0;
            }
        }
    }
}

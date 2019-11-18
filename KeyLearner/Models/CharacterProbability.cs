using System;
using System.Collections.Generic;
using System.Text;

namespace KeyLearner.Models
{
    public class CharacterProbability
    {
        public Dictionary<char, decimal> CharacterProbabilities;

        public CharacterProbability()
        {
            CharacterProbabilities = new Dictionary<char, decimal>();
            for (char ch = 'A'; ch <= 'Z'; ch++)
            {
                CharacterProbabilities[ch] = 0;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace KeyLearner.Models
{
    public class Probability
    {
        public decimal Digit { get; set; }
        public decimal Character { get; set; }
        public CharacterProbability CharacterProbabilities { get; set; }
        public DigitProbability DigitProbability { get; set; }
    }
}

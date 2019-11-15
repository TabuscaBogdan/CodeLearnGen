using System;
using System.Collections.Generic;
using System.Text;

namespace KeyLearner.Models
{
    public class FullKey
    {
        public int SubkeyNumber { get; set; }
        public List<SubKey> SubKeys { get; set; }

        public override string ToString()
        {
            string key = "";
            foreach (var subkey in SubKeys)
            {
                key += subkey.Value + "-";
            }

            return key.Substring(0, key.Length - 1);
        }
    }
}

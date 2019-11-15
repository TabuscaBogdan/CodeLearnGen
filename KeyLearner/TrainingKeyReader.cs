using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using KeyLearner.Models;

namespace KeyLearner
{
    public static class TrainingKeyReader
    {
        public static List<FullKey> ReadTrainingKeys(string path)
        {
            List<FullKey> keys = new List<FullKey>();

            try
            {
                using (StreamReader reader = new StreamReader(path))
                {
                    while (!reader.EndOfStream)
                    {
                        var line = reader.ReadLine();
                        var fragments = line.Split('-');
                        var subKeysList = new List<SubKey>();

                        foreach (var fragment in fragments)
                        {
                            var subkey = new SubKey {Length = fragment.Length, Value = fragment};
                            subKeysList.Add(subkey);
                        }

                        var key = new FullKey
                        {
                            SubkeyNumber = subKeysList.Count,
                            SubKeys = subKeysList
                        };
                        keys.Add(key);
                    }

                    return keys;
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("The file could not be read!");
                Console.WriteLine(e.Message);
                throw;
            }

        }
    }
}

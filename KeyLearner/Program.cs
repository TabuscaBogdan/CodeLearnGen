using System;

namespace KeyLearner
{
    class Program
    {
        static void Main(string[] args)
        {
            var keys = TrainingKeyReader.ReadTrainingKeys("C:\\scrap\\scrap.txt");
            foreach (var key in keys)
            {
                Console.WriteLine(key);
            }
        }
    }
}

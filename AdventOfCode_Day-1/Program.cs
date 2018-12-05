using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode_Day_1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> input = new List<int>();
            int frequency = 0;
            int firstRepeat = 1234567;
            bool keepLooping = true;
            Dictionary<int, int> frequencyHistory = new Dictionary<int,int>();

            Console.WriteLine("Paste your list of frequencies: ");


            string line;
            while ((line = Console.ReadLine()) != null && line != "")
            {
                input.Add(int.Parse(line));     
                
            }
            while (keepLooping)
            {
                for (int i = 0; i < input.Count; i++)
                {
                    if (frequencyHistory.ContainsKey(frequency))
                    {
                        frequencyHistory[frequency]++;
                        keepLooping = false;
                        break;
                    }
                    else
                    {
                        frequencyHistory.Add(frequency, 1);
                    }
                    frequency += int.Parse(line);
                }
            }
            

            Console.WriteLine("Frequency is " + frequency);
            Console.WriteLine("Repeat Frequency is " + firstRepeat);
            Console.WriteLine("Press any key to quit...");
            Console.ReadLine();

        }
    }
}

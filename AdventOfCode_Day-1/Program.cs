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

            // first read input till there are nonempty items, means they are not null and not ""
            // also add read item to list do not need to read it again    
            string line;
            while ((line = Console.ReadLine()) != null && line != "")
            {
                input.Add(int.Parse(line));
            }


        }
    }
}

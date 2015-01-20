using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Anagrams
{
    class Program
    {
        static void Main(string[] args)
        {
            ReadFile();
        }
        private static void ReadFile()
        {
            String[] file = File.ReadAllLines("wordlist.txt");
            foreach (String s in file)
            {
                Console.WriteLine(s);
            }
        }
    }
}

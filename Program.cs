using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace WordUnscrambler
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lines = { "this is the first line", "this is the second line", "This is thethird line" };
            File.WriteAllLines("MyFirstFile.txt", lines);

            string[] fileContent = File.ReadAllLines("MyFirstFile.txt");

            foreach(string line in fileContent)
            {
                Console.WriteLine(line);
            }
        }
    }
}

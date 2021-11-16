using System;
using System.IO;

namespace Lesson5_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string filename = "text.txt";
            string content = Console.ReadLine();
            File.WriteAllText(filename, content);

        }
    }
}

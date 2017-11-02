using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.IO;

namespace ConsoleApplication1
{
    class Program
    {
        static void WriteFile(string Filename)
        {
            File.WriteAllText(Filename, "Hello World");
        }

        static void ReadFile(string Filename)
        {
            Console.WriteLine(File.ReadAllText(Filename));
        }


        static void Main(string[] args)
        {
            string Filename = @"E:\test\mydoc.txt";

            WriteFile(Filename);

            ReadFile(Filename);

            Console.Read();
        }
    }
}

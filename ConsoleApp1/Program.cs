using System;
using System.IO;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            ctest meins = new ctest();

            Console.WriteLine("Hello World!");
            File.WriteAllText("test.txt", meins.ToString());
        }
    }

    class ctest
    {
        public int a = 1;
        public string s = "Welt";
        override public string ToString()
        {
            return a + " " + s;
        }
    }
}

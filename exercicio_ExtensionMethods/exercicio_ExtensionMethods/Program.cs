using System;

namespace exercicio_ExtensionMethods
{
    internal class Program
    {
        private static void Main()
        {
            var dt = new DateTime(2018, 11, 16, 8, 10, 45);
            Console.WriteLine(dt.ElapsedTime());

            string s1 = "Good morning dear students!";
            Console.WriteLine(s1.Cut(10));
        }
    }
}
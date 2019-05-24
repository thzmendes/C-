using System;
using System.IO;

namespace exercicio_Path
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\temp\Pasta\Folder1\file1.txt";
            Console.WriteLine(Path.GetDirectoryName(path));
            Console.WriteLine(Path.PathSeparator);
            Console.WriteLine(Path.GetFileNameWithoutExtension(path));
            Console.WriteLine(Path.GetExtension(path));
            Console.WriteLine(Path.GetTempFileName());

        }
    }
}

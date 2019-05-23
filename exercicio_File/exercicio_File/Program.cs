using System;
using System.IO;

namespace exercicio_File
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var sourcePath = @"C:\temp\file1.txt";
            var targetPath = @"C:\temp\file2.txt";
            try
            {
                var fileInfo = new FileInfo(sourcePath);
                //fileInfo.CopyTo(targetPath);
                string[] lines = File.ReadAllLines(sourcePath);
                foreach (var l in lines)
                {
                    Console.WriteLine(l);
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("Error: " + e.Message);
                
            }
        }
    }
}
using System;
using System.IO;

namespace exercicio_StreamWriter
{
    class Program
    {
        static void Main(string[] args)
        {
            string sourcePath = @"C:\temp\file1.txt";
            string targetPath = @"C:\temp\file3.txt";
            try
            {
                string[] Lines = File.ReadAllLines(sourcePath);

                using (StreamWriter sw = File.AppendText(targetPath))
                {
                    foreach (var line in Lines)
                    {
                        sw.WriteLine(line.ToUpper());
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
               
            }
        }
    }
}

using System;
using System.IO;

namespace exercicio_BlocoUsing
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\temp\file1.txt";
            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        Console.WriteLine(sr.ReadLine());
                    }
                }

            }
            catch (IOException e)
            {
                Console.WriteLine("Erro: " + e.Message);

            }





        }
    }
}

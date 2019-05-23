using System;
using System.IO;

namespace exercicio_Directory
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var path = @"C:\temp\Pasta";
            try
            {
                var folderDirectories = Directory.EnumerateDirectories(path, "*.*", SearchOption.AllDirectories);
                Console.WriteLine("Pastas: ");
                foreach (var f in folderDirectories) Console.WriteLine(f);
                var folderFiles = Directory.EnumerateFiles(path, "*.*", SearchOption.AllDirectories);
                Console.WriteLine("Pastas: ");
                foreach (var f in folderFiles) Console.WriteLine(f);
                Directory.CreateDirectory(path + @"\NewFolder");

            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
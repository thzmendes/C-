using System;
using System.IO;
using exercicio_FIles_Path_Stream_Directory.Entities;

namespace exercicio_FIles_Path_Stream_Directory
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Insira o Path do Arquivo .csv ");
            string path = Console.ReadLine();
            var targetPath = Path.GetDirectoryName(path) + @"\out";
            try
            {
                var list = File.ReadAllLines(path);
                Directory.CreateDirectory(targetPath);
                using (var sw = File.CreateText(targetPath + @"\summary.csv"))
                {
                    foreach (var l in list)
                    {
                        var product = l.Split(',');
                        var name = product[0];
                        var price = double.Parse(product[1]);
                        var quantidade = int.Parse(product[2]);
                        var p = new Product(name, price, quantidade);
                        sw.WriteLine(p.ToString());
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("Erro: " + e.Message);
            }
            catch (SystemException e)
            {
                Console.WriteLine("Erro: " + e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("Erro: " + e.Message);
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.IO;
using exercicio_IComparable.Entities;

namespace exercicio_IComparable
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\temp\in.csv";

            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    List<Funcionario> list = new List<Funcionario>();
                    while (!sr.EndOfStream)
                    {
                        list.Add(new Funcionario(sr.ReadLine()));
                    }

                    list.Sort();
                    foreach(var x in list){
                        Console.WriteLine(x.ToString());
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

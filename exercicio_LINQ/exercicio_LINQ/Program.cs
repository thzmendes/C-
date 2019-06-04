using System.Collections.Generic;
using System.Linq;

namespace exercicio_LINQ
{
    internal class Program
    {
        private static void Main(string[] args)
        {//fonte de dados
            int[] vector = new int[] { 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 2, 3, 4, 5, 6, 7,
                8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18 };

            // query
            //lambda do select retorna o número multiplicado por 10
            var result = vector.Where(p => p % 2 == 0).Select(x => x * 10);
            foreach (int x in result) { System.Console.WriteLine(x); }
        }
    }
}
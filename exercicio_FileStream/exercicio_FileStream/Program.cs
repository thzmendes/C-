using System;
using System.IO;

namespace exercicio_FileStream
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\temp\file1.txt";
            FileStream fs = null;
            StreamReader sr = null;
            try
            {
                fs = new FileStream(path, FileMode.Open);
                sr = new StreamReader(fs);
                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();

                    Console.WriteLine(line);    
                }
                
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);

            }
            finally
            {
                if (sr != null) sr.Close();
                if (fs !=null) fs.Close();
            }
        }
    }
}

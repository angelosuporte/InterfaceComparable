using System;
using System.IO;
using System.Collections.Generic;

namespace InterfaceComparable
{
    class Program
    {
        static void Main(string[] args)
        {
            string caminho = @"c:\EstudoTI\teste\comparable.txt";

            try
            {
                using (StreamReader sr = File.OpenText(caminho))
                {
                    List<string> lista = new List<string>();
                    while (!sr.EndOfStream)
                    {
                        lista.Add(sr.ReadLine());
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("Ocorreu um erro!");
                Console.WriteLine(e.Message);
                
            }
        }
    }
}

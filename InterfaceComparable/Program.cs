using System;
using System.IO;
using System.Collections.Generic;
using InterfaceComparable.Entities;

namespace InterfaceComparable
{
    class Program
    {
        static void Main(string[] args)
        {
            string caminho = @"c:\EstudoTI\teste\comparableFuncionario.txt";

            try
            {
                using (StreamReader sr = File.OpenText(caminho))
                {
                    List<Funcionario> lista = new List<Funcionario>();
                    while (!sr.EndOfStream)
                    {
                        lista.Add(new Funcionario(sr.ReadLine()));
                    }

                    lista.Sort();
                    foreach (Funcionario funcionario in lista)
                    {
                        Console.WriteLine(funcionario);
                    }
                }
                Console.ReadKey();
            }
            catch (IOException e)
            {
                Console.WriteLine("Ocorreu um erro!");
                Console.WriteLine(e.Message);
                
            }
        }
    }
}

using System;
using System.Globalization;

namespace InterfaceComparable.Entities
{
    class Funcionario : IComparable
    {
        public string Nome { get; set; }
        public double Salario { get; set; }

        public Funcionario(string csvFuncionario)
        {
            string[] vetor = csvFuncionario.Split(',');
            Nome = vetor[0];
            Salario = double.Parse(vetor[1], CultureInfo.InvariantCulture);
        }

        public override string ToString()
        {
            return Nome + ", " + Salario.ToString("F2", CultureInfo.InvariantCulture);
        }

        public int CompareTo(object obj)
        {
            if (!(obj is Funcionario))
            {
                throw new ArgumentException("Erro de comparação: o argumento não é funcionário");
            }
            Funcionario outro = obj as Funcionario;
            return Salario.CompareTo(outro.Salario);
        }
    }
}

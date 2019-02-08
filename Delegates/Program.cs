using Delegates.Servicoes;
using System;

namespace Delegates
{
    delegate double OperacaoNumericaBinaria(double n1, double n2);
    class Program
    {
        static void Main(string[] args)
        {
            double a = 10;
            double b = 12;

            OperacaoNumericaBinaria op = CalcularServico.Sum;

            double resultado = op.Invoke(a, b);
            Console.WriteLine(resultado);
        }
    }
}

using Delegates.Servicoes;
using System;

namespace Delegates
{
    delegate void OperacaoNumericaBinaria(double n1, double n2);
    class Program
    {
        static void Main(string[] args)
        {
            double a = 10;
            double b = 12;

            OperacaoNumericaBinaria op = CalcularServico.ShowSum;
            op += CalcularServico.ShowMax;
            op.Invoke(a, b);
            
        }
    }
}

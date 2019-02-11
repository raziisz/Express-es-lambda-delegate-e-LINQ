using System.Linq;
using System;

namespace LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            //Especificar o data source
            int[] numbers = new int[] { 2, 3, 4, 5 };

            //Definira consulta expressão
            var result = numbers.Where(x => x % 2 == 0).Select(x => x * 10);

            //Executar a consulta
            foreach (var x in result)
            {
                Console.WriteLine(x);
            }
        }
    }
}

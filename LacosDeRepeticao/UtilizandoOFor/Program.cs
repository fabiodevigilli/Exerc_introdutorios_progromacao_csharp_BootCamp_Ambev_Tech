using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtilizandoOFor
{
    class Program
    {
        static void Main(string[] args)
        {
            var nome = "leoleoleoleo";
            var countFind = 0;
            for (int i = 1; i < 11; i++)
            {
                var stringBuilder = $"{nome[i - 1]}-{nome[i]}-{nome[i + 1]}";
                Console.WriteLine(stringBuilder);
                if (stringBuilder.Contains("e-o"))
                    countFind++;
            }
                Console.WriteLine($"Qauntidade total de 'eo' {countFind}");
                Console.ReadKey();
            
            
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algortirmo_de_Cálculo_de_Área
{
    class Program
    {
        static void Main(string[] args)
        {
            var tipo = "0";
            double bse, altura, result;
            Console.WriteLine("Qual o tipo de ambiente cuja área deve ser calculada? Digite: " +
                " 1 - Para QUADRADO" +
                " || 2 - Para RETÂNGULO" +
                " || 3 - Para TRIÂNGULO");
             tipo = Console.ReadLine();
            switch (tipo)
            {
                case "1":
                    Console.WriteLine("Qual a medida dos lados?");
                    altura = Convert.ToDouble(Console.ReadLine());
                    result = altura * altura;
                    Console.WriteLine("O resultado é: " + result + "M²");
                    break;
                case "2":
                    Console.WriteLine("Qual é a medida da altura?");
                    altura = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Qual é a medida da base?");
                    bse = Convert.ToDouble
                    result = bse * altura;
                    Console.WriteLine("O resultado é: " + result + "M²");
                    break;
                  case "3":
                    Console.WriteLine("Qual é a medida da altura?");
                    altura = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Qual é a medida da base?");
                    result = bse * altura;
                    Console.WriteLine("O resultado é: " + result + "M²");
                    break;
            }
                 Console.ReadKey();

           

        }
    }
}

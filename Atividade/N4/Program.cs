using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N4
{
    class Program
    {
        static void Main(string[] args)
        {
            var texto = string.Empty;
            Console.WriteLine("--------- INSIRA UM TEXTO ---------");
            texto = Console.ReadLine();
            Console.WriteLine($@"
SEU TEXTO POSSUI {texto.Length} CARACTERES CONTANDO COM OS ESPAÇOS VAZIOS");
            Console.ReadKey();


        }
    }
}

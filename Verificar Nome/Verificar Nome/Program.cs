using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Verificar_Nome
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informar o nome a ser calculado: ");
            var nomeLenght = Console.ReadLine();
            Console.WriteLine($"O tamanho deste nome é: {nomeLenght.Replace(" ","").Length}");
            Console.ReadLine();
        }
    }
}

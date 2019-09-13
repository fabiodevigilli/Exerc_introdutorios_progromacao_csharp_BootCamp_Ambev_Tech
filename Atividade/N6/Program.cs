using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N6
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("---------- INFORME UM TEXTO ----------");
            var texto = Console.ReadLine();
            texto = texto.Replace("banana", "laranja");
            Console.WriteLine(texto);
            Console.ReadKey();
        }
    }
}

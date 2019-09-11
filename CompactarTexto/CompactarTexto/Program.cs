using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompactarTexto
{
    class Program
    {
        static void Main(string[] args)
        {
            var primeiroTexto = "textotex1totext111otextotextote1xtotextotexto111111textotextotextotextotex1t11111otextotextotexto1te";
            Console.WriteLine(primeiroTexto);
            Console.WriteLine($"Texto contém: {primeiroTexto.Length} carcateres");
            primeiroTexto = primeiroTexto.Replace("1", "OUTRO NÚMERO");
            Console.WriteLine(primeiroTexto);
            Console.WriteLine($"Texto contém: {primeiroTexto.Length} carcateres");
            primeiroTexto = primeiroTexto.Replace("OUTRO NÚMERO", "1")
            .Replace("1", "0");
            Console.WriteLine(primeiroTexto);
            Console.WriteLine($"Texto contém: {primeiroTexto.Length} carcateres");
            primeiroTexto = primeiroTexto.Replace("0", "1");
            Console.WriteLine(primeiroTexto);
            Console.WriteLine($"Texto contém: {primeiroTexto.Length} carcateres");
            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinhaSegundaClasse
{
    class Program
    {
        static void Main(string[] args)
        {
            var minhaCestaDeFrutas = new List<CestaDeFrutas>();

            minhaCestaDeFrutas.Add(new CestaDeFrutas()
            {
                Nome = "Banana",
                Quantidade = 5
            });

            minhaCestaDeFrutas.Add(new CestaDeFrutas()
            {
                Nome = "Tomate",
                Quantidade = 3

            });

            minhaCestaDeFrutas.ForEach(i => Console.WriteLine($"Nome: {i.Nome} Quantidade: {i.Quantidade}"));
            Console.ReadKey();

        }
        }
    }


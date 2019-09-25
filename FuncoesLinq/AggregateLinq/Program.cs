using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AggregateLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> listaDeNomes = new List<string>()
            {
                "Felipe",
                "Giomar",
                "Euricledson",
                "Adagoberto",
                "Ezebio",
                "Irineudson",

            };

            var texto = listaDeNomes
                //No aggregate temos o nome atual que estamos lendo, o caractere e o próximo nome da lista
                .Aggregate((vari1, vari2) => vari1 + ";\r\n" + vari2);
            //No passo seguinte temos o nome proximo vira o atual 
            //e pega o proximo da lista após o atual 
            Console.WriteLine(texto);
            Console.ReadKey();
        }
    }
}

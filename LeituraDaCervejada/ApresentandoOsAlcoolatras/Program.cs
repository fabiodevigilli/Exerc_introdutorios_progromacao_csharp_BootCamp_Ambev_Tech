using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ListagemDeCervejas.Controller;
using ListagemDeCervejas.Model;

namespace ApresentandoOsAlcoolatras
{
    class Program
    {
        static CervejaController cervejaController = new CervejaController();
        static void Main(string[] args)
        {
            cervejaController.AdicionaCervejasNaLista(new Cerveja(1, "giomar", 1, 5.5, 4.6));

          

            cervejaController.RetornaListaDeCerveja().ForEach(x => Console.WriteLine($"Nome {x.Nome} || ID {x.Id} || Valor {x.Valor} || {x.Litros}"));
            Console.WriteLine($"Valor Total: {cervejaController.RetornaValorTotalDaLista().ToString("c")}");
            Console.WriteLine($"Valor Total: {cervejaController.RetornaLitrosTotalDaLista().ToString()}");
            cervejaController.
            Console.ReadKey();


        }
    }
}

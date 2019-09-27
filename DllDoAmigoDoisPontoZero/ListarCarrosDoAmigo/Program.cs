using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ListagemDeCarros;
using ListagemDeCarros.Model;
using ListagemDeCarros.Controller;

namespace ListarCarrosDoAmigo
{
    class Program
    {
        static CarroController controller = new CarroController();
        static void Main(string[] args)
        {
            controller.RetornaListaDeCarros().ForEach(I => Console.WriteLine($"{I.Ano}"));
            Console.ReadLine();

        }

        
    }
}

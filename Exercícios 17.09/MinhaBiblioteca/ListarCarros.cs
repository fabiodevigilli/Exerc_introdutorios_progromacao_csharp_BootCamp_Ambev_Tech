using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinhaBiblioteca
{
    public class ListarCarros
    {

    /// <summary>
    /// MOSTRA UMA LISTA DE MARCAS DE CARRO
    /// </summary>
    public static void ListarCarrosMe()

    {
        
        var listaCarros = new List<string>();
        listaCarros.Add("Fiat");
        listaCarros.Add("Renault");
        listaCarros.Add("Kia");
        listaCarros.Add("Hyundai");
        listaCarros.Add("Honda");
        Console.WriteLine("------------- LISTA DE MARCAS DE CARROS ------------");
        listaCarros.ForEach(itemCarros => Console.WriteLine(itemCarros));
            Console.ReadKey();
            Console.Clear();
    }
    }

}

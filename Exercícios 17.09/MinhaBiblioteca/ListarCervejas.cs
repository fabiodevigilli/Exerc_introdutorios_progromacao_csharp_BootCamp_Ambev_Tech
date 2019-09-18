using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinhaBiblioteca
{
    public class ListarCervejas
    {

        public static void ListaCervejasME()
        {
           
            var listaCervejas = new List<string>();
            listaCervejas.Add("Stella Artois");
            listaCervejas.Add("Boehmia");
            listaCervejas.Add("Norteña");
            listaCervejas.Add("Patagonia");
            listaCervejas.Add("Budweiser");
            Console.WriteLine("------------- LISTA DE CERVEJAS ------------");
            listaCervejas.ForEach(itemCerveja => Console.WriteLine(itemCerveja));
            Console.ReadKey();
            Console.Clear();
        }
    }
}

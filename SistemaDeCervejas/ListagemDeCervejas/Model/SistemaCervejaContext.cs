using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListagemDeCervejas.Model
{
    public class SistemaCervejaContext
    {
        public int IdContador { get; set; } = 5;
        public List<Cerveja> ListaDeCervejas { get; set; }

        public SistemaCervejaContext()
        {
            ListaDeCervejas = new List<Cerveja>();
            ListaDeCervejas.Add(new Cerveja() { Id = 1, Nome = "Stella", Litros = 0.6, Alcool = 5, Valor = 5.00 });
            ListaDeCervejas.Add(new Cerveja() { Id = 2, Nome = "Antartica", Litros = 1.0, Alcool = 4.7, Valor = 12 });
            ListaDeCervejas.Add(new Cerveja() { Id = 3, Nome = "Budweiser", Litros = 0.350, Alcool = 5, Valor = 3.50 });
            ListaDeCervejas.Add(new Cerveja() { Id = 4, Nome = "Boehmia", Litros = 0.355, Alcool = 5, Valor = 3.10 });
            ListaDeCervejas.Add(new Cerveja() { Id = 5, Nome = "Brahma Extra", Litros = 0.269, Alcool = 5, Valor = 1.98 });


        }
    }
}

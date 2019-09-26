using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaDeVendas.Model;


namespace SistemaDeVendas.Controller
{
    public class VendasController
    {
        public VendasContext contextDB = new VendasContext();
        /// <summary>
        /// O método retorna as vendas de acordo com o período selecionado
        /// </summary>
        /// <param name="mesEscolhido">Mês selecionado pelo usuário</param>
        /// <returns></returns>
        public List<VendasModel> VendasPeriodo(int mesEscolhido)
        {
            return contextDB.ListaDeVendas.Where(x => x.DataVenda.Month == mesEscolhido).ToList<VendasModel>();

        }
        /// <summary>
        /// O método retorna a média de vendas de acordo com o mês selecionado pelo usuário
        /// </summary>
        /// <param name="mesEscolhido"></param>
        /// <returns></returns>
        public double MediaVendas(int mesEscolhido)
        {
            return contextDB.ListaDeVendas.Where(x => x.DataVenda.Month == mesEscolhido).Average(x => (x.Quantidade * x.Valor));

        }
        /// <summary>
        /// O método retorna a soma de vendas de acordo com o mês selecionado pelo usuário
        /// </summary>
        /// <param name="mesEscolhido"></param>
        /// <returns></returns>
        public double SomaVendas(int mesEscolhido)
        {
            return contextDB.ListaDeVendas.Where(x => x.DataVenda.Month == mesEscolhido).Sum(x => (x.Valor*x.Quantidade));

        }
        /// <summary>
        /// Lista total de vendas
        /// </summary>
        /// <returns></returns>
        public List<VendasModel> ListaDeVendas()
        {
            return contextDB.ListaDeVendas;
        }



    }
}

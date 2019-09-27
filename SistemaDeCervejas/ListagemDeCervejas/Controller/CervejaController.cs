using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ListagemDeCervejas.Model;

namespace ListagemDeCervejas.Controller
{
    public class CervejaController
    {
        SistemaCervejaContext sistemaCervejaContext = new SistemaCervejaContext();

        /// <summary>
        /// Método para listar as cervejas
        /// </summary>
        /// <returns></returns>
        public List<Cerveja> GetCervejas()
        {
            return sistemaCervejaContext.ListaDeCervejas;
        }

        /// <summary>
        /// O método permite ao usuário adicionar cervejas
        /// </summary>
        /// <param name="cerveja"></param>
        public void AddCerveja(Cerveja cerveja)
        {
            cerveja.Id = sistemaCervejaContext.IdContador++;
            sistemaCervejaContext.ListaDeCervejas.Add(cerveja);
        }

        /// <summary>
        /// O método retorna o valor total da lista
        /// </summary>
        /// <returns></returns>
        public double TotalValor()
        {
            return sistemaCervejaContext.ListaDeCervejas.Sum(x => x.Valor);
        }
        /// <summary>
        /// O método retorna o total de litros da lista
        /// </summary>
        /// <returns></returns>
        public double TotalLitros()
        {
            return sistemaCervejaContext.ListaDeCervejas.Sum(x => x.Litros);
        }

        /// <summary>
        /// O método retorna se o usuário seria preso pela lei seca brasileira se pego em blitz.
        /// Case 1 = Homem que não ingeriu durante a refeição
        /// Case 2 = Mulher que não ingeriu durante a refeição
        /// Case 3 = Homem ou mulher que ingeriram durante a refeição
        /// </summary>
        /// <param name="peso">peso informado pelo usuário </param>
        /// <param name="respostaMenu">Informa a resposta o usuário</param>
        /// <returns></returns>
        public bool TesteAlcool(double peso, char respostaMenu)
        {
            double qtdAlcoolIngerido = 0;
            bool flagrante;
            

            switch (respostaMenu)
            {
                case '1':
                    {

                        
                        qtdAlcoolIngerido = sistemaCervejaContext.ListaDeCervejas.Sum((x => (((x.Litros) * 1000)*
                        (x.Alcool)/100) * (0.79))) / (peso * 0.7);
                        break;

                    }
                case '2':
                    {
                        qtdAlcoolIngerido = sistemaCervejaContext.ListaDeCervejas.Sum((x => (((x.Litros) * 1000) *
                      (x.Alcool) / 100) * (0.79))) / (peso * 0.6);
                        break;

                    }
                case '3':
                    {
                        qtdAlcoolIngerido = sistemaCervejaContext.ListaDeCervejas.Sum((x => (((x.Litros) * 1000) *
                       (x.Alcool) / 100) * (0.79))) / (peso * 1.1);
                        break;

                    }
            }
            if (qtdAlcoolIngerido >= 0.6)
            {
                flagrante = true;
            }
            else flagrante = false;

            return flagrante;

            


        }
    }
}
    

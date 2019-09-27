using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaCarros.Model;

namespace SistemaCarros.Controller
{
    public class CarroController
    {
        SistemaCarrosContext sistemaCarrosContext = new SistemaCarrosContext();

        /// <summary>
        /// Retorna a lista de Carros
        /// </summary>
        /// <returns></returns>
        public List<Carro> GetCarros()
        {
            return sistemaCarrosContext.ListaDeCarros;
        }
    }
    
}

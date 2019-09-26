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
        SistemaCarrosContext carrosContext = new SistemaCarrosContext();

        public List<Carro> GetCarros()
        {
            return carrosContext.ListaDeCarrosPublica;
        }
    }
    
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinhaBiblioteca
{
    public class CalculosDeArea
    {
        /// <summary>
        /// Método para retornar a área de um quadrado
        /// </summary>
        /// <param name="ladoDoQuadrado">Lado do quadrado</param>
        /// <returns>Retorna a área total do quadrado com a precisão inteira</returns>
        public double CalculaAreaQuadrado(int ladoDoQuadrado)
        {
            return ladoDoQuadrado * ladoDoQuadrado;
        }
    }
}

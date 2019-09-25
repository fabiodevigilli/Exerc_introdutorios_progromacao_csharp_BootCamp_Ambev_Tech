using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício.Model
{
    public class VendasModel
    {
        public int ID { get; set; }
        public string NomeCarro { get; set; }
        public double Valor { get; set; }
        public int Quantidade { get; set; }
        public DateTime DataVenda { get; set; }

    }
}

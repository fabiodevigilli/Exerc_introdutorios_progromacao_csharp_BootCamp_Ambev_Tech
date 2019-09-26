using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeVendas.Model
{
    public class VendasContext
    {
   
        public List<VendasModel> ListaDeVendas { get; set; }

        /// <summary>
        /// Dados da lista
        /// </summary>
        public VendasContext()
        {
            #region Dados
            ListaDeVendas = new List<VendasModel>();
            ListaDeVendas.Add(new VendasModel() { ID = 1, NomeCarro = "Risus Company", Valor = 7.2, Quantidade = 18, DataVenda = DateTime.Parse("29/01/2019") });
            ListaDeVendas.Add(new VendasModel() { ID = 2, NomeCarro = "Risus Associates", Valor = 9961, Quantidade = 4, DataVenda = DateTime.Parse("10/02/2019") });
            ListaDeVendas.Add(new VendasModel() { ID = 3, NomeCarro = "Et Libero Proin Foundation", Valor = 8.71, Quantidade = 17, DataVenda = DateTime.Parse("24/01/2019") });
            ListaDeVendas.Add(new VendasModel() { ID = 4, NomeCarro = "Cursus Et Ltd", Valor = 9.01, Quantidade = 17, DataVenda = DateTime.Parse("26/10/2019") });
            ListaDeVendas.Add(new VendasModel() { ID = 5, NomeCarro = "Odio Etiam Ligula Company", Valor = 5.245, Quantidade = 8, DataVenda = DateTime.Parse("16/02/2019") });
            ListaDeVendas.Add(new VendasModel() { ID = 6, NomeCarro = "Eu Nibh Inc.", Valor = 7.922, Quantidade = 9, DataVenda = DateTime.Parse("27/06/2019") });
            ListaDeVendas.Add(new VendasModel() { ID = 7, NomeCarro = "Tellus Limited", Valor = 7.294, Quantidade = 7, DataVenda = DateTime.Parse("26/01/2019") });
            ListaDeVendas.Add(new VendasModel() { ID = 8, NomeCarro = "Imperdiet PC", Valor = 8.305, Quantidade = 5, DataVenda = DateTime.Parse("06/09/2019") });
            ListaDeVendas.Add(new VendasModel() { ID = 9, NomeCarro = "Elit Inc.", Valor = 5.398, Quantidade = 18, DataVenda = DateTime.Parse("09/06/2019") });
            ListaDeVendas.Add(new VendasModel() { ID = 10, NomeCarro = "Quam A Limited", Valor = 5.398, Quantidade = 14, DataVenda = DateTime.Parse("09/09/2019") });
            ListaDeVendas.Add(new VendasModel() { ID = 11, NomeCarro = "Adipiscing Institute", Valor = 8.133, Quantidade = 4, DataVenda = DateTime.Parse("24/10/2019") });
            ListaDeVendas.Add(new VendasModel() { ID = 12, NomeCarro = "Posuere At Velit Ltd", Valor = 5.121, Quantidade = 15, DataVenda = DateTime.Parse("19/11/2019") });
            ListaDeVendas.Add(new VendasModel() { ID = 13, NomeCarro = "Nunc In Industries", Valor = 8.902, Quantidade = 2, DataVenda = DateTime.Parse("21/07/2019") });
            ListaDeVendas.Add(new VendasModel() { ID = 14, NomeCarro = "Integer Vitae Nibh Corporation", Valor = 6.313, Quantidade = 20, DataVenda = DateTime.Parse("02/02/2019") });
            ListaDeVendas.Add(new VendasModel() { ID = 15, NomeCarro = "Tellus Nunc Lectus Company", Valor = 9.65, Quantidade = 2, DataVenda = DateTime.Parse("20/07/2019") });
            ListaDeVendas.Add(new VendasModel() { ID = 16, NomeCarro = "Suspendisse LLC", Valor = 5.319, Quantidade = 12, DataVenda = DateTime.Parse("24/12/2019") });
            ListaDeVendas.Add(new VendasModel() { ID = 17, NomeCarro = "Mauris Vestibulum Corporation", Valor = 5.79, Quantidade = 5, DataVenda = DateTime.Parse("14/11/2019") });
            ListaDeVendas.Add(new VendasModel() { ID = 18, NomeCarro = "Sed Nec Corp.", Valor = 8.421, Quantidade = 2, DataVenda = DateTime.Parse("05/05/2019") });
            ListaDeVendas.Add(new VendasModel() { ID = 19, NomeCarro = "Enim Nisl Elementum Inc.", Valor = 5.904, Quantidade = 6, DataVenda = DateTime.Parse("26/06/2019") });
            ListaDeVendas.Add(new VendasModel() { ID = 20, NomeCarro = "Ac Mattis Semper Corporation", Valor = 5.11, Quantidade = 4, DataVenda = DateTime.Parse("14/01/2019") });
            ListaDeVendas.Add(new VendasModel() { ID = 21, NomeCarro = "Donec Tempus Lorem LLC", Valor = 8.576, Quantidade = 16, DataVenda = DateTime.Parse("29/03/2019") });
            ListaDeVendas.Add(new VendasModel() { ID = 22, NomeCarro = "Tempor Augue Ac Ltd", Valor = 9.072, Quantidade = 16, DataVenda = DateTime.Parse("09/07/2019") });
            ListaDeVendas.Add(new VendasModel() { ID = 23, NomeCarro = "Diam Duis Mi LLC", Valor = 8.472, Quantidade = 4, DataVenda = DateTime.Parse("23/09/2019") });
            ListaDeVendas.Add(new VendasModel() { ID = 24, NomeCarro = "Aliquam Corp.", Valor = 6.607, Quantidade = 4, DataVenda = DateTime.Parse("28/09/2019") });
            ListaDeVendas.Add(new VendasModel() { ID = 25, NomeCarro = "Montes Institute", Valor = 6.176, Quantidade = 8, DataVenda = DateTime.Parse("19/06/2019") });
            ListaDeVendas.Add(new VendasModel() { ID = 26, NomeCarro = "Hendrerit Institute", Valor = 8.387, Quantidade = 11, DataVenda = DateTime.Parse("17/09/2019") });
            ListaDeVendas.Add(new VendasModel() { ID = 27, NomeCarro = "Erat Etiam Vestibulum Corporation", Valor = 7.584, Quantidade = 9, DataVenda = DateTime.Parse("02/06/2019") });
            ListaDeVendas.Add(new VendasModel() { ID = 28, NomeCarro = "Adipiscing Ltd", Valor = 7.887, Quantidade = 9, DataVenda = DateTime.Parse("19/03/2019") });
            ListaDeVendas.Add(new VendasModel() { ID = 29, NomeCarro = "In Tempus Eu Inc.", Valor = 5.233, Quantidade = 16, DataVenda = DateTime.Parse("20/07/2019") });
            ListaDeVendas.Add(new VendasModel() { ID = 30, NomeCarro = "Elit Institute", Valor = 7.359, Quantidade = 11, DataVenda = DateTime.Parse("12/09/2019") });
            ListaDeVendas.Add(new VendasModel() { ID = 31, NomeCarro = "Aliquam Erat LLC", Valor = 8.842, Quantidade = 4, DataVenda = DateTime.Parse("14/03/2019") });
            ListaDeVendas.Add(new VendasModel() { ID = 32, NomeCarro = "A Feugiat Tellus PC", Valor = 9.176, Quantidade = 4, DataVenda = DateTime.Parse("10/12/2019") });
            ListaDeVendas.Add(new VendasModel() { ID = 33, NomeCarro = "Aliquet Incorporated", Valor = 9.057, Quantidade = 8, DataVenda = DateTime.Parse("26/04/2019") });
            ListaDeVendas.Add(new VendasModel() { ID = 34, NomeCarro = "Dolor Dolor Tempus Institute", Valor = 8.433, Quantidade = 15, DataVenda = DateTime.Parse("31/10/2019") });
            ListaDeVendas.Add(new VendasModel() { ID = 35, NomeCarro = "Risus Odio Auctor PC", Valor = 8.286, Quantidade = 11, DataVenda = DateTime.Parse("29/03/2019") });
            ListaDeVendas.Add(new VendasModel() { ID = 36, NomeCarro = "Aliquet Molestie Tellus Corp.", Valor = 8.779, Quantidade = 1, DataVenda = DateTime.Parse("05/07/2019") });
            ListaDeVendas.Add(new VendasModel() { ID = 37, NomeCarro = "Ipsum Corp.", Valor = 5.568, Quantidade = 15, DataVenda = DateTime.Parse("10/03/2019") });
            ListaDeVendas.Add(new VendasModel() { ID = 38, NomeCarro = "Mi Lacinia Foundation", Valor = 7.442, Quantidade = 20, DataVenda = DateTime.Parse("09/07/2019") });
            ListaDeVendas.Add(new VendasModel() { ID = 39, NomeCarro = "Cubilia Curae; Corp.", Valor = 8.421, Quantidade = 7, DataVenda = DateTime.Parse("26/05/2019") });
            ListaDeVendas.Add(new VendasModel() { ID = 40, NomeCarro = "Velit Sed Malesuada Associates", Valor = 9.841, Quantidade = 6, DataVenda = DateTime.Parse("07/11/2019") });
            ListaDeVendas.Add(new VendasModel() { ID = 41, NomeCarro = "Duis Foundation", Valor = 9.849, Quantidade = 6, DataVenda = DateTime.Parse("08/12/2019") });
            ListaDeVendas.Add(new VendasModel() { ID = 42, NomeCarro = "Erat Semper Consulting", Valor = 6.168, Quantidade = 10, DataVenda = DateTime.Parse("10/11/2019") });
            ListaDeVendas.Add(new VendasModel() { ID = 43, NomeCarro = "Turpis Inc.", Valor = 7.758, Quantidade = 7, DataVenda = DateTime.Parse("12/08/2019") });
            ListaDeVendas.Add(new VendasModel() { ID = 44, NomeCarro = "Aenean Industries", Valor = 8.77, Quantidade = 12, DataVenda = DateTime.Parse("10/09/2019") });
            ListaDeVendas.Add(new VendasModel() { ID = 45, NomeCarro = "Nulla Industries", Valor = 8.884, Quantidade = 8, DataVenda = DateTime.Parse("10/11/2019") });
            ListaDeVendas.Add(new VendasModel() { ID = 46, NomeCarro = "Semper Egestas Urna Inc.", Valor = 9.428, Quantidade = 11, DataVenda = DateTime.Parse("26/06/2019") });
            ListaDeVendas.Add(new VendasModel() { ID = 47, NomeCarro = "Donec Luctus Aliquet Industries", Valor = 5.928, Quantidade = 8, DataVenda = DateTime.Parse("11/07/2019") });
            ListaDeVendas.Add(new VendasModel() { ID = 48, NomeCarro = "Cum Sociis Natoque Foundation", Valor = 7.506, Quantidade = 2, DataVenda = DateTime.Parse("21/07/2019") });
            ListaDeVendas.Add(new VendasModel() { ID = 49, NomeCarro = "Vitae Sodales Limited", Valor = 8.912, Quantidade = 8, DataVenda = DateTime.Parse("22/06/2019") });
            ListaDeVendas.Add(new VendasModel() { ID = 50, NomeCarro = "Tellus Sem Mollis Ltd", Valor = 9.615, Quantidade = 20, DataVenda = DateTime.Parse("30/10/2019") });
            ListaDeVendas.Add(new VendasModel() { ID = 51, NomeCarro = "Nulla Tincidunt LLC", Valor = 5.562, Quantidade = 19, DataVenda = DateTime.Parse("22/09/2019") });
            ListaDeVendas.Add(new VendasModel() { ID = 52, NomeCarro = "Sed Dictum Institute", Valor = 9.243, Quantidade = 14, DataVenda = DateTime.Parse("26/06/2019") });
            ListaDeVendas.Add(new VendasModel() { ID = 53, NomeCarro = "Sed Turpis Company", Valor = 7.243, Quantidade = 14, DataVenda = DateTime.Parse("20/08/2019") });
            ListaDeVendas.Add(new VendasModel() { ID = 54, NomeCarro = "Vitae Diam Proin Associates", Valor = 6.631, Quantidade = 2, DataVenda = DateTime.Parse("10/06/2019") });
            ListaDeVendas.Add(new VendasModel() { ID = 55, NomeCarro = "Curabitur Inc.", Valor = 8.09, Quantidade = 3, DataVenda = DateTime.Parse("09/02/2019") });
            ListaDeVendas.Add(new VendasModel() { ID = 56, NomeCarro = "Suscipit Est Ac LLC", Valor = 8.567, Quantidade = 15, DataVenda = DateTime.Parse("08/03/2019") });
            ListaDeVendas.Add(new VendasModel() { ID = 57, NomeCarro = "Neque Morbi Industries", Valor = 5.171, Quantidade = 1, DataVenda = DateTime.Parse("03/10/2019") });
            ListaDeVendas.Add(new VendasModel() { ID = 58, NomeCarro = "Non Ltd", Valor = 5.102, Quantidade = 19, DataVenda = DateTime.Parse("14/08/2019") });
            ListaDeVendas.Add(new VendasModel() { ID = 59, NomeCarro = "Arcu Vestibulum Ante Institute", Valor = 6.128, Quantidade = 1, DataVenda = DateTime.Parse("08/10/2019") });
            ListaDeVendas.Add(new VendasModel() { ID = 60, NomeCarro = "Nulla Foundation", Valor = 7.636, Quantidade = 6, DataVenda = DateTime.Parse("14/04/2019") });
            ListaDeVendas.Add(new VendasModel() { ID = 61, NomeCarro = "Quis Massa Mauris LLP", Valor = 5.053, Quantidade = 3, DataVenda = DateTime.Parse("09/10/2019") });
            ListaDeVendas.Add(new VendasModel() { ID = 62, NomeCarro = "Ut Incorporated", Valor = 6.922, Quantidade = 17, DataVenda = DateTime.Parse("16/09/2019") });
            ListaDeVendas.Add(new VendasModel() { ID = 63, NomeCarro = "Aenean Egestas Corp.", Valor = 8.142, Quantidade = 19, DataVenda = DateTime.Parse("17/11/2019") });
            ListaDeVendas.Add(new VendasModel() { ID = 64, NomeCarro = "Fusce Mi Lorem Consulting", Valor = 8.312, Quantidade = 20, DataVenda = DateTime.Parse("19/11/2019") });
            ListaDeVendas.Add(new VendasModel() { ID = 65, NomeCarro = "A Sollicitudin Orci PC", Valor = 5.864, Quantidade = 1, DataVenda = DateTime.Parse("20/03/2019") });
            ListaDeVendas.Add(new VendasModel() { ID = 66, NomeCarro = "Sociosqu Limited", Valor = 5.985, Quantidade = 12, DataVenda = DateTime.Parse("28/11/2019") });
            ListaDeVendas.Add(new VendasModel() { ID = 67, NomeCarro = "Ullamcorper Duis Cursus LLC", Valor = 5.164, Quantidade = 7, DataVenda = DateTime.Parse("22/12/2019") });
            ListaDeVendas.Add(new VendasModel() { ID = 68, NomeCarro = "Nibh Lacinia LLC", Valor = 7.76, Quantidade = 10, DataVenda = DateTime.Parse("13/06/2019") });
            ListaDeVendas.Add(new VendasModel() { ID = 69, NomeCarro = "Eu Dui Institute", Valor = 7.695, Quantidade = 8, DataVenda = DateTime.Parse("12/12/2019") });
            ListaDeVendas.Add(new VendasModel() { ID = 70, NomeCarro = "Fringilla Purus Mauris Consulting", Valor = 5.845, Quantidade = 6, DataVenda = DateTime.Parse("01/03/2019") });
            ListaDeVendas.Add(new VendasModel() { ID = 71, NomeCarro = "Donec Tempus Lorem Industries", Valor = 8.472, Quantidade = 19, DataVenda = DateTime.Parse("09/03/2019") });
            ListaDeVendas.Add(new VendasModel() { ID = 72, NomeCarro = "Auctor Incorporated", Valor = 6.795, Quantidade = 1, DataVenda = DateTime.Parse("04/10/2019") });
            ListaDeVendas.Add(new VendasModel() { ID = 73, NomeCarro = "Enim Etiam Imperdiet Corporation", Valor = 6.532, Quantidade = 13, DataVenda = DateTime.Parse("14/10/2019") });
            ListaDeVendas.Add(new VendasModel() { ID = 74, NomeCarro = "Non Cursus Non Industries", Valor = 9.569, Quantidade = 16, DataVenda = DateTime.Parse("25/10/2019") });
            ListaDeVendas.Add(new VendasModel() { ID = 75, NomeCarro = "Ut Semper Incorporated", Valor = 5.76, Quantidade = 18, DataVenda = DateTime.Parse("14/01/2019") });
            ListaDeVendas.Add(new VendasModel() { ID = 76, NomeCarro = "Sed Malesuada Corporation", Valor = 6.561, Quantidade = 4, DataVenda = DateTime.Parse("06/03/2019") });
            ListaDeVendas.Add(new VendasModel() { ID = 77, NomeCarro = "Sed Neque Consulting", Valor = 7.308, Quantidade = 2, DataVenda = DateTime.Parse("31/08/2019") });
            ListaDeVendas.Add(new VendasModel() { ID = 78, NomeCarro = "Nisl Arcu PC", Valor = 7.26, Quantidade = 8, DataVenda = DateTime.Parse("19/06/2019") });
            ListaDeVendas.Add(new VendasModel() { ID = 79, NomeCarro = "Euismod Est Consulting", Valor = 6.02, Quantidade = 11, DataVenda = DateTime.Parse("27/10/2019") });
            ListaDeVendas.Add(new VendasModel() { ID = 80, NomeCarro = "Leo Vivamus Ltd", Valor = 5.055, Quantidade = 8, DataVenda = DateTime.Parse("22/10/2019") });
            ListaDeVendas.Add(new VendasModel() { ID = 81, NomeCarro = "Tristique Neque Inc.", Valor = 9.268, Quantidade = 13, DataVenda = DateTime.Parse("25/02/2019") });
            ListaDeVendas.Add(new VendasModel() { ID = 82, NomeCarro = "In Lobortis PC", Valor = 5.539, Quantidade = 4, DataVenda = DateTime.Parse("18/12/2019") });
            ListaDeVendas.Add(new VendasModel() { ID = 83, NomeCarro = "Nunc Ltd", Valor = 6.846, Quantidade = 2, DataVenda = DateTime.Parse("09/10/2019") });
            ListaDeVendas.Add(new VendasModel() { ID = 84, NomeCarro = "Dictum Proin Limited", Valor = 5.543, Quantidade = 12, DataVenda = DateTime.Parse("05/10/2019") });
            ListaDeVendas.Add(new VendasModel() { ID = 85, NomeCarro = "Erat Vitae LLP", Valor = 5.06, Quantidade = 7, DataVenda = DateTime.Parse("12/12/2019") });
            ListaDeVendas.Add(new VendasModel() { ID = 86, NomeCarro = "Pellentesque Ultricies Dignissim PC", Valor = 7.971, Quantidade = 15, DataVenda = DateTime.Parse("25/10/2019") });
            ListaDeVendas.Add(new VendasModel() { ID = 87, NomeCarro = "Phasellus Elit Company", Valor = 5.35, Quantidade = 15, DataVenda = DateTime.Parse("31/10/2019") });
            ListaDeVendas.Add(new VendasModel() { ID = 88, NomeCarro = "Luctus Felis Ltd", Valor = 9.872, Quantidade = 13, DataVenda = DateTime.Parse("06/01/2019") });
            ListaDeVendas.Add(new VendasModel() { ID = 89, NomeCarro = "Dui Suspendisse PC", Valor = 6.878, Quantidade = 7, DataVenda = DateTime.Parse("06/02/2019") });
            ListaDeVendas.Add(new VendasModel() { ID = 90, NomeCarro = "Odio Associates", Valor = 7.636, Quantidade = 18, DataVenda = DateTime.Parse("24/07/2019") });
            ListaDeVendas.Add(new VendasModel() { ID = 91, NomeCarro = "Vel Company", Valor = 7.41, Quantidade = 5, DataVenda = DateTime.Parse("16/02/2019") });
            ListaDeVendas.Add(new VendasModel() { ID = 92, NomeCarro = "Lobortis Institute", Valor = 5.11, Quantidade = 8, DataVenda = DateTime.Parse("27/05/2019") });
            ListaDeVendas.Add(new VendasModel() { ID = 93, NomeCarro = "Scelerisque Company", Valor = 7.983, Quantidade = 19, DataVenda = DateTime.Parse("03/12/2019") });
            ListaDeVendas.Add(new VendasModel() { ID = 94, NomeCarro = "Posuere Enim Company", Valor = 6.968, Quantidade = 19, DataVenda = DateTime.Parse("22/04/2019") });
            ListaDeVendas.Add(new VendasModel() { ID = 95, NomeCarro = "Sem Ut Corp.", Valor = 6.504, Quantidade = 11, DataVenda = DateTime.Parse("02/02/2019") });
            ListaDeVendas.Add(new VendasModel() { ID = 96, NomeCarro = "Dui Fusce Aliquam PC", Valor = 7.837, Quantidade = 2, DataVenda = DateTime.Parse("08/12/2019") });
            ListaDeVendas.Add(new VendasModel() { ID = 97, NomeCarro = "Nisl Sem Industries", Valor = 6.835, Quantidade = 5, DataVenda = DateTime.Parse("14/11/2019") });
            ListaDeVendas.Add(new VendasModel() { ID = 98, NomeCarro = "Vitae Corp.", Valor = 7.669, Quantidade = 7, DataVenda = DateTime.Parse("09/11/2019") });
            ListaDeVendas.Add(new VendasModel() { ID = 99, NomeCarro = "Malesuada Incorporated", Valor = 5.96, Quantidade = 4, DataVenda = DateTime.Parse("26/09/2019") });
            ListaDeVendas.Add(new VendasModel() { ID = 100, NomeCarro = "Mauris Ltd", Valor = 8.974, Quantidade = 18, DataVenda = DateTime.Parse("16/05/2019") });
            #endregion


                
        }

    }
}

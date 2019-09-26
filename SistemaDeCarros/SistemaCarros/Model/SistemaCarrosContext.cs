using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SistemaCarros.Model
{
    public class SistemaCarrosContext
    {
        /// <summary>
        /// Lista de Carros
        /// </summary>
        public List<Carro> ListaDeCarros { get; set; }
        /// <summary>
        /// Adição das informações à lista
        /// </summary>
        public SistemaCarrosContext()
        {
            ListaDeCarros = new List<Carro>();
            ListaDeCarros.Add(new Carro() { Id = 1, Ano = 2001, Cilindradas = 2000, Marca = "Marca1", Modelo = "Modelo1", Portas = 2 });
            ListaDeCarros.Add(new Carro() { Id = 2, Ano = 2002, Cilindradas = 2000, Marca = "Marca2", Modelo = "Modelo2", Portas = 4 });
            ListaDeCarros.Add(new Carro() { Id = 3, Ano = 2003, Cilindradas = 2000, Marca = "Marca3", Modelo = "Modelo3", Portas = 2 });
            ListaDeCarros.Add(new Carro() { Id = 4, Ano = 2004, Cilindradas = 2000, Marca = "Marca4", Modelo = "Modelo4", Portas = 4 });
            ListaDeCarros.Add(new Carro() { Id = 5, Ano = 2005, Cilindradas = 2000, Marca = "Marca5", Modelo = "Modelo5", Portas = 2 });
            ListaDeCarros.Add(new Carro() { Id = 6, Ano = 2006, Cilindradas = 2000, Marca = "Marca6", Modelo = "Modelo6", Portas = 4 });
            ListaDeCarros.Add(new Carro() { Id = 7, Ano = 2007, Cilindradas = 2000, Marca = "Marca7", Modelo = "Modelo7", Portas = 2 });
            ListaDeCarros.Add(new Carro() { Id = 8, Ano = 2008, Cilindradas = 2000, Marca = "Marca8", Modelo = "Modelo8", Portas = 4 });
            ListaDeCarros.Add(new Carro() { Id = 9, Ano = 2009, Cilindradas = 2000, Marca = "Marca9", Modelo = "Modelo9", Portas = 2 });
            ListaDeCarros.Add(new Carro() { Id = 10, Ano = 20010, Cilindradas = 2000, Marca = "Marca10", Modelo = "Modelo10", Portas = 4 });



        }
        /// <summary>
        /// Instaciamento público da lista
        /// </summary>
        

    }
}

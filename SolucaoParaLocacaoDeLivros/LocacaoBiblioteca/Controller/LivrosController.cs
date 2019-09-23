using LocacaoBiblioteca.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocacaoBiblioteca.Controller
{
    
    /// <summary>
    /// Classe que controla as informações dos nossos livros
    /// </summary>
    public class LivrosController
    {
        private int counter = 1;
        /// <summary>
        /// Metodo construtor que prepara o terreo para já iniciar com livros pré cadastrados
        /// </summary>
        public LivrosController()
        {
            //criamos uma lista de livros em memoria
            ListaDeLivros = new List<Livro>();

            //Adicionamos os livros 
            ListaDeLivros.Add(new Livro()
            {
                Id = counter++,
                //Informo apenas o nome do livro para adicionar
                Nome = "Meu Primeiro Livro"
            }); ;

            ListaDeLivros.Add(new Livro()
            {   
                Id = counter++,
                Nome = "Meu Segundo Livro"
            });
        }
        //Aqui crio uma propriedade para acessar o a lista de livros disponiveis no sistema
        private List<Livro> ListaDeLivros { get; set; }

        /// <summary>
        /// Metodo que adiciona o livro em nossa lista já "instanciada" criada dentro do 
        /// construtor
        /// </summary>
        /// <param name="parametroLivro">Informações do livro que vamos adicionar</param>
        public void AdicionarLivro(Livro parametroLivro)
        {
            parametroLivro.Id = counter++;
            //Adicionamos o livro em nossa lista.
            ListaDeLivros.Add(parametroLivro);
        }

        /// <summary>
        /// Método que retorna a lista de livros. 
        /// </summary>
        /// <returns></returns>
        public List <Livro> RetornarListaDeLivros()
        {
            return ListaDeLivros;
        }
    }
}

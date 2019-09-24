using LocacaoBiblioteca.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocacaoBiblioteca.Controller
{
    public class LivrosController
    {

        private LocacaoContext contextDB = new LocacaoContext(); 

        /// <summary>
        /// Metodo que adiciona o livro em ossa lista já "instanciada" criada dentro do construtor.
        /// </summary>
        /// <param name="parametroLivro">Informações do livro que vamos adicionar</param>
        public void AdicionarLivro(Livro parametroLivro)
        {
            parametroLivro.Id = contextDB.IdContadorLivro++;
            contextDB.ListaDeLivros.Add(parametroLivro);

        }

        /// <summary>
        /// Metodo que retorna a lista de livros.
        /// </summary>
        /// <returns></returns>
        public List<Livro> RetornaListaDeLivros()
        {
            // retorna agora somente a lista de livros ativos com a expressão "Where(x => x.Ativo)"
            return contextDB.ListaDeLivros.Where(x => x.Ativo).ToList<Livro>();
        }

        
        /// <summary>
        /// Metodo que desativa um registro de livro cadastrado em nossa lista
        /// </summary>
        /// <param name="identificadoID">Parametro que identifica o livro que será desativado</param>
        public void RemoverLivroPorID(int identificadoID)
        {
            // Aqui usamos o metodo FirstOrDefault para localizar nosso livro dentro da lista
            // Com isso conseguimos acessar as propriedades dele e desativar o registro.
            var livro = contextDB.ListaDeLivros.FirstOrDefault(x => x.Id == identificadoID);
            if (livro != null)
                livro.Ativo = false;
        }

        

    }
   
}

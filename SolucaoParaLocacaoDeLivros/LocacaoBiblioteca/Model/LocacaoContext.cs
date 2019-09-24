using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocacaoBiblioteca.Model
{
    public class LocacaoContext
    {
        public int IdContadorLivro { get; set; } = 1;
        public int IdContadorUsuarios { get; set; } = 1;
        public List<Livro> ListaDeLivros { get; set; }
        public List<Usuario> ListaDeUsuarios { get; set; }


        public LocacaoContext()
        {
            ListaDeLivros = new List<Livro>();
            ListaDeUsuarios = new List<Usuario>();

            ListaDeLivros.Add(new Livro()
            {
                //Adiciono o ID contador incrementando o mesmo com ele +1 "++".
                Id = IdContadorLivro++,
                Nome = "Meu Primeiro Livro"
            });

            ListaDeLivros.Add(new Livro()
            {
                //Adiciono o ID contador incrementando o mesmo com ele +1 "++".
                Id = IdContadorLivro++,
                Nome = "Meu Segundo Livro"
            });

            ListaDeUsuarios = new List<Usuario>();

            ListaDeUsuarios.Add(new Usuario()
            {
                //Adiciono o ID contador incrementando o mesmo com ele +1 "++".
                Id = IdContadorUsuarios++,
                Login = "Admin",
                Senha = "Admin"

            });

            ListaDeUsuarios.Add(new Usuario()
            {
                Id = IdContadorUsuarios++,
                Login = "Fabio",
                Senha = "0123"

            });
            ListaDeUsuarios.Add(new Usuario()
            {
                Id = IdContadorUsuarios++,
                Login = "admin",
                Senha = "123"

            });
        }

    }
}

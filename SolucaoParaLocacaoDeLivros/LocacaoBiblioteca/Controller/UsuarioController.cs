using LocacaoBiblioteca.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocacaoBiblioteca.Controller
{
    public class UsuarioController
    {
        public UsuarioController()
        { 
        Usuario = new List<Usuarios>();
            Usuario.Add(new Usuarios()
            {
                Login = "Admin",
                Senha = "Admin"
            });

            Usuario.Add(new Usuarios()
            {
                Login = "Leo",
                Senha = "Leo123"
            });

        }

        public bool LoginSistema (UsuarioController Usuario)
            {
            return Usuarios

            }


    public List<Usuarios> Usuario { get; set; }
    }
}


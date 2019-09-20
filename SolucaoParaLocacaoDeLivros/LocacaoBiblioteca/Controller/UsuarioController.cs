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
        /// <summary>
        /// MÉTODO QUE REALIZA O LOGIN NO SISTEMA
        /// LOGIN PADRÃO: Admin
        /// SENHA PADRÃO: Admin
        /// </summary>
        /// <param name="login": LOGIN DO USUÁRIO></param>
        /// <param name="senha": SENHA DO USUÁRIO</param>
        /// <returns>RETORNA VERDADEIRO QUANDO EXISTIR O USUÁRIO COM ESTE LOGIN E SENHA</returns>
        public bool LoginSistema(Usuarios usuarios)
        {
            if (usuarios.Login == "Admin" && usuarios.Senha == "Admin")
                return true;

            else
                return false;
        }

    }
}

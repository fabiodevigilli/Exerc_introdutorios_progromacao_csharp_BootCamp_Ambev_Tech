using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LocacaoBiblioteca.Controller;
using LocacaoBiblioteca.Model;

namespace InterfaceBiblioteca
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("************************ SISTEMA DE LOCAÇÃO 1.0 *************************");
            while (!RealizaLoginSistema())
                Console.WriteLine("Login e senha inválidos");
            MostraMenuSistema();
            Console.ReadKey();
           



        }
        /// <summary>
        /// MOSTRA O MENU DO SISTEMA
        /// </summary>
        private static void MostraMenuSistema()
        {
            Console.Clear();
            Console.WriteLine("************************ SISTEMA DE LOCAÇÃO 1.0 *************************");

            Console.WriteLine("Menu Sistema");
            Console.WriteLine("0 - Sair");
            Console.WriteLine("1 - Listar Usuários");

        }
        /// <summary>
         /// MÉTODO MOSTRA A TELA DE LOGIN E VALIDA AS INFORMAÇOES DE ACESSO
         /// </summary>
         /// <returns> VERDADEIRO PARA LOGIN E SENHA CORRETOS, FALSO PARA INCORRETOS.</returns>
         /// 
        private static bool RealizaLoginSistema()
        {
        Console.WriteLine("Informe seu login e senha para acessar o sistema:");

            Console.WriteLine("Login:");
            var loginDoUsuario = Console.ReadLine();

        Console.WriteLine("Senha: ");
            var senhaDoUsuario = Console.ReadLine();

        UsuarioController usuarioController = new UsuarioController();
            return usuarioController.LoginSistema(new Usuarios() { });
           
        }
        
    }
}

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
        static LivrosController livros = new LivrosController();
        static UsuarioController usuarios = new UsuarioController();
        static void Main(string[] args)
        {
            Console.WriteLine("************************ SISTEMA DE LOCAÇÃO 1.0 *************************");
            LacoDeLogin();
            MostraMenuSistema();
            Console.ReadKey();




        }
        /// <summary>
        /// MOSTRA O MENU DO SISTEMA
        /// </summary>
        public static void MostraMenuSistema()
        {
            var menuEscolhido = int.MinValue;
            while (menuEscolhido != 0)
            {
                Console.Clear();
            Console.WriteLine("************************ SISTEMA DE LOCAÇÃO 1.0 *************************");

            Console.WriteLine("Menu Sistema");
            Console.WriteLine("0 - Sair");
            Console.WriteLine("1 - Listar Usuários");
            Console.WriteLine("2 - Listar Livros");
            Console.WriteLine("3 - Cadastrar Livros");
            Console.WriteLine("4 - Fazer LogOff");

                menuEscolhido = int.Parse(Console.ReadKey().KeyChar.ToString());
                switch (menuEscolhido)
                {
                    case 1: { MostraUsuario(); } break;

                    case 2: { MostraLivro(); } break;
                    case 3: {  } break;
                    case 4: { LacoDeLogin(); } break;
                    default:
                         break;

                }
            }
           
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
            return usuarioController.LoginSistema(new UsuarioController()
            {
                Login = loginDoUsuario,
                Senha = senhaDoUsuario
            });
            ;

        }
        /// <summary>
        /// MOSTRA A LISTA DE LIVROS
        /// </summary>
        public static void MostraLivro()
        {
            livros.Livros.ForEach (i =>  Console.WriteLine($"Nome do Livro: {i.Nome}"));
            {

            }
               
               Console.WriteLine("******************* digite qualquer tecla para voltar ********************");
            Console.ReadKey();
        }

            
        
        /// <summary>
        /// O MÉTODO MOSTRA OS USUÁRIOS
        /// </summary>
        public static void MostraUsuario()
        {
            usuarios.Usuario.ForEach(i => Console.WriteLine($@"Usuário: {i.Login}"));
        }
        public static void LacoDeLogin()
        {
            while (!RealizaLoginSistema())
                Console.WriteLine("Login e senha inválidos");
        }

    }


}



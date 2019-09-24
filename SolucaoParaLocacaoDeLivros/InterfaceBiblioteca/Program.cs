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
        //Instanciamos "Carregamos para memoria" nosso controlador dos livros
        static LivrosController livrosController = new LivrosController();
        //Instanciamos "Carregamos para memoria" nosso controlador dos usuarios
        static UsuarioController usuariosController = new UsuarioController();
        static LocacaoContext locacaoContext = new LocacaoContext();
        static void Main(string[] args)
        {
            Console.WriteLine("SISTEMA DE LOCAÇÃO DE LIVRO 1.0");

            // o ponto de exclamação dentro do while, indica que está recebendo uma condição negativa, neste caso, se !RealizaLoginSistema
            // for falso, continue no loop.
            //Aqui realizamos a tela de login do nosso sistema
            LoginDoSistema();

            //Realizamos a chamada "invok" do nosso menu do sistema em um metodo
            MostraMenuSistema();
            Console.ReadKey(true);
                                               
        }


        /// <summary>
        /// Mostra no console o menu disponível do sistema.
        /// </summary>
        private static void MostraMenuSistema()
        {
            //Iniciamos nossa variavel com o menor valor de int possivel
            var opcaoMenu = int.MinValue;
            //Aqui definimos se for diferente de 0 mantemos o sistema aberto se não finalizamos
            while (opcaoMenu!=0)
            {

                Console.Clear();
                Console.WriteLine("SISTEMA DE LOCAÇÃO DE LIVRO 1.0");

                //Mostra as opções de menu dentro do nosso sistema.
                Console.WriteLine("Menu Sistema");
                 Console.WriteLine("0 - Sair");
                 Console.WriteLine("1 - Listar usuários");
                 Console.WriteLine("2 - Listar livros");
                 Console.WriteLine("3 - Cadastrar livro");
                Console.WriteLine("4 - Cadastrar usuários");
                Console.WriteLine("5 - Remover usuários");
                Console.WriteLine("6 - Remover livros");
                Console.WriteLine("7 - Fazer LOGOFF");

                //Aqui vamos pegar numero digitado
                opcaoMenu = int.Parse(Console.ReadKey().KeyChar.ToString());

                //Executar proxima funcao
                switch (opcaoMenu)
                {
                     case 1:
                        //Realiza a chamada do menu de listagem de usuarios
                        MostrarUsuarios();                        
                    break;
                    case 2:
                        //Realiza a chamada do menu de listagem de livros
                        MostrarLivro();                        
                    break;
                    case 3:
                        // Metodo que inicializa a tela de adicionar um livro
                        AdicionarLivro();
                        break;
                    case 4:
                        // Metodo que inicializa a tela de adicionar um usuario
                        AdicionarUsuario();
                        break;
                    case 5:
                        //Metodo que inicializa a tela para remover um usuário.
                        RemoverUsuarioPeloID();
                        break;
                    case 6:
                        RemoverLivroPorID();
                        break;
                    case 7:
                        {
                            //Realiza o LOGOFF do sistema
                            Console.Clear();
                            LoginDoSistema();
                        }
                    break;

                default: break;

                }
                // Aqui vamos pegar número digitado
                // Executar próxima função

            }
        }

        private static void RemoverLivroPorID()
        {
            Console.WriteLine("Remover o livro pelo ID no sistema");
            // Metodo que mostra os livros criado anteriormente assim facilitando o usuario informar o ID correto para desativar
            MostrarLivro();

            Console.WriteLine("Informe o ID para desativar de sistema:");
            var livroID = int.Parse(Console.ReadLine());

            // Aqui chamamos RemoverLivroPorID da nossa classe que controla os livros do sistema.
            livrosController.RemoverLivroPorID(livroID);

            // Informamos que o livro foi desativado com sucesso.
            Console.WriteLine("Livro desativado com sucesso.");
            Console.ReadKey(true);

        }

        private static void RemoverUsuarioPeloID()
        {
            Console.WriteLine("Remover o usuário pelo ID no sistema");
            // Metodo que mostra os osoarios criado anteriormente assim facilitando o usuario informar o ID correto para desativar
            MostrarUsuarios();

            Console.WriteLine("Informe o ID para desativar de sistema:");
            var usuarioID = int.Parse(Console.ReadLine());

            // Aqui chamamos RemoverUsuarioPorID da nossa classe que conrola os usuarios do sistema.
            usuariosController.RemoverUsuarioPorID(usuarioID);

            // Infomramos que o usuario foi desativado com sucesso.
            Console.WriteLine("Usuário desativado com sucesso.");
            Console.ReadKey(true);

        }

        /// <summary>
        /// Metodo que adiciona dentro de nossa lista um novo login e senha de usuário.
        /// </summary>
        private static void AdicionarUsuario()
        {
            Console.WriteLine("Cadastrar usuário dentro do sistema!");
            Console.WriteLine("Informe um Login:");
            var loginUsuario = Console.ReadLine();
            Console.WriteLine("Informe uma Senha:");
            var senhaUsuario = Console.ReadLine();
            usuariosController.AdicionarUsuario(new Usuario()
            {
                Login = loginUsuario,
                Senha = senhaUsuario
            });

            Console.WriteLine("Usuário e senha cadastrados com sucesso!");
            Console.ReadKey(true);

        }


        /// <summary>
        /// Metodo que adiciona dentro de nossa lista um novo registro de livro.
        /// </summary>
        private static void AdicionarLivro()
        {
            // Identificamos que o mesmo esta na parte de cadastro de livros do sistema.
            Console.WriteLine("Cadastrar livro dentro do sistema:");
            // Informamos que para dar continuidade ele deve informar um nome para o livro.
            Console.WriteLine("Nome do livro para cadastro:");
            //Obtemos esta informação do usuario.
            var nomeDoLivro = Console.ReadLine();
            // "livrosController" livros controle e nosso "objeto" em memoria.
            // Com isso temos disponível nele ferramentas que nos ajudam a realizar as tarefas como adicionar um item a nossa lista de livros.
            livrosController.AdicionarLivro(new Livro()
            {
                // Aqui "Atribuimos" o nome que demos ao livro na propriedade Nome de nosso livro
                //com o sinal de apenas um "=" temos atribuição, passagem de valor
                Nome = nomeDoLivro,
                                
            }) ;

            // Indico que finalizamos o processo de cadastro do livro, assim o usuário já sabe
            // que o mesmo foi realizado e sem erros
            Console.WriteLine("Livro cadastrado com sucesso");
            // ReadKey apenas para que ele visualize esta infomração.
            Console.ReadKey(true);
        }


        /// <summary>
        /// Realiza o loop de condição de verificação do login e senha.
        /// </summary>
        public static void LoginDoSistema()
        {
            while (!RealizaLoginSistema())
            {
                Console.Clear();
                Console.WriteLine("Login e senha inválidos");
            }
        }

        /// <summary>
        /// Metodo que realiza os procedimentos completos de login dentro do sistema como solicitação de login e senha pelo console, assim
        /// como as respectivas validações que o mesmo precisa para entrar no sistema.
        /// </summary>
        /// <returns>Retorna verdadeiro quando login e senha informados estiverem corretos.</returns>
        private static bool RealizaLoginSistema()
        {
            
            //Informamos o que é preciso para entrar no sistema
            Console.WriteLine("Informe seu login e senha para acessar:");

            //Informamos no console que precisamos do Login do usuario
            Console.WriteLine("Login:");
            //Solicitamos o login
            var loginDoUsuario = Console.ReadLine();

            //Informamos no console que precisa da senha
            Console.WriteLine("Senha:");
            //Solicitamos a senha do usuario
            var senhaDoUsuario = Console.ReadLine();

            //Validamos o login de maneira duvidosa
            return usuariosController.LoginSistema(new Usuario()
            {
                Login = loginDoUsuario,
                Senha = senhaDoUsuario
            });
            

        }


        /// <summary>
        /// Metodo que mostra os livros já cadastrados em nossa lista
        /// </summary>
        private static void MostrarLivro()
        {
            //Para cada livro cadastrado temos a demostração no console por esta parte
            livrosController.RetornaListaDeLivros().ForEach(i=>
            Console.WriteLine($"\r\nO livro selecionado é: {i.Nome} e o seu ID é {i.Id}."));
            Console.ReadKey(true);
        }


        /// <summary>
        /// Metodo que mostra os usuarios já cadastrados em nossa lista
        /// </summary>
        private static void MostrarUsuarios()
        {
            //Para cada usuario cadastrado temos a demostração no console por esta parte
            usuariosController.RetornaListadeUsuarios().ForEach(i=>
            Console.WriteLine($"\r\nO usuário selecionado é: O ID é {i.Id}, p Login é {i.Login}, com a senha {i.Senha}."));
            Console.ReadKey(true);
        }
    }
}

﻿using LocacaoBiblioteca.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocacaoBiblioteca.Controller
{

    /// <summary>
    /// Classe que contem os metodos de usuarios do sistema
    /// </summary>
    public class UsuarioController
    {
        //instanciamento em memória, já presente na classe modeladora  
        private LocacaoContext contextDB = new LocacaoContext();

        /// <summary>
        /// Metodo que realiza o login dentro do nosso sistema
        /// Para realizar o login padrão use:
        /// - Login: Admin
        /// - Senha: Admin
        /// </summary>
        /// <param name="Usuario">Passamos um objeto de nome Usuario como parametro</param>
        /// <returns>Retorna verdadeiro quando existir o usuário com este login e senha</returns>
        public bool LoginSistema(Usuario usuarios)
        {
            return RetornaListadeUsuarios().Exists(x => x.Login == usuarios.Login && x.Senha == usuarios.Senha);
        }


        /// <summary>
        /// Metodo usado para adicionar um novo usuario no sistema
        /// </summary>
        /// <param name="usuario">Novo usuario que será adicionado a lista</param>
        public void AdicionarUsuario (Usuario usuario)
        {
            usuario.Id = contextDB.IdContadorUsuarios++;
            // Adiciona o meu usuario a minha lista, lista chamada através da instância de memória criada acima
            contextDB.ListaDeUsuarios.Add(usuario);
        }


        /// <summary>
        /// Metodo que retorna nossa lista interna de usuarios
        /// </summary>
        /// <returns>Lista contendo os usuarios ativos</returns>
        public List<Usuario> RetornaListadeUsuarios()
        {
            // retorna agora somente a lista de usuarios ativos com a expressão "Where(x => x.Ativo)"
            return contextDB.ListaDeUsuarios.Where(x => x.Ativo).ToList<Usuario>();
        }

        /// <summary>
        /// Metodo que desativa um registro de usuario cadastrado em nossa lista
        /// </summary>
        /// <param name="identificadoID">Parametro que identifica o usuario que será desativado</param>
        public void RemoverUsuarioPorID(int identificadoID)
        {
            // Aqui usamos o metodo FirstOrDefault para localizar nosso usuario dentro da lista
            // Com isso conseguimos acessar as propriedades dele e desativar o registro.
            contextDB.ListaDeUsuarios.FirstOrDefault(x => x.Id == identificadoID).Ativo = false;
        }

    }
}

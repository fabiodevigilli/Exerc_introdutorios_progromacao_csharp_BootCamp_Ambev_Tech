﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LocacaoBiblioteca.Model;


namespace LocacaoBiblioteca.Model
{
   public class LivrosController
    {

        public LivrosController()
        {
            Livros = new List<Livro>();
            {
                Livros.Add(new Livro()
                {
                    Nome = "Meu Primeiro Livro"

                });
                Livros.Add(new Livro()
                {
                    Nome = "Meu Segundo Livro"

                });
            }
        }
                          


        public List<Livro> Livros { get; set; }

    }
        
    }

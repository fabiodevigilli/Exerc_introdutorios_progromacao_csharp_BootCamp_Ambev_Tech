﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritmos
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Pessoa> pessoas = new List<Pessoa>();

            Pessoa p1 = new Pessoa();
            p1.Nome = "Gabriel";
            p1.Sexo = 'M';
            p1.Altura = 2.01;
            p1.Idade = 29;
            pessoas.Add(p1);

            Pessoa p2 = new Pessoa();
            p2.Nome = "Elóra";
            p2.Idade = 21;
            p2.Sexo = 'F';
            p2.Altura = 1.53;
            pessoas.Add(p2);

            Pessoa p3 = new Pessoa();
            p3.Nome = "Ronaldo";
            p3.Idade = 15;
            p3.Sexo = 'M';
            p3.Altura = 1.6;
            pessoas.Add(p3);

            List<Pessoa> menoresIdade = new List<Pessoa>();

            foreach (Pessoa p in pessoas)
            {
                if (p.Idade < 18)
                {
                    menoresIdade.Add(p);
                }
            }
            //Lambda = Where/OrderBy/FirstOrDefault
            pessoas.Where(c => c.Altura > 2 && c.Nome.ToUpper().StartsWith("E"));

            List<Pessoa> pessoasOrdenadasPorAltura = pessoas.OrderByDescending(p => p.Altura).ThenBy(c => c.Idade).ToList();

            pessoas.Where(pes => pes.Idade < 18);

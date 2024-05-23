﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploExplorando.Models
{
    public class Pessoa
    {
        private string _nome;
        private int _idade;
        public string Nome 
        { 
            get => _nome.ToUpper(); // essa expressão com => mais usada quando você tem só um linha para retornar chama body expressions
            
            set
            {
                if (value == "")
                {
                    throw new ArgumentException("O nome não pode ser vazio");
                }
                _nome = value;

            }
        }

        public string Sobrenome { get; set; }

        public int Idade 
        {
            get => _idade;

            set
            {
                if(value < 0) 
                {
                    throw new ArgumentException("A Idade não pode ser menor que 0");
                }
                _idade = value;
            }

        }

        public void Apresentar()
        {
            Console.WriteLine($"Nome: {Nome}, idade: {Idade}");
        }
    }
}
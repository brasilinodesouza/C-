using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Explorando_a_linguagem.Models
{
    public class Pessoa
    {
        public string Nome { get; set; }
        public int Idade { get; set; }

        public void Apresentar()
        {
            System.Console.WriteLine($"Nome: {Nome}, Idade: {Idade}");


        }
    }
}
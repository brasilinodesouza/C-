using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FundamentosPOO.Models
{
    public class Pessoa
    {
        public string Nome  { get; set; }
        public int Idade { get; set; }

        public void Apresentar()
        {
            System.Console.WriteLine($"Ola meu nome é {Nome} e tenho {Idade} anos");
        }

    

    }
}
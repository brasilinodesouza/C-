using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FundamentosPOO.Models
{
    public class Aluno : Pessoa
    {
        
        public double Nota { get; set; }

        public override void Apresentar()
        {
            System.Console.WriteLine($"Ola meu nome é {Nome} tenho {Idade} anos e minha nota é {Nota}");
        }

    }
}
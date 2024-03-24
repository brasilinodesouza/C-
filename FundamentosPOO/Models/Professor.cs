using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FundamentosPOO.Models
{
    public  class Professor : Pessoa
    {

       
        public double Salario { get; set; }

        public /*sealed*/ override void Apresentar()
        {
            System.Console.WriteLine($"Ola meu nome é {Nome} tenho {Idade} anos e minha renda é {Salario}");
        }
    }
}
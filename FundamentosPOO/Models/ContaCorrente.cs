using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FundamentosPOO.Models
{
    public class ContaCorrente
    {


        public ContaCorrente(int numeroConta, decimal saldoInicial)
        {   
            NumeroConta = numeroConta;
            saldo = saldoInicial;            
        }

        public int NumeroConta { get; set; }    
        private decimal saldo;
        public void Sacar (decimal valor)
        {

            if (saldo >= valor)
            {
            saldo -= valor;
            System.Console.WriteLine("Saque realizado");
            }
            else
            {
                System.Console.WriteLine("Saque negado");
            }
        }
        public void ExibirSaldo()
        {
            System.Console.WriteLine($"Saldo {saldo}");
        }


    }
}
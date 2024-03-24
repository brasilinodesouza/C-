using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FundamentosPOO.Models
{
    public class Diretor : Professor
    {
       


       public override void Apresentar()
        {
            System.Console.WriteLine($"Diretor");
        }

    }




}
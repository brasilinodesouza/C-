using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Explorando_a_linguagem.Models
{
    public class LeituraAquivo
    {
        public (bool Sucesso, string[] Linhas, int QuantidadeLinhas) LerArquivo(string caminho)
        {
            try 
            {
                string [] linhas = File.ReadAllLines(caminho);
                return(true, linhas, linhas.Count());
            }catch(Exception)
            {
                return(false, new string[0], 0);
            }
            



        }
    }
}
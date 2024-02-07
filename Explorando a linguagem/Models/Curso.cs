using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Threading.Tasks.Dataflow;

namespace Explorando_a_linguagem.Models
{
    public class Curso
    {
        public string Nome { get; set; }
        public List<Pessoa> Alunos { get; set; }


        public void AdicionarAluno(Pessoa aluno)
        {
            Alunos.Add(aluno);
        }
        public int ObertQuantidadeDeAlunoMatriculados()
        {
            int quantidade = Alunos.Count;
            return quantidade;
        }
        public bool RemoverAluno(Pessoa aluno)
        {
            return Alunos.Remove(aluno);
        }
        public void ListarAluno()
        {
            System.Console.WriteLine("Alunos do Matriculados:");
            
            for (int count = 0; count < Alunos.Count; count++)
            {
                string texto = $"Nº {count +1} - {Alunos[count].NomeCompleto} ";
                System.Console.WriteLine(texto);
                
            }
            
            
            
           
        }




    }
}
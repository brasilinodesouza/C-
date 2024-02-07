using Explorando_a_linguagem.Models;

Pessoa p1 = new Pessoa("Brasilino","de Souza Neto");
Pessoa p2 = new Pessoa("Mickaelly", "Mafra");



Curso cursoDeIngles = new Curso();
cursoDeIngles.Nome = "Ingles";
cursoDeIngles.Alunos = new List<Pessoa>();

cursoDeIngles.AdicionarAluno(p1);
cursoDeIngles.AdicionarAluno(p2);
cursoDeIngles.ListarAluno();






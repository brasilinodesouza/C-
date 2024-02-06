using Explorando_a_linguagem.Models;

Pessoa p1 = new Pessoa("Brasilino","de souza neto");
Pessoa p2 = new Pessoa(nome:"Mickaelly", sobrenome:"Mafra");



Curso cursoDeIngles = new Curso();
cursoDeIngles.Nome = "Ingles";
cursoDeIngles.Alunos = new List<Pessoa>();

cursoDeIngles.AdicionarAluno(p1);
cursoDeIngles.AdicionarAluno(p2);
cursoDeIngles.ListarAluno();






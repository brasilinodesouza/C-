using Explorando_a_linguagem.Models;
using System.Globalization;
//using Models;


bool? desejaReceberEmail = false;

if (desejaReceberEmail.HasValue && desejaReceberEmail.Value)
    {
        System.Console.WriteLine("SIM PARA EMAIL");
    }
else
    {   
        System.Console.WriteLine("NAO PRA EMAIL");
    }



















// //--------- TUUUUUUUUUUUUUUUUUUUPLA

// LeituraAquivo arquivo = new LeituraAquivo();

// var (sucesso, linhasArquivo, quantidadeLinhas) = arquivo.LerArquivo("Arquivos/arquivoLeitura.txt");


// if (sucesso)
// {
//     System.Console.WriteLine("Quantidade linhas: " + quantidadeLinhas);
//     foreach (string linhas in linhasArquivo)
//     {
//         System.Console.WriteLine(linhas);
//     }
// }else{
//     System.Console.WriteLine("Não foi possivel ler o arquivo");
// }


















// (int Id, string Nome, string Sobrenome) tupla = (1, "Brasilino", "de Souza Neto");

// System.Console.WriteLine($"Id: {tupla.Id}");
// System.Console.WriteLine($"Nome: {tupla.Nome}");
// System.Console.WriteLine($"Sobrneome: {tupla.Sobrenome}");






// Queue<int> fila = new Queue<int>();
// fila.Enqueue(2);
// fila.Enqueue(4);
// fila.Enqueue(6);
// fila.Enqueue(8);

// foreach(int item in fila)
// {
//     System.Console.WriteLine(item);
// }

// System.Console.WriteLine($"Removendo o elemento: {fila.Dequeue()}");

// foreach(int item in fila)
// {
//     System.Console.WriteLine(item);
// }







//new ExemploExcessao().Metodo1();






// try { 

//     string[] linhas = File.ReadAllLines("Arquivos/arquivoxLeitura.txt");

//     foreach(string linha in linhas)
//     {
//         System.Console.WriteLine(linha);
//     }
// }catch(Exception ex)
// {
//     System.Console.WriteLine($"Ocorreu uma execesao generica. {ex.Message}");
// }

















// CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("pt-BR");

// Pessoa p1 = new Pessoa("Brasilino","de Souza Neto");
// Pessoa p2 = new Pessoa("Mickaelly", "Mafra");



// Curso cursoDeIngles = new Curso();
// cursoDeIngles.Nome = "Ingles";
// cursoDeIngles.Alunos = new List<Pessoa>();

// cursoDeIngles.AdicionarAluno(p1);
// cursoDeIngles.AdicionarAluno(p2);
// cursoDeIngles.ListarAluno();






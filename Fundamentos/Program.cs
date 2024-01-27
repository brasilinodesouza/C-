// // --------------------  Array e lista -----------------------


// List<string> listaString = new List<string>();

// listaString.Add("SC");
// listaString.Add("RS");
// listaString.Add("PR");

// System.Console.WriteLine("UTILIZANDO FOREACH");
// int contador1 = 0;
// foreach (var Lista in listaString)
// {
//     System.Console.WriteLine($"Posição {contador1} - {listaString[contador1]} "); 
//     contador1++;
// }

// System.Console.WriteLine("UTILIZANDO FOR");
// for (int contador = 0; contador < listaString.Count; contador++)
// {
//     System.Console.WriteLine($"Posição {contador} - {listaString[contador]} ");    
// }


// int[] arrayInteiros = new int [3];

// arrayInteiros[0] = 72;
// arrayInteiros[1] = 64;
// arrayInteiros[2] = 50;


// int [] arrayInteirosDobrados = new int [arrayInteiros.Length * 2];
// Array.Copy (arrayInteiros, arrayInteirosDobrados, arrayInteiros.Length );


// // Array.Resize(ref arrayInteiros, arrayInteiros.Length * 2);

// for (int contador = 0; contador < arrayInteiros.Length; contador++)
// {
//     System.Console.WriteLine($"Posição numero {contador} - {arrayInteiros[contador]}");   
// }

// foreach (int valor in arrayInteiros)
// {
//     System.Console.WriteLine(valor);
// }




// // ----------- WHILE --------------------


// int numero = 10;
// int contador = 0;

// while (numero >= contador )
// {
//     Console.WriteLine($"Contador está no numero {contador}");
//     contador++;
// }




// ------------- FOR ---------------------

// int numero = 10;

// for (int contador = 0; contador <= numero; contador++)
// {
//     Console.WriteLine($"{numero} x {contador} = {numero * contador}");
// }
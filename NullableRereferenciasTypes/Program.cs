Console.WriteLine(" Nullable Reference Types ");

// Nullable Reference Types é uma funcionalidade do c# que permite que uma variável receba o valor null
// por padrão, uma variável string não pode receber o valor null

string nome = null;

Console.WriteLine(nome.ToUpper()); // ERROR 
Console.WriteLine(nome?.ToUpper()); // NULL aceita o valor corretamente
Console.WriteLine(nome ?? "Vitoria"); // Vitoria aceita o valor corretamente

//Integrar o operador ternario
Console.WriteLine("Digite o seu nome: ");

string nome = Console.ReadLine();
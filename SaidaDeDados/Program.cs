Console.WriteLine("Saída de dados");

int idade = 21;
string nome = "Vitoria";

Console.WriteLine(nome);
Console.WriteLine(idade);

//concatenação de strings 
//soma as strings
Console.WriteLine("A idade de " + nome + " é " + idade + " anos.");

// interpolação de strings
//coloca $ antes das aspas e coloca as variáveis dentro de {} 
Console.WriteLine($"A idade de {nome} é {idade} anos.");

//usar placeholders
Console.WriteLine("A idade de {0} é {1} anos.", nome, idade);



//sequencia de escape
// \n = quebra de linha
// \t = tabulação
// \r = retorno de carro
// \b = backspace
// \" = aspas duplas
// \\ = aspas simples
Console.WriteLine("A idade de \n{nome}\n é \n{idade}\n anos.");

Console.ReadLine();


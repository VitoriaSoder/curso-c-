Console.WriteLine("Exercicios da fase 2");

//1- Declare as variáveis nome, idade e nota atribuindo os valores “Paulo”, 17 e 7.5 e exiba a saída no formato :Aluno <nome> tem <idade> anos e nota <nota> usando a concatenação e a interpolação de strings.

string name = "paulo";
int idade = 17;
double nota = 7.5;

Console.WriteLine("Aluno " + name + " tem " + idade + " anos e nota " + nota); // concatenação

Console.WriteLine($"Aluno {name} tem {idade} anos e nota {nota}"); // interpolação



//2- Para o exercício anterior exiba o nome a idade e a nota em linhas separadas usando as sequências de escapes.

Console.WriteLine("Nome: {0}\nIdade: {1}\nNota: {2}", name, idade, nota); // concatenação com sequencia de escapes
Console.WriteLine($"Nome: {name}\nIdade: {idade}\nNota: {nota}"); // interpolação com sequencia de escapes


//3- Para qual tipo de dados você pode converter um float implicitamente ?
// ( ) int
// (X ) double
// ( ) long
// ( ) decimal

//Resposta: O float pode ser convertido implicitamente para double pois o double tem maior precisão que o float.

// 4- Em qual conversão numérica você precisaria realizar o casting (convesão forçada) ?
// ( ) int para long // não precisa de conversão explícita, pois int é menor que long
// (x ) double para long // precisa de conversão explícita, pois double é maior que long
// ( x) double para float // precisa de conversão explícita, pois double é maior que float
// (x ) decimal para float // precisa de conversão explícita, pois decimal é maior que float
// ( x) long para int // precisa de conversão explícita, pois long é maior que int
// (x ) double para decimal // precisa de conversão explícita, pois double é maior que decimal

//Explicação do que é casting: é o processo de converter uma variável de um tipo de dado para outro tipo de dado
//Resposta: o casting explícito (conversão forçada) é necessário quando existe risco de perda de informação, como ao converter um tipo maior ou mais preciso para um tipo menor ou menos preciso.

// 5- Escreva um programa que recebe 3 letras via teclado e as exiba na ordem reversa usando
// a concatenação e também a interpolação de strings

Console.WriteLine("Digite 3 letras \n");

var letras = Console.ReadLine();

Console.WriteLine(letras);

Console.WriteLine("Ordem reversa: " + string.Concat(letras?.Reverse()));
//Usamos o concat para juntar as sequencias de caracteres automaticamente e depois usamos o reverse para inverter a ordem da string

// 6- Marque verdadeiro(V) ou falso(F) para os códigos abaixo:
// ( ) long resultado = 1.32;
// ( ) var nome = “Maria”;
// ( ) string resultado = 100.ToString();
// ( ) A sequência de escape \n inclui uma nova linha
// ( ) float f = 5.45;
// ( ) decimal valor = (decimal) 10.99f;
// ( ) var status = null;
// ( ) object o = 12.45m;
// ( ) string titulo = true.ToString();
// ( ) A sequencia \t inclui uma tabulação vertical
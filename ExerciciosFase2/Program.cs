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
// (v) long resultado = 1.32;
// (v) var nome = “Maria”;
// (v) string resultado = 100.ToString();
// (v) A sequência de escape \n inclui uma nova linha
// (v) float f = 5.45;
// (v) decimal valor = (decimal) 10.99f;
// (f) var status = null;
// (v) object o = 12.45m;
// (v) string titulo = true.ToString();
// (v) A sequencia \t inclui uma tabulação vertical


//7- Escreva um programa para receber dois valores via teclado do tipo double e a seguir
//realize as operações de soma, subtração, multiplicação, exponenciação, divisão e módulo
//exibindo o resultado:

var numero1 = Console.ReadLine("Digite o primeiro número: ");
var numero2 = Console.ReadLine("Digite o segundo número: ");

// conversão explicita de double para double
double numero1Double = Convert.ToDouble(numero1);
double numero2Double = Convert.ToDouble(numero2);

Console.WriteLine("Soma: " + (numero1Double + numero2Double));
Console.WriteLine("Subtração: " + (numero1Double - numero2Double));
Console.WriteLine("Multiplicação: " + (numero1Double * numero2Double));
Console.WriteLine("Exponenciação: " + (Math.Pow(numero1Double, numero2Double)));
Console.WriteLine("Divisão: " + (numero1Double / numero2Double));
Console.WriteLine("Módulo: " + (numero1Double % numero2Double));




 //8 - Faça um programa para calcular o resultado da fórmula de baskara dados os valores de
// a b e c .
// Valores : a = 1 , b = 12 e c = -13

var a = 1;
var b = 12;
var c = -13;

var delta = (b * b) - 4 * a * c;

Console.WriteLine("Delta: " + delta);



//9- Escreva um programa que receba um nome e uma senha via teclado. Nome é uma string e
//Senha é um inteiro. Se o nome for igual a ‘admin’ ou ‘maria’ e a senha for igual a ‘123’
//então exiba a mensagem ‘Login feito com sucesso’ caso contrário exiba a mensagem ‘Login
//inválido’: (use o operador condicional ternário)


var nome = console.ReadLine("Escreva seu nome aqui: ");
var senha = console.ReadLine("Escreva sua senha aqui: ");


var login = (nome == "admin" || nome == "maria") && senha == "123" ? "Login feito com sucesso" : "Login inválido";

Console.WriteLine(login);


// 10- Indique verdadeiro(V) ou falso (F) para as seguintes declarações de variáveis considerando
// a nomenclatura usada:
// (V) string? nome; é um exemplo de nullable reference type;
// (F) para x igual a 0 , Console.WriteLine(x++); imprime o valor 1
// (V) A ordem de precedência dos operadores lógicos é : ! , || e && (NOT, OR e AND)
// (V) para y igual a 0 , Console.WriteLine(++y); imprime o valor 1
// (V) (10 % 2 == 0) ? “Par” : “Impar”; Vai retornar “Impar”
// (F) Para x=25 e y=5 , a expressão ( y >= x ) && ( y <= x ); retorna true;
// (V) Os nullable reference types emitem um alerta em tempo de compilação para uso do null
// (F) Para x = 10 , o código Console.WriteLine(x+=x); imprime o valor 10;
// (V) Para x= 5 , a expressão !(9 >= x) && x <= 7 || x == 5); retorna false;
// (V) O operador ?. permite verificar se um objeto é null e evitar o NullReferenceException
// (V) Qualquer tipo de dado pode ser declarado como anulável com a ajuda do operador "?"


//11- Escreva um programa que recebe via teclado dois números inteiros x e y e imprima no
//console se x é par ou não e se y é par ou não. Use o operador condicional ternário (? :)



// 12- Crie um programa que receba um numero inteiro x via teclado e calcule e imprima no
// console o resultado das seguintes operações : (x^2 -> x ao quadrado) (pi = 3.1415)
// -6 + x * 5
// (13-2) * x
// (x + -2) * (20 / x)
// (12 + x) / (x - 4)
// 3 x^2 + x + 10
// pi * x^2
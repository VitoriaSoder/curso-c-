
//1- Crie uma variável chamada idade e atribua a ela o valor 35 e exiba o seu valor.

int idade = 35;
Console.WriteLine("O valor é" + idade);

//2- Crie uma variável chamada nome e atribua o valor "Maria" e exiba o seu valor.
string nome = "Maria";
Console.WriteLine("O valor é" + nome);

//3- Crie uma variável chamada altura e atribua a ela o valor 3.4a
double altura = 3.4;
Console.WriteLine("O valor é" + altura)


//4- Crie uma variável chamada data e atribua a ela a data 04/09/1999 e exiba o seu valor

DateTime data new DateTime(04,09,1999);
Console.WriteLine(data)

//5- Crie uma constante chamada ano e atribua a ela o valor 12 e exiba o seu valor;


const int ANO = 12;
Console.WriteLine("O valor é" + ANO);

//6- Declare uma variável nota do tipo double como sendo do tipo Nullable type e atribua o
//valor 7.80 e exiba o seu valor.

double? nota = 7.80;
Console.WriteLine("O valor é" + nota);



//7- Quais as diferenças entre os tipos por valor e os tipos por referência ?

//Tipos por valor (Value Types)
//Armazenam diretamente o valor.
//Exemplos: int, float, double, bool, char, struct.
//Copiados integralmente quando atribuídos.
//Exemplo:
//int a = 10;
//int b = a; // b recebe uma cópia de 10

//Tipos por referência (Reference Types)
//Armazenam o endereço de memória (referência) onde o valor está guardado.
//Exemplos: string, class, array, interface, delegate.
//Compartilham a referência quando atribuídos.
//Exemplo:
//string x = "ola";
//string y = x; // x e y apontam para o mesmo lugar na memória

//8- Inclua o tipo de dados correto entre os parênteses nas seguintes declarações de variáveis:
//(int ) x = 10;
//( double) numero = 7.99;
//( char) letra = 'C';
//( float) temperatura = 27.4f;
//(bool ) ativo = false;
//( string) nome = "Manoel";
//( decimal) salario = 950.99m;
//(dateTime ) hoje = DateTime.Now;


//9- Dada as variáveis declaradas a seguir classifique-as em tipos por valor(V) e tipos por
//referência (R) :
//( v) int n = 1;
//( r) string titulo = "A vida";
//(v ) float f = 12.45f;
//( v) double d = 5.45;
//( v) decimal valor = 10.99m;
//(v ) char sexo = ‘M’;
//(r ) object o = null;


//10- O que é um nullable type e qual a sua utilidade ?

// nullable type é um tipo de dado que pode receber valor nulo, ou seja, ele pode ser nulo. e sua uti
// utilidade é de indicar se um campo é opcional, ou seja, ele pode ser preenchido ou não

//11- O que é Camel Case ? Dê um exemplo de sua aplicação.

// camel case é uma convenção de nomenclatura usada em program=ação onde a primeira palavra é escrita em minúsculo e as palavras seguintes são escritas em maiúsculo
//exemplo: string nomeVariavel

//12- O que é Pascal Case ? Dê um exemplo de sua aplicação.
// pascal case é uma convenção de nomenclatura usada em programação onde a primeira palavra é escrita em maiúsculo e as palavras seguintes são escritas em maiúsculo
//exemplo: string NomeVariavel


//13- Declare duas variáveis x e y como sendo do tipo int e atribua a ela os valores 77 e 66 e a
//seguir imprima o valor da soma de x com y. (Use o operador aritmético + para realizar a
//operação de soma)

int x = 77;
int y = 66;
Console.WriteLine("A soma de x e y é: " + (x + y));


//14- Quais os valores padrões dos tipos de dados bool, char, int, double, float, decimal e
//string


// bool = false
// char = '\0'
// int = 0
// double = 0
// float = 0
// decimal = 0
// string = ""


//15- Indique verdadeiro(V) ou falso (F) para as seguintes declarações de variáveis
//considerando a nomenclatura usada:
//(f ) double 1valor = 12.45;
//( f) string #nome = "Pedro";
//( v) float _temperatura = 12.45f;
//( f) double int = 5;
//(v ) decimal renda extra = 91.45m;
//( v) bool status$conta = false;
//(v ) string titulo3 = “Tópico 1”;
//(v ) float salario_mensal = 1999.55f;
//(v ) int percentualValorDesconto = 5;
//(v ) const bool MENSALIDADE_EM_DIA = true;
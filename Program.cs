Console.WriteLine("Declaração de Variáveis Númericas!");

// byte: aceita números inteiros positivos de 0 a 255. Ocupa 8 bits (1 byte) de memória.
byte valor =  255;
Console.WriteLine("Variável do tipo byte: " + valor);

// sbyte (signed byte): aceita números inteiros negativos e positivos, de -128 a 127.
sbyte valor2 = -2;
Console.WriteLine("Variável do tipo short byte: " + valor2);

// int: tipo inteiro padrão. Armazena de aprox. -2.14 bilhões a 2.14 bilhões (32 bits).
int valor3 = 2147483647;
Console.WriteLine("Variável do tipo int: " + valor3);   

// uint (unsigned int): versão do int apenas para positivos, dobrando o limite para aprox. 4.29 bilhões.
uint valor4 = 2147483648;
Console.WriteLine("Variável do tipo uint: " + valor4);

// short: inteiro menor, varia de -32.768 a 32.767 (16 bits).
short valor5 = 32767;
Console.WriteLine("Variável do tipo short: " + valor5);

// long: para inteiros muito grandes, na casa dos quintilhões (64 bits).
long valor6 = 9223372036854775807;
Console.WriteLine("Variável do tipo long: " + valor6);

Console.ReadLine();

Console.WriteLine("Atribuindo valores double, float e decimal!");

// double: tipo padrão para decimais. Alta precisão (64 bits).
// Nota: O sufixo 'd' é opcional, pois o padrão do C# já é double.
double valor7 = 3.141592653589793;
Console.WriteLine("Variável do tipo double: " + valor7);

// float: ocupa menos memória (32 bits) e tem menos precisão.
// O sufixo 'f' é OBRIGATÓRIO, senão o C# tentará tratar como double e não compilará.
float valor8 = 3.14159f;
Console.WriteLine("Variável do tipo float: " + valor8);

// decimal: altíssima precisão (128 bits), ideal para cálculos financeiros/monetários.
// O sufixo 'm' é OBRIGATÓRIO, indicando que requer tratamento monetário de alta precisão.
decimal valor9 = 3.141592653589793m;
Console.WriteLine("Variável do tipo decimal: " + valor9);



Console.WriteLine("Declaração de variáveis bool e char!");

// bool: representa valores booleanos (verdadeiro ou falso). por padrão o default é false 
bool valor10 = true;
Console.WriteLine("Variável do tipo bool: " + valor10);

// char: representa um único caractere, envolto em aspas simples. por padrão o default é o caractere nulo
char valor11 = 'A';  // usar aspas simples, nunca usar aspas duplas, pois isso representa uma string
Console.WriteLine("Variável do tipo char: " + valor11);


Console.WriteLine("Tipos de referencia (string) (object) (dynamic)");

// string: representa uma cadeia de caracteres. por padrão o default é nulo (imutavel)
string valor12 = "Vitoria";
Console.WriteLine("Variável do tipo string: " + valor12);

// object: representa qualquer tipo de valor. por padrão o default é nulo (mutavel) suporta qualquer tipo de dado e possui verificação em tempo de execução
object valor13 = "Vitoria";
Console.WriteLine("Variável do tipo object: " + valor13);

// dynamic: representa qualquer tipo de valor. por padrão o default é nulo (mutavel) suporta qualquer tipo de dado não possui verificação em tempo de execução
dynamic valor14 = "Vitoria";
Console.WriteLine("Variável do tipo dynamic: " + valor14);


/*
Use string (ou o tipo específico int, bool, etc) em 99% das vezes. É seguro, rápido e te ajuda a não cometer erros.
Use object quando você realmente não souber o que vai receber, mas quiser que o compilador te obrigue a verificar o tipo antes de usar para manter a segurança.
Use dynamic apenas em cenários muito específicos e avançados (como ler arquivos JSON sem estrutura definida ou interagir com outras linguagens como Python), pois você perde toda a rede de segurança do C#.
*/



Console.WriteLine("Tratamento de data e hora ");

// Data e hora atual
DateTime dataAtual = DateTime.Now;

// Data e hora passada  
DateTime dataPassada = dataAtual.AddDays(-100);

// Data e hora futura
DateTime dataFutura = dataAtual.AddDays(100);

// Data e hora especifica

DateTime dataFormata = dataAtual.ToString("dd/MM/yyyy");

DateTime dataAjustada = dataAtual.AddMonths(2);

DateTime dataFormatada = dataAtual.ToString("dd/MM/yyyy")

Console.WriteLine(datatime nova);


//Extrair infromações da data atual

Console.WriteLine("Dia: " + dataAtual.Day);
Console.WriteLine("Mês: " + dataAtual.Month);
Console.WriteLine("Ano: " + dataAtual.Year);
Console.WriteLine("Hora: " + dataAtual.Hour);
Console.WriteLine("Minuto: " + dataAtual.Minute);
Console.WriteLine("Segundo: " + dataAtual.Second);
Console.WriteLine("Dia da semana: " + dataAtual.DayOfWeek);
Console.WriteLine("Dia do ano: " + dataAtual.DayOfYear);
Console.WriteLine("Fuso horário: " + dataAtual.TimeZone);
Console.WriteLine("Data e hora completa: " + dataAtual.ToString());
Console.WriteLine("Data e hora formatada: " + dataAtual.ToString("dd/MM/yyyy HH:mm:ss"));


//Adicionando valores

Console.WriteLine("Data atual: " + dataAtual);  
Console.WriteLine("Data atual + 100 dias: " + dataAtual.AddDays(100)); 
Console.WriteLine("Data atual - 100 dias: " + dataAtual.AddDays(-100)); 
Console.WriteLine("Data atual + 2 meses: " + dataAtual.AddMonths(2)); 
Console.WriteLine("Data atual - 2 meses: " + dataAtual.AddMonths(-2)); 
Console.WriteLine("Data atual + 1 ano: " + dataAtual.AddYears(1)); 
Console.WriteLine("Data atual - 1 ano: " + dataAtual.AddYears(-1)); 
Console.WriteLine("Data atual + 1 hora: " + dataAtual.AddHours(1)); 
Console.WriteLine("Data atual - 1 hora: " + dataAtual.AddHours(-1)); 
Console.WriteLine("Data atual + 1 minuto: " + dataAtual.AddMinutes(1)); 
Console.WriteLine("Data atual - 1 minuto: " + dataAtual.AddMinutes(-1)); 
Console.WriteLine("Data atual + 1 segundo: " + dataAtual.AddSeconds(1)); 
Console.WriteLine("Data atual - 1 segundo: " + dataAtual.AddSeconds(-1)); 

//Pegando o dia da semana 

Console.WriteLine("Dia da semana: " + dataAtual.DayOfWeek);  

//Pegando o dia do ano

Console.WriteLine("Dia do ano: " + dataAtual.DayOfYear);  

//Pegando o fuso horário

Console.WriteLine("Fuso horário: " + dataAtual.TimeZone);  

//Pegando a data e hora completa

Console.WriteLine("Data e hora completa: " + dataAtual.ToString());  

//Pegando a data e hora formatada

Console.WriteLine("Data e hora formatada: " + dataAtual.ToString("dd/MM/yyyy HH:mm:ss"));

//Data no formato longo e curto 

Console.WriteLine("Data no Formato longo" + dataAtual.ToLongDateString());  
Console.WriteLine("Data no Formato curto" + dataAtual.ToShortDateString());  
Console.WriteLine("Hora no Formato longo" + dataAtual.ToLongTimeString());  
Console.WriteLine("Hora no Formato curto" + dataAtual.ToShortTimeString());  


/// ----------------------------------------- ///
/// Variaveis Nulaveis 
Console.WriteLine("Nullble Types")

// variaveis que podem receber valor nulo  

//Estrutura Nullable + type + name  + "=" + valorNulo;

Nullable<int> valor15 = null;  // ou int? valor15 = null;

Console.WriteLine("Variável do tipo Nullable<int>: " + valor15);

Nullable<bool> valor16 = null;

Console.WriteLine("Variável do tipo Nullable<bool>: " + valor16);

Nullable<char> valor17 = null;

Console.WriteLine("Variável do tipo Nullable<char>: " + valor17);

Nullable<string> valor18 = null;

Console.WriteLine("Variável do tipo Nullable<string>: " + valor18);

Nullable<double> valor19 = null;

Console.WriteLine("Variável do tipo Nullable<double>: " + valor19);

Nullable<decimal> valor20 = null;

Console.WriteLine("Variável do tipo Nullable<decimal>: " + valor20);


// Operador de coalescência nula (??)     
int a = 10;
int? b = a; // b pode ser 10 ou null
Console.WriteLine("Variável do tipo int?: " + b);

int? a = null

int b = a ?? 5;

//se a for igual a null, b recebera 5

Console.WriteLine("Variável do tipo int?: " + b);


//expressões
//tem que declarar com o nullAble para funcionar e evitar erros de compilação
int? a = null;
int? b = a * b

//hasValue e Value

//hasValue e para verificar se a variável tem valor
//value e para retornar o valor da variável

if (b.HasValue) {
    Console.WriteLine("O valor de b é: " + b.Value);
} else {
    Console.WriteLine("O valor de b é nulo");
}

if(b.value == 10){
    Console.WriteLine("O valor de b é 10");
} else {
    Console.WriteLine("O valor de b não é 10");
}

Console.ReadLine();

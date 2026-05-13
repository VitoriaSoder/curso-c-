Console.WriteLine("Operador ternario");  

// Operador ternario unitario (+) e unitario (-)

// utilizado para inverter o sinal do numero (positivo para negativo e negativo para positivo) 

int numero = 10;

numero = +numero;
Console.WriteLine(numero);

numero = -numero;
Console.WriteLine(numero);

//operador ternario (?:)

// Utilizado para escrever um if/else de forma mais concisa

int numero2 = 10;

string resultado = numero2 > 5 ? "Maior que 5" : "Menor ou igual a 5";

Console.WriteLine(resultado);

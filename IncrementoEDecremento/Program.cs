// OPERADORES DE INCREMENTO E DECREMENTO

// O operador de incremento incrementa o valor de uma variável em 1.

var contador = 10; // ou int contador = 10;



Console.WriteLine($"Valor inicial: {contador}"); // 10

// 1. Incremento Pós-Fixado (++ contador)
// O valor é usado primeiro na expressão, e SÓ DEPOIS é incrementado.
Console.WriteLine($"Pós-fixado (antes): {contador++}");  // Imprime 10, depois contador vira 11
Console.WriteLine($"Pós-fixado (depois): {contador}");  // 11

// 2. Incremento Pré-fixado (++ contador)
// O valor é incrementado PRIMEIRO, e aí sim é usado na expressão.
Console.WriteLine($"Pré-fixado (antes): {++contador}");  // Contador vira 12, imprime 12
Console.WriteLine($"Pré-fixado (depois): {contador}");  // 12


// O operador de decremento decrementa o valor de uma variável em 1.

// O operador de decremento decrementa o valor de uma variável em 1.

var contador2 = 10; 

Console.WriteLine($"Valor inicial: {contador2}"); 

// 1. Decremento Pós-fixado (-- contador2)
// O valor é usado primeiro na expressão, e SÓ DEPOIS é decrementado.
Console.WriteLine($"Pós-fixado (antes): {contador2--}");  // Imprime 10, depois contador2 vira 9
Console.WriteLine($"Pós-fixado (depois): {contador2}");  // 9

// 2. Decremento Pré-fixado (-- contador2)
// O valor é decrementado PRIMEIRO, e aí sim é usado na expressão.
Console.WriteLine($"Pré-fixado (antes): {--contador2}");  // Contador2 vira 8, imprime 8
Console.WriteLine($"Pré-fixado (depois): {contador2}");  // 8



//Operador de incremento ++

// var x = 5;
// Console.WriteLine(x++); // Imprime 5, depois x vira 6
// Console.WriteLine(x);   // Imprime 6

// var y = 5;
// Console.WriteLine(++y); // y vira 6, depois imprime 6
// Console.WriteLine(y);   // Imprime 6


//Operador de decremento --

// var x = 5;
// Console.WriteLine(x--); // Imprime 5, depois x vira 4
// Console.WriteLine(x);   // Imprime 4

// var y = 5;
// Console.WriteLine(--y); // y vira 4, depois imprime 4
// Console.WriteLine(y);   // Imprime 4


//Operadores de decremento --

//Console.WriteLine("--- Operadores de Decremento ---");

//var contador = 10;

//Console.WriteLine("Valor inicial: " + contador); // 10

// 1. Decremento Pós-fixado (-- contador)
// O valor é usado primeiro na expressão, e SÓ DEPOIS é decrementado.
//Console.WriteLine("Pós-fixado (antes): " + contador--);  // Imprime 10, depois contador vira 9
//Console.WriteLine("Pós-fixado (depois): " + contador);  // 9

// 2. Decremento Pré-fixado (-- contador)
// O valor é decrementado PRIMEIRO, e aí sim é usado na expressão.
//Console.WriteLine("Pré-fixado (antes): " + --contador);  // Contador vira 8, imprime 8
//Console.WriteLine("Pré-fixado (depois): " + contador);  // 8

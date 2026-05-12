// Constantes

// Constantes são variáveis que não podem ser alteradas

// O padrão é usar UPPERCASE para constantes


const int ValorPadrao = 100;
const string NomePadrao = "Vitoria";


Console.WriteLine($"Valor Padrão: {ValorPadrao}");
Console.WriteLine($"Nome Padrão: {NomePadrao}");


// ValorPadrao = 200; // Erro
// NomePadrao = "Joao"; // Erro


Console.WriteLine("--- Taxa de Juros ---");

// Usando constante
const decimal TAXA_JUROS_ANUAL = 0.05m;

Console.WriteLine($"Taxa de Juros: {TAXA_JUROS_ANUAL}");

//Muitos utilizadas para formulas matematicas , taxas, valores fixos

const decimal PI = 3.14m;
const decimal area  = PI * 10m * 10m;
const decimal raio = 10m;


Console.WriteLine("Area: " + area);
Console.WriteLine("Raio: " + raio);
Console.WriteLine("PI: " + PI);


Console.ReadKey();

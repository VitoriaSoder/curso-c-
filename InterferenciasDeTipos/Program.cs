Console.WriteLine("--- Interferencias de Tipos! ---");

// --- EXPLICAÇÃO ---

// O método podem possuir um tipo implícito **VAR**

// Usar a palavra-chave **VAR** para instruir o compilador para deduzir o tipo da variável da expressão a partir do lado direto da instrução de inicialização 

// O tipo inferido pode ser um tipo interno, um tipo anônimo, um tipo definido pelo usuário ou um tipo definido na biblioteca de classes da plataforma .NET

//--- LIMITAÇÕES ---

//A palavra-chave VAR só pode ser usada quando uma variável local é declarada e inicializada na mesma instrução
// var name = "Maria"; 
// var name; // Erro 


//Não é possível inicializar a variável como NULL 

// var name = null; // Erro 

//Múltiplas variáveis do tipo implícito não podem ser inicializadas na mesma instrução 

//  var x = 10, y = 20, z = 30; // Erro

//Não podemos alterar o tipo da variável VAR depois de inicializada.
// var name = "Maria";
// name = 10; // Erro

// --- JEITO TIPADO NORMAL ---

// int idade = 10;
// string name = "Maria";
// decimal salario = 10.50m;

// Console.WriteLine($"Idade: {idade}, Nome: {name}, Salário: {salario}");


// --- JEITO COM INTERFERENCIA DE TIPOS ---

var idade = 10;
var name = "Maria";
var salario = 10.50m;

Console.WriteLine($"Idade: {idade}, Nome: {name}, Salário: {salario}");



Console.ReadKey();
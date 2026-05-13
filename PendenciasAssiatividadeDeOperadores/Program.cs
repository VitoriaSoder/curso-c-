Console.WriteLine("Pendencias Assiatividade de Operadores");

// A precedencia do operador é um conjunto de regras que define como uma expressão é avaliada 

// No c#, cada operador tem uma prioridade atribuida, e, com base nessa prioridade, a expressão é avaliada 

// as expressões com operadores de maior precedencia são avaliadas primeiro.

// Quando dois operadores tiverem a mesma precedencia eles são avaliados com base na associatividade do operador que pode ser da direta para esquerda ou da esquerda para a direita

//ex:

int x = 10 -2 * 3;
Console.WriteLine(x);

//ordem da operação
//1- Multiplicação: 2 * 3 = 6
//2- Subtração: 10 - 6 = 4

//compilador avaliar a multiplicação e depois realiza a subtração.
//Caso queira que a subtração seja realizada primeiro, utilize parênteses.
// (10 - 2) * 3 = 24

//ex:

int y = (10 - 2) * 3
Console.WriteLine(y);

Console.WriteLine(x);


Console.ReadKey();


//operadores condiçõnais (not, and, or)

//ex: 

int idade = 18;
int a = 10;


var resultado = !(a == 10) && (idade >= 18) || (idade < 18);

//O compilador avalia o NOT primeiro e depois o AND e depois o OR
//resultado = !(a == 10) && (idade >= 18) || (idade < 18);
//resultado = !true && (idade >= 18) || (idade < 18);
//resultado = false && (idade >= 18) || (idade < 18);
//resultado = false && true || (idade < 18);
//resultado = false && true || false;
//resultado = false && true || false;
//resultado = false || false;
//resultado = false;

bool resultado2 = !(a == 10) && (idade >= 18) || (idade < 18);


Console.WriteLine(resultado2);



Console.WriteLine(resultado);
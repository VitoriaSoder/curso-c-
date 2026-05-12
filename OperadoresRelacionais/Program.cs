Console.WriteLine("Operadores Relacionais");

// Os operadores relacionais são usados para comparar valores. Eles retornam um valor booleano (true ou false).

//Os tipos de operadores são:
//Igual a: ==
//Diferente de: !=
//Maior que: >
//Menor que: <
//Maior ou igual a: >=
//Menor ou igual a: <=

//ex igual a:

var idade = 18;

Console.WriteLine($"Ele tem 18 anos? {idade == 18}");

//usando o Equals
Console.WriteLine($"Ele tem 18 anos? {idade.Equals(18)}");


//ex diferente de:

Console.WriteLine($"Ele tem 18 anos? {idade != 18}");

//ex maior que:

var idade2 = 20;

Console.WriteLine($"Ele tem mais de 18 anos? {idade2 > 18}");

//ex menor que:

var idade3 = 16;

Console.WriteLine($"Ele tem menos de 18 anos? {idade3 < 18}");

//ex maior ou igual a:

var idade4 = 18;

Console.WriteLine($"Ele tem 18 anos ou mais? {idade4 >= 18}");

//ex menor ou igual a:

var idade5 = 18;

Console.WriteLine($"Ele tem 18 anos ou menos? {idade5 <= 18}");


//Maior ou igual 

var idade6 = 18;

Console.WriteLine($"Ele tem 18 anos ou mais? {idade6 >= 18}");

//Menor ou igual

var idade7 = 18;

Console.WriteLine($"Ele tem 18 anos ou menos? {idade7 <= 18}");


Console.ReadKey();
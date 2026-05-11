Console.WriteLine("Entrada de dados !");


//**ReadLine():** lê uma unica linha de entrada do fluxo de entrada padrão. Retorna a mesma **string**

Console.WriteLine("\n Informe seu nome ");
string nome = Console.ReadLine();

Console.WriteLine("Informe sua idade ");
int idade = Convert.ToInt32(Console.ReadLine());



Console.WriteLine("Sua idade é " + idade);

Console.WriteLine("Seu nome é " + nome);


Console.ReadKey();

//**Read():** Lê apenas um único caractère do fluxo de entrada padrão retorna o **valor ASCII** do caracter
//**ReadKey():** Lê apenas um único caractere do fluxo de entrada padrão. Obtém a próxima tecla pressionada pelo usuário. Retorna um tipo **ConsoleKeyInfo** É usado para segurar a tecla até que o usúario pressione uma tecla



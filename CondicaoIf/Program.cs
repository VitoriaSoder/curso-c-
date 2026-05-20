// Condição if 


// A condição if é usada para tomar decisões em um programa, ou seja, para executar um bloco de código se uma condição for verdadeira.

//Exemplo:

if (condição){
    //código a ser executado se a condição for verdadeira
}
else if (outra_condicao){
    //código a ser executado se a outra_condicao for verdadeira
}
else{
    //código a ser executado se nenhuma das condições for verdadeira
}

//Exemplo:

Console.WriteLine("Digite um número");
var numero = Convert.ToInt32(Console.ReadLine());

if (numero > 0){
    Console.WriteLine("O número é positivo");
}
else if (numero < 0){
    Console.WriteLine("O número é negativo");
}
else{
    Console.WriteLine("O número é zero");
}

//else é usado quando queremos que um código seja executado se nenhuma das condições for verdadeira

//Exemplo de else if:

Console.WriteLine("Digite um número");
var numero = Convert.ToInt32(Console.ReadLine());

if (numero > 0){
    Console.WriteLine("O número é positivo");
}
else if (numero < 0){
    Console.WriteLine("O número é negativo");
}
else{
    Console.WriteLine("O número é zero");
}

//else if é usado quando queremos que um código seja executado se uma das condições for verdadeira

//Exemplo de else if: 

if (numero > 0){
    Console.WriteLine("O número é positivo"); // primeira condição verificada se for verdadeira executa o código e sai do if
}
else if (numero < 0){
    Console.WriteLine("O número é negativo"); // Segunda condição verificar e se não for verdadeira executa o código e sai do 
}
else{
    Console.WriteLine("O número é zero"); // Se nenhuma das condições for verdadeira executa o código e sai do if
}
Console.WriteLine("Conversão de tipos");


//conversão implicita
// é a conversão automática de um tipo de dado para outro tipo de dado
// ex: int para double

int varInt = 100;
double varDouble = varInt;


Console.WriteLine(varDouble);



//conversão explicita
// é a conversão manual de um tipo de dado para outro tipo de dado
// ex: double para int
//casting 



double varDouble2 = 100.5;
int varInt2 = (int)varDouble2;




Console.WriteLine(varInt2);



int var1 = 10;
int var2 = 4;

//float resultado = var1/var2; // retornaria 2 caso eu queira que retorne a casa decimal eu preciso converter um dos valores para float
float resultado = (float)var1 / var2;


Console.WriteLine(resultado);


Console.ReadLine();




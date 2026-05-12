Console.WriteLine("Operadores Lógicos");

// Operadores lógicos são usados para combinar ou inverter expressões booleanas. Eles retornam um valor booleano (true ou false).

//Os operadores lógicos são:
//AND: && // e
//OR: || // ou
//NOT: ! // não
//XOR: ^ // ou exclusivo (apenas um dos dois pode ser true)

//exemplo AND:

var idade = 18;
var temCNH = true;

Console.WriteLine($"Tem idade suficiente e tem CNH? {idade >= 18 && temCNH}");

//exemplo OR:

var temDinheiro = true;
var temCartao = false;

Console.WriteLine($"Tem dinheiro ou tem cartão? {temDinheiro || temCartao}");

//exemplo NOT:

var chovendo = true;

Console.WriteLine($"Não está chovendo? {!chovendo}");

//exemplo XOR:

var diaSemana = "Sexta";

Console.WriteLine($"É sexta ou é fim de semana? {diaSemana == "Sexta" ^ diaSemana == "Sábado" ^ diaSemana == "Domingo"}");
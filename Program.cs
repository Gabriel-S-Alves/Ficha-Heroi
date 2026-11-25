int vida = 100;
int moeda = 20;
int nivel = 1;


System.Console.WriteLine("Qual teu nome?");
string nome = Console.ReadLine();
Console.WriteLine();


//Ficha
Console.ForegroundColor = ConsoleColor.Green;
System.Console.WriteLine($"Nome do usuário: {nome}");
System.Console.WriteLine($"Vida: {vida}");
System.Console.WriteLine($"Moedas: {moeda}");
System.Console.WriteLine($"Nível: {nivel}");

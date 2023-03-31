Console.WriteLine("Bem Vindo ao Pet Hotel!");
Console.WriteLine("Qual seu pet?");
string pet = Console.ReadLine ()!;

Console.WriteLine ($"Seu, {pet} é de que cor?");
string cor = Console.ReadLine ()!;

Console.WriteLine ($"Seu, {pet} é de que raça?");
string raça = Console.ReadLine ()!;

Console.WriteLine ($"Qual nome do seu {pet}?");
string nome = Console.ReadLine ()!;

Console.WriteLine ($"O pet {nome} tem quantos anos?");
string anos = Console.ReadLine ()!;


Console.WriteLine("+=========================================================+");
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("                         Pet Hotel                         ");
Console.ResetColor();
Console.WriteLine("+=========================================================+");

Console.ForegroundColor = ConsoleColor.Blue; 
Console.WriteLine(@$"Espécie: {pet}           | Raça:{raça}");

Console.ResetColor();
Console.WriteLine("+=========================================================+");

Console.ForegroundColor = ConsoleColor.Blue; 
Console.WriteLine(@$"Atende pela alcunha de: {nome}                         
Idade: {anos}              | Pelagem/cor:  {cor}");                

Console.ResetColor();
Console.WriteLine("+=========================================================+");

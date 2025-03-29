Console.WriteLine("Olá, meu nome é Cebolinha. Digite uma flase pala eu lepetila: ");
string frase = Console.ReadLine()!;
frase = frase.Replace("r", "l").Replace("R", "L");
Console.WriteLine($"Eu lepetilei: {frase}");
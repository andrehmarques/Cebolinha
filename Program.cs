string frase, fraseL;

Console.WriteLine("Digite uma frase para ser dita pelo cebolinha: ");
frase = Console.ReadLine()!;


fraseL = frase.Replace("R","L").Replace("r", "l");
Console.Write($"Cebolinha disse: {fraseL}");
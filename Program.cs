string frase= "";

Console.Write("Digite uma frase: ");
frase = Console.ReadLine();

Console.Write(frase.Replace("r", "l").Replace("R", "L"));

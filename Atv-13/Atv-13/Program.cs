int numeroSecreto = 7;

do
{
    Console.Write("\nDigite um número de 0 a 20: ");
    numeroSecreto = int.Parse(Console.ReadLine());

    if (numeroSecreto != 7)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("\nVocê errou o número secreto");
        Console.ResetColor();
    }

    
}
while (numeroSecreto != 7);

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine($"\nExcelente!! Você acertou o número secreto que é: {numeroSecreto}");
Console.ResetColor();

Console.WriteLine("\nPressione algum botão para encerrar o programa !!.");
Console.ReadKey();
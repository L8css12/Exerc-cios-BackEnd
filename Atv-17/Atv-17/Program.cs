int numerop;

while (true)
{
    Console.Write("Digite um número positivo: ");
    string input = Console.ReadLine();

    if (int.TryParse(input, out numerop) && numerop > 0)
    {
        break;
    }
    else
    {
        Console.WriteLine("Por favor, digite um número inteiro positivo!");
    }
}

Console.WriteLine($"Números ímpares de 1 até {numerop}:");
for (int i = 1; i <= numerop; i += 2)
{
    Console.WriteLine(i);
}

Console.WriteLine("Agora pressione qualquer tecla para encerrar o programa !");
Console.ReadKey();

try
{
    Console.Write("Digite o primeiro numero(1) : ");
    int numero1 = int.Parse(Console.ReadLine());

    Console.WriteLine("Digite o segundo numero(2) : ");
    int numero2 = int.Parse(Console.ReadLine());

    int resultado = numero1 + numero2;
    Console.WriteLine($"O resultado da adição é : {resultado}");
}

catch (FormatException)
{
    Console.WriteLine("Erro: Por favor, digite apenas números válidos");
}

Console.ReadKey();
double Tabuada;

Console.Write("Insira um número positivo de 1 a 10 para que seja exibida sua tabuada: ");
double numero = double.Parse(Console.ReadLine());

for (int i = 0; i <= 10; i++)
{
    Tabuada = numero * i;
    Console.WriteLine($"{numero} x {i} = {Tabuada}");
}

Console.WriteLine("\nPresione qualquer tecla para encerrar a excecução do programa");
Console.ReadKey();
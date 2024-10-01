int numero1, resultado;
Console.Write("Informe o número: ");
numero1 = int.Parse(Console.ReadLine());

resultado = numero1;
for (int i = numero1 - 1; i >= 1; i--)
{
    Console.WriteLine($"\n{resultado} x {i}");

    resultado = resultado * i;

    Console.WriteLine("  ");
}
Console.WriteLine($"\nFatorial de {numero1} é {resultado} ");

Console.WriteLine("\nAperte uma tecla para encerrar");
Console.ReadKey();
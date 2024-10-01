Console.Write("Informe a nota do aluno para classifica-lo: ");
int nota = int.Parse(Console.ReadLine());

if (nota >= 90 && nota <= 100)
{
    Console.WriteLine($"A classe do aluno é: A");
}

else if (nota >= 80 && nota <= 89)
{
    Console.WriteLine("A classe do aluno é: B");
}

else if (nota >= 70 && nota <= 79)
{
    Console.WriteLine("A classe do aluno é: C");
}

else if (nota >= 60 && nota <= 69)
{
    Console.WriteLine("A classe do aluno é: D");
}

else if (nota < 60)
{
    Console.WriteLine("A classe do aluno é: F");
}

else
{
    Console.WriteLine("Você digitou uma nota inválida !");
}

Console.ReadKey();

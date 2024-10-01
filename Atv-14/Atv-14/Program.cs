double adicao;
int menuh;
double numero1, numero2;

do
{
    Console.Write("\nDigite um número (1- Exibir um mensagem, 2- Fazer soma, 3- Sair): ");
    menuh = int.Parse(Console.ReadLine());

    switch (menuh)
    {
        case 1:
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nVocê foi o sorteado !! Você ganhou uma viagem com tudo incluso para qualquer lugar que quiser (:");
            Console.ResetColor();
            break;
        case 2:
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("\nInsira o primeiro número: ");
            numero1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Insira o segundo número: ");
            numero2 = Convert.ToInt32(Console.ReadLine());

            adicao = numero1 + numero2;
            Console.Write($"\nA soma dos números inseridos é: {adicao}");
            Console.ResetColor();
            break;
    }
}

while (menuh != 3);


Console.WriteLine("\nPrograma encerrado.");
Console.ReadKey();
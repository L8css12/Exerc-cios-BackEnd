Console.Write("Digite um numero de 1 a 12: ");
double NumeroDoMes = double.Parse(Console.ReadLine());

switch (NumeroDoMes)
{
    case 1:
        Console.WriteLine("O mes escolhido foi Janeiro e a estação do ano é: Verão");
        break;

    case 2:
        Console.WriteLine("O mes escolhido foi Fevereiro e a estação do ano é: Verão");
        break;

    case 3:
        Console.WriteLine("O mes escolhido foi Março e a estação do ano é: Outono");
        break;

    case 4:
        Console.WriteLine("O mes escolhido foi Abril e a estação do ano é: Outono");
        break;

    case 5:
        Console.WriteLine("O mes escolhido foi Maio e a estação do ano é: Outono");
        break;

    case 6:
        Console.WriteLine("O mes escolhido foi Junho e a estação do ano é: Inverno");
        break;

    case 7:
        Console.WriteLine("O mes escolhido foi Julho e a estação do ano é: Inverno");
        break;

    case 8:
        Console.WriteLine("O mes escolhido foi Agosto e a estação do ano é: Inverno");
        break;

    case 9:
        Console.WriteLine("O mes escolhido foi Setembro e a estação do ano é: Primavera");
        break;

    case 10:
        Console.WriteLine("O mes escolhido foi Outubro e a estação do ano é: Primavera");
        break;

    case 11:
        Console.WriteLine("O mes escolhido foi Novembro e a estação do ano é: Primavera");
        break;

    case 12:
        Console.WriteLine("O mes escolhido foi Dezembro e a estação do ano é: Verão");
        break;


}

Console.ReadKey();
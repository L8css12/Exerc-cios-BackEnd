string[] diasSemana = new string[]
{
    "segunda-feira",
    "terça-feira",
    "quarta-feira",
    "quinta-feira",
    "sexta-feira",
    "sabado",
    "domingo",
};

string[] vtarefas = new string[7];

for (int i = 0; i < diasSemana.Length; i++)
{
    Console.Write($"Digite suas tarefas de {diasSemana[i]}: ");
    vtarefas[i] = Console.ReadLine();
}

Console.WriteLine("\n Suas tarefas da semana são : ");
for (int i = 0;i < vtarefas.Length;i++)
{
    Console.WriteLine($"{diasSemana[i]}: {vtarefas[i]}");
}

Console.ReadLine();

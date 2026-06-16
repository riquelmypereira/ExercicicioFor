double totalHotel = 0;

for (int i = 1; i <= 30; i++)
{
    Console.Write("Nome do cliente: ");
    string nome = Console.ReadLine();

    Console.Write("Quantidade de diárias: ");
    int diarias = int.Parse(Console.ReadLine());

    double taxa;

    if (diarias < 15)
    {
        taxa = 4;
    }
    else if (diarias == 15)
    {
        taxa = 3.60;
    }
    else
    {
        taxa = 3;
    }

    double totalConta = diarias * (50 + taxa);

    Console.WriteLine($"{nome} - Total: R$ {totalConta}");

    totalHotel += totalConta;
}

Console.WriteLine($"Total arrecadado pelo hotel: R$ {totalHotel}");
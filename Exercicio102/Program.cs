double totalDoHotel = 0;

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

    double total = diarias * (50 + taxa);

    totalDoHotel += total;

    Console.WriteLine($"{nome} pagará R$ {total}");
}

Console.WriteLine($"Total arrecadado: R$ {totalDoHotel}");
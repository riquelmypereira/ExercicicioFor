Console.WriteLine("1 - Executar 10 vezes");
Console.WriteLine("2 - Não executar nenhuma vez");
Console.WriteLine("3 - Executar 100 vezes");
Console.WriteLine("4 - Executar N vezes");

int opcao = int.Parse(Console.ReadLine());

if (opcao == 1)
{
    for (int i = 1; i <= 10; i++)
    {
        Console.Write("Digite A: ");
        int a = int.Parse(Console.ReadLine());

        Console.Write("Digite B: ");
        int b = int.Parse(Console.ReadLine());

        Console.WriteLine(a % b);
    }
}

if (opcao == 2)
{
    for (int i = 1; i <= 0; i++)
    {
        Console.WriteLine("Não executa");
    }
}

if (opcao == 3)
{
    for (int i = 1; i <= 100; i++)
    {
        Console.Write("Digite A: ");
        int a = int.Parse(Console.ReadLine());

        Console.Write("Digite B: ");
        int b = int.Parse(Console.ReadLine());

        Console.WriteLine(a % b);
    }
}

if (opcao == 4)
{
    Console.Write("Digite N: ");
    int n = int.Parse(Console.ReadLine());

    for (int i = 1; i <= n; i++)
    {
        Console.Write("Digite A: ");
        int a = int.Parse(Console.ReadLine());

        Console.Write("Digite B: ");
        int b = int.Parse(Console.ReadLine());

        Console.WriteLine(a % b);
    }
}

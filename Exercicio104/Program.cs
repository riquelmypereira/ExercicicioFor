Console.WriteLine("Escolha uma opção:");
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
        int A = int.Parse(Console.ReadLine());

        Console.Write("Digite B: ");
        int B = int.Parse(Console.ReadLine());

        int modulo = A % B;

        Console.WriteLine($"Módulo = {modulo}");
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
    for (int i = 1; i <= 10; i++)
    {
        for (int j = 1; j <= 10; j++)
        {
            Console.Write("Digite A: ");
            int A = int.Parse(Console.ReadLine());

            Console.Write("Digite B: ");
            int B = int.Parse(Console.ReadLine());

            int modulo = A % B;

            Console.WriteLine($"Módulo = {modulo}");
        }
    }
}

if (opcao == 4)
{
    Console.Write("Digite N: ");
    int N = int.Parse(Console.ReadLine());

    for (int i = 1; i <= N; i++)
    {
        Console.Write("Digite A: ");
        int A = int.Parse(Console.ReadLine());

        Console.Write("Digite B: ");
        int B = int.Parse(Console.ReadLine());

        int modulo = A % B;

        Console.WriteLine($"Módulo = {modulo}");
    }
}
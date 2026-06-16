int soma = 0;

for (int i = 85; i <= 907; i++)
{
    if (i % 2 == 0)
    {
        Console.WriteLine(i);
        soma += i;
    }
}

Console.WriteLine($"Soma = {soma}");
Console.Write("Digite N: ");
int n = int.Parse(Console.ReadLine());

double a = 0;

for (int i = 1; i <= n; i++)
{
    if (i % 2 != 0)
    {
        a += (double)i / (i + 1);
    }
    else
    {
        a -= (double)i / (i + 1);
    }
}

Console.WriteLine($"A = {a}");
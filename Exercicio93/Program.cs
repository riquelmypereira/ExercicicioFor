double graos = 1;
double total = 1;

for (int i = 2; i <= 64; i++)
{
    graos *= 2;
    total += graos;
}

Console.WriteLine($"Total de grãos: {total}");
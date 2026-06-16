Console.Write("Massa inicial: ");
double massa = double.Parse(Console.ReadLine());

int tempo = 0;

for (massa >= 0.05;)
{
    massa /= 2;
    tempo += 50;
}

Console.WriteLine($"Tempo necessário: {tempo} segundos");
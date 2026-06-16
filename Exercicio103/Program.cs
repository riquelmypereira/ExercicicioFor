Console.Write("Massa inicial: ");
double massa = double.Parse(Console.ReadLine());

int tempo = 0;

for (int i = 1; massa >= 0.05; i++)
{

    massa /= 2;
    tempo += 50;
}

Console.WriteLine($"Tempo necessário: {tempo} segundos");


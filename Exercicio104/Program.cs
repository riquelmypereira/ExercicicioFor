Console.Write("Primeiro número: ");
int primeiroNum = int.Parse(Console.ReadLine());

Console.Write("Segundo número: ");
int SegundoNum = int.Parse(Console.ReadLine());

int resultado = 0;

for (int i = 1; i <= SegundoNum; i++)
{
    resultado += primeiroNum;
}

Console.WriteLine($"Resultado = {resultado}");
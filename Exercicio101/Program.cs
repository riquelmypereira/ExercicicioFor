Console.Write("Digite um número: ");
int numero = int.Parse(Console.ReadLine());

long fatorial = 1;

for (int i = 1; i <= numero; i++)
{
    fatorial *= i;
}

Console.WriteLine($"{numero}! = {fatorial}");
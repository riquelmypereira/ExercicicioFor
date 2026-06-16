int soma = 0;
int maior = 0;
int menor = 0;

for (int i = 1; i <= 10; i++)
{
    Console.Write("Digite um número: ");
    int numero = int.Parse(Console.ReadLine());

    soma += numero;

    if (i == 1)
    {
        maior = numero;
        menor = numero;
    }

    if (numero > maior)
    {
        maior = numero;
    }

    if (numero < menor)
    {
        menor = numero;
    }
}

Console.WriteLine($"Média: {soma / 10.0}");
Console.WriteLine($"Maior: {maior}");
Console.WriteLine($"Menor: {menor}");
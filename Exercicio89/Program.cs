int somaPositivos = 0;
int quantidadeNegativos = 0;

for (int i = 1; i <= 50; i++)
{
    Console.Write($"Digite o {i}º valor: ");
    int numero = int.Parse(Console.ReadLine());

    if (numero > 0)
    {
        somaPositivos += numero;
    }

    if (numero < 0)
    {
        quantidadeNegativos++;
    }
}

Console.WriteLine($"Soma dos positivos: {somaPositivos}");
Console.WriteLine($"Quantidade de negativos: {quantidadeNegativos}");
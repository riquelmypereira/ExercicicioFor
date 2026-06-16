int somaIdades = 0;
int quantidadeIdades = 0;

double somaAlturas = 0;
int quantidadeAlturas = 0;

for (int i = 1; i <= 45; i++)
{
    Console.Write("Digite a idade: ");
    int idade = int.Parse(Console.ReadLine());

    Console.Write("Digite a altura: ");
    double altura = double.Parse(Console.ReadLine());

    if (altura < 1.70)
    {
        somaIdades += idade;
        quantidadeIdades++;
    }

    if (idade > 20)
    {
        somaAlturas += altura;
        quantidadeAlturas++;
    }
}

Console.WriteLine($"Média das idades: {somaIdades / (double)quantidadeIdades}");
Console.WriteLine($"Média das alturas: {somaAlturas / quantidadeAlturas}");
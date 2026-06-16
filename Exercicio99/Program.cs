Console.Write("Quantidade de funcionários: ");
int quantidade = int.Parse(Console.ReadLine());

double somaSalarios = 0;
double maiorSalario = 0;
double menorSalario = 0;

for (int i = 1; i <= quantidade; i++)
{
    Console.Write("Nome: ");
    string nome = Console.ReadLine();

    Console.Write("Salário: ");
    double salario = double.Parse(Console.ReadLine());

    somaSalarios += salario;

    if (i == 1)
    {
        maiorSalario = salario;
        menorSalario = salario;
    }

    if (salario > maiorSalario)
    {
        maiorSalario = salario;
    }

    if (salario < menorSalario)
    {
        menorSalario = salario;
    }
}

Console.WriteLine($"Média salarial: {somaSalarios / quantidade}");
Console.WriteLine($"Maior salário: {maiorSalario}");
Console.WriteLine($"Menor salário: {menorSalario}");
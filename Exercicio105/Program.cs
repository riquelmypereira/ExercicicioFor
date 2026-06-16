int a = 0;
int b = 1;

Console.WriteLine(a);
Console.WriteLine(b);

for (int i = 3; i <= 20; i++)
{
    int c = a + b;

    Console.WriteLine(c);

    a = b;
    b = c;
}
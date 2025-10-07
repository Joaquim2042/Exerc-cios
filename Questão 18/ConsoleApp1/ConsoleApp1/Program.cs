double num = 1;
double media = 1;

for (int i = 0; i < media; i++)
{
    if (num != 0)
    {
        Console.WriteLine("Digite um número.");
        num = double.Parse(Console.ReadLine());
    }
    if (num != 0)
    {
        media = num / 2;
        Console.WriteLine(media);
    }
}
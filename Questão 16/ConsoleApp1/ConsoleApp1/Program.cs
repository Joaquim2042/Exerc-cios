int n;
int resultado  = 0;

Console.WriteLine("Digite um número e vamos dizer o fatorial");
n = int.Parse(Console.ReadLine());

for (int i = 1; i < n; i++)
{
    resultado = (n - 1) * n;
}
Console.WriteLine(resultado);
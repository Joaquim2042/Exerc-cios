using System.Numerics;

int n;
int n2;
int n3;
int n4;
int n5;
int nega = 0;

Console.WriteLine("Digite 5 números.");
n = int.Parse(Console.ReadLine());
n2= int.Parse(Console.ReadLine());
n3 = int.Parse(Console.ReadLine());
n3 = int.Parse(Console.ReadLine());
n4 = int.Parse(Console.ReadLine());
n5 = int.Parse(Console.ReadLine());
Console.WriteLine($"{n}\n{n2}{n3}\n{n4}\n{n5}\n");

if ( n < 0)
{
    nega = nega + 1;
}
if (n2< 0)
{
    nega = nega + 1;
}
if (n3< 0)
{
    nega = nega + 1;
}
if (n4< 0)
{
    nega = nega + 1;
}
if (n5< 0)
{
    nega = nega + 1;
}
Console.WriteLine($"{nega} são negativos.");

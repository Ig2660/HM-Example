Console.WriteLine("Введите число; ");
string A = Console.ReadLine();
Console.WriteLine("Введите число; ");
string B = Console.ReadLine();
Console.WriteLine("Введите число; ");
string C = Console.ReadLine()!;

int a = int.Parse(A);
int b = int.Parse(B);
int c = int.Parse(C);

int max = a;

if (b > max)
{
    max = b;
}
if (c > max)
{
    max = c;
}

Console.WriteLine(max);


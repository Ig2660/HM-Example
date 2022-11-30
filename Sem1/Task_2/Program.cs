Console.WriteLine("Введите число: ");
string A = Console.ReadLine()!;
int a = int.Parse(A);

Console.WriteLine("Введите число: ");
string B = Console.ReadLine()!;
int b = int.Parse(B);

if (a > b)
{
    Console.WriteLine("max = " + a);
}
else
{
    Console.WriteLine("max = " + b);
}


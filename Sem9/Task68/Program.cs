Console.WriteLine("Enter m > 0");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Enter n > 0");
int n = int.Parse(Console.ReadLine());

Console.WriteLine();

int fun = AkkermanFunc(m, n);
Console.WriteLine(fun);


int AkkermanFunc(int m, int n)
{
    if (m == 0)
        return n + 1;
    if (n == 0)
        return AkkermanFunc(m - 1, 1);
    return AkkermanFunc(m - 1, AkkermanFunc(m, n - 1));
    
}

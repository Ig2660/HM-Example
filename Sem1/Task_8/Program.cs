Console.WriteLine("Введите число ");
string N = Console.ReadLine()!;

int n = int.Parse(N);

for (int i = 1; i <= n; i++)
{
    if (i % 2 == 0)
    {
        Console.WriteLine(i);
    }
}


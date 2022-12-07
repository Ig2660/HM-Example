Console.WriteLine("Введите число");
int number = int.Parse(Console.ReadLine()!);

if (number > 0)
{
    for (int i = 1; i <= number; i++)
    {
        Console.WriteLine(Math.Pow(i, 3));
    }
}
else
{
    for (int i = -1; i >= number; i--)
    {
        Console.WriteLine(Math.Pow(i, 3));
    }
}

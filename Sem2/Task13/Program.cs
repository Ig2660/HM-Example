Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine()!);

while (number >= 999 || number <= -999)
{
    number = number / 10;
}

if (number < 0)
{
    number = number * (-1);
}

if (number >= 100)
{
    Console.WriteLine(number % 10);
}
else
{
    Console.WriteLine("Третьей цифры нет");
}

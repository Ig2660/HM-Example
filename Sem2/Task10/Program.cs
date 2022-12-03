Console.WriteLine("Введите трехзначное число: ");
int number = int.Parse(Console.ReadLine()!);

if (number >= 100 && number < 1000)
{
    Console.WriteLine(number / 10 % 10);
}

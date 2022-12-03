Console.WriteLine("Введите номер дня недели");
int number = int.Parse(Console.ReadLine()!);

if (number >= 1 && number <=5)
{
    Console.WriteLine("нет");
}

if (number == 6 || number == 7)
{
    Console.WriteLine("да");
}
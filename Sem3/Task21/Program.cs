Console.WriteLine("Введите координату x1");
int x1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите координату y1");
int y1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите координату z1");
int z1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите координату x2");
int x2 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите координату y2");
int y2 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите координату z2");
int z2 = int.Parse(Console.ReadLine()!);



Console.WriteLine(Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2) + Math.Pow(z1 - z2, 2)));

Console.WriteLine("Enter number");
int number = int.Parse(Console.ReadLine()!);

int sumNumFunction = CalcSumNum(number);
Console.WriteLine(sumNumFunction);

int CalcSumNum(int lastNumber)
{
    int sum = 0;
    int count = 0;
    while (lastNumber != 0)
    {
        int num = lastNumber % 10;
        sum = sum + num;
        lastNumber = lastNumber / 10;
        count++;
    }
    return sum;
}



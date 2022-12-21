Console.WriteLine("Enter amount numbers");

int numberCount = int.Parse(Console.ReadLine()!);

Console.WriteLine(CountPositiveNumbersFromConsole(numberCount));

int CountPositiveNumbersFromConsole(int numberCount)
{
    int counter = 0;
    for (int i = 0; i < numberCount; i++)
    {
        int currentNumber = int.Parse(Console.ReadLine()!);
        if (IsPositive(currentNumber))
        {
            counter++;
        }
    }
    return counter;
}

bool IsPositive(int number)
{
    if (number > 0)
    {
        return true;
    }
    else
    {
        return false;
    }
    //return number > 0;
}

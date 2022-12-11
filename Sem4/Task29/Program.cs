using System;
Console.WriteLine("Enter number1");
int number1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Enter number2");
int number2 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Enter number3");
int number3 = int.Parse(Console.ReadLine()!);

int num = number1;
int minNum = number2;
int maxNum = number3;

int numNumber()
{
    if (num != minNum && num != maxNum && num > minNum && num < maxNum)
    {
        return num;
    }
    if (maxNum != minNum && num != maxNum && num < minNum && minNum < maxNum)
    {
        return minNum;
    }
    else
    {
        return maxNum;
    }
}

int minNumber()
{
    if (num != minNum && num != maxNum && num > minNum && num < maxNum)
    {
        return minNum;
    }
    if (maxNum != minNum && num != maxNum && num < minNum && minNum < maxNum)
    {
        return num;
    }
    else
    {
        return maxNum;
    }
}

int maxNumber()
{
    if (num != minNum && num != maxNum && num > minNum && num < maxNum)
    {
        return maxNum;
    }
    if (maxNum != minNum && num != maxNum && num > maxNum && minNum < maxNum)
    {
        return num;
    }
    else
    {
        return minNum;
    }
}

int numMax = maxNumber();
int numMin = minNumber();
int numMean = numNumber();

int[] GenerateArray()
{
    int[] array = new int[numMean];
    for (int i = 0; i < numMean; i++)
    {
        array[i] = new Random().Next(numMin,numMax);
    }
    return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < numMean; i++)
    {
        Console.WriteLine(array[i] + " ");
    }
}

 Console.WriteLine();


int[] arr = GenerateArray();
PrintArray(arr);
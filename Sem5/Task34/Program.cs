Console.WriteLine("Enter array size");
int sizeArray = int.Parse(Console.ReadLine()!);
Console.WriteLine("Enter number Min");
int minThreeDigitNum = int.Parse(Console.ReadLine()!);
Console.WriteLine("Enter number Max");
int maxThreeDigitNum = int.Parse(Console.ReadLine()!);

int[] array = GenerateArray(sizeArray, minThreeDigitNum, maxThreeDigitNum);

for (int i = 0; i < array.Length; i++)
{
    Console.Write(array[i] + " ");
}
Console.WriteLine();

int number = numbersEven(array);
Console.WriteLine(number);

int[] GenerateArray(int n, int min, int max)
{
    int[] array = new int[n];
    for (int i = 0; i < n; i++)
    {
        array[i] = new Random().Next(min, max + 1);
    }
    return array;
}


int numbersEven(int[] array)
{
    int num = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            num++;
        }
    }
    return num;
}

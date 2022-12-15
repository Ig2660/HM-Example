Console.WriteLine("Enter array size");
int sizeArray = int.Parse(Console.ReadLine()!);
Console.WriteLine("Enter number Min");
int minNum = int.Parse(Console.ReadLine()!);
Console.WriteLine("Enter number Max");
int maxNum = int.Parse(Console.ReadLine()!);

int[] array = GenerateArray(sizeArray, minNum, maxNum);

for (int i = 0; i < array.Length; i++)
{
    Console.Write(array[i] + " ");
}
Console.WriteLine();

int sumOdd = sumOddPosition(array);
Console.WriteLine(sumOdd);

int[] GenerateArray(int n, int min, int max)
{
    int[] array = new int[n];
    for (int i = 0; i < n; i++)
    {
        array[i] = new Random().Next(min, max + 1);
    }
    return array;
}

int sumOddPosition(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 != 0) 
        {
            sum = sum + array[i];
        }
    }
    return sum;
}

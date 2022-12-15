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

int[] GenerateArray(int n, int min, int max)
{
    int[] array = new int[n];
    for (int i = 0; i < n; i++)
    {
        array[i] = new Random().Next(min, max + 1);
    }
    return array;
}

int differenceMaxMin(int[] array) 
{
    int min = array[0];
    int max = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] < min)
            min = array[i];
        if (array[i] > max)
            max = array[i];
    }
    return max - min;
}


int result = differenceMaxMin(array);
Console.WriteLine("Max - Min = " + result);



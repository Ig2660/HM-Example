int[,] matrix = Create2DArray(4, 4, 1, 10);
Print2DArray(matrix);
Console.WriteLine();

Console.WriteLine(SmallSumString(matrix));

int SmallSumString(int[,] matrix)
{
    int[] sumString = new int[matrix.GetLength(0)];
    int min = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sumString[i] += matrix[i,j];
            if (i == 0)
            {
                min = sumString[i];
            }
        }
            if (sumString[i] < min)
            {
                min = sumString[i];
            }
    }
    return min;
}

int[,] Create2DArray(int m, int n, int min, int max)
{
    int[,] matrix = new int[m, n];

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(min, max + 1);
        }
    }
    return matrix;
}


void Print2DArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
}

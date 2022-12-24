Console.WriteLine("Enter m");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Enter n");
int n = int.Parse(Console.ReadLine());
Console.WriteLine();

int[,] matrix = Create2DArray(m, n, 1, 10);
Print2DArray(matrix);
Console.WriteLine();

PrintDoubleArray(MeanOfColumns(matrix));

double[] MeanOfColumns(int[,] matrix)
{
    int columnCount = matrix.GetLength(1);
    int rowCount = matrix.GetLength(0);
    double[] result = new double[columnCount];
    for (int j = 0; j < columnCount; j++)
    {
        int sum = 0;
        for (int i = 0; i < rowCount; i++)
        {
            sum += matrix[i,j];
        }
        result[j] = Math.Round((double)sum / rowCount, 2);
    }
    return result;
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

void PrintDoubleArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

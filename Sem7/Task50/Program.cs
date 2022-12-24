Console.WriteLine("Enter m");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Enter n");
int n = int.Parse(Console.ReadLine());
Console.WriteLine("Enter i");
int i1 = int.Parse(Console.ReadLine());
Console.WriteLine("Enter j");
int j1 = int.Parse(Console.ReadLine());

Console.WriteLine();

int[,] matrix = Create2DArray(m, n, 1, 10);
Print2DArray(matrix);

Console.WriteLine();

PrintNumberArray(matrix, i1, j1);

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

void PrintNumberArray(int[,] matrix, int i1, int j1)
{
    if (i1 < matrix.GetLength(0) && j1 < matrix.GetLength(1))
    {
        Console.WriteLine(matrix[i1, j1]);
    }
    else
    {
        Console.Write("This number not");
    }
}

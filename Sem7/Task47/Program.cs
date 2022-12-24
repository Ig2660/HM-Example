Console.WriteLine("Enter m");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Enter n");
int n = int.Parse(Console.ReadLine());

Console.WriteLine();

double[,] arr = Create2DArray(m, n, -10, 10);
Print2DArray(arr);

double[,] Create2DArray(int m, int n, double min, double max)
{
    double[,] matrix = new double [m,n];

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = new Random().NextDouble();
            double temp = matrix[i,j];
            temp = Math.Round(temp * (max - min) + min, 1); 
            matrix[i,j] = temp;
        }
    }
    return matrix;
}

void Print2DArray(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i,j] + " ");
        }
        Console.WriteLine();
    }
}

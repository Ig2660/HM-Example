Console.WriteLine("Enter M > 0");
int M = int.Parse(Console.ReadLine());
Console.WriteLine("Enter N > M");
int N = int.Parse(Console.ReadLine());
Console.WriteLine();

Console.WriteLine(PrintSum(M, N));

int PrintSum(int M, int N)
{
    if (M == N + 1) return  0;
    else return M + PrintSum(M + 1, N);
}


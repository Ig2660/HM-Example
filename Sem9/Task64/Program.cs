Console.WriteLine("Enter N");
int N = int.Parse(Console.ReadLine());
PrintArray(N);

void PrintArray(int N)
{
    int count = 0;
    if (N == 1 && N > 0)
    {
        Console.WriteLine(N);
    }
    else
    {
        Console.Write(N + ", ");
        PrintArray(N - 1);
        count++;
    }
}



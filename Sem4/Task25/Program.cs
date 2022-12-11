Console.WriteLine("Enter number1");
int number1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Enter number2");
int number2 = int.Parse(Console.ReadLine()!);

int numPower = Power(number1, number2);
Console.WriteLine(numPower);

int Power(int num1, int num2)
{
    int exponentiation = 1;
    if (num1 != 0 && num2 > 0)
    {
      for (int i = 1; i <= num2; i++)
      {
         exponentiation = exponentiation * num1;
      } 
    }
    else
    {
        exponentiation = 0;
    }
    return exponentiation;
}

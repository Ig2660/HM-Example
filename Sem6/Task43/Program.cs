Console.WriteLine("Enter value b1 ");
double b1 = double.Parse(Console.ReadLine()!);
Console.WriteLine("Enter value b2 ");
double b2 = double.Parse(Console.ReadLine()!);
Console.WriteLine("Enter value k1 ");
double k1 = double.Parse(Console.ReadLine()!);
Console.WriteLine("Enter value k2 ");
double k2 = double.Parse(Console.ReadLine()!);

double[] intersectPoiht = GetIntersectPoint(b1,b2,k1,k2);

Console.WriteLine(intersectPoiht[0]);
Console.WriteLine(intersectPoiht[1]);

double[] GetIntersectPoint(double b1, double b2, double k1, double k2)
{
    double[] result = new double[2];
    double x = (b2 - b1)/(k1 - k2);
    double y = k1 * x - b2;

    result[0] = x;
    result[1] = y;

    return result;
}
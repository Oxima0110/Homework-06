// Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
//  значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.Clear();

Console.WriteLine("Даны две прямые: y = k1 * x + b1, y = k2 * x + b2");
Console.WriteLine("Для нахождения точки пересечения этих прямых введите:");

Console.WriteLine("b1: ");
int b1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("k1: ");
int k1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("b2: ");
int b2 = int.Parse(Console.ReadLine()!);
Console.WriteLine("k2: ");
int k2 = int.Parse(Console.ReadLine()!);

double[] Point(double a, double b, double c, double d)
{
    double point_x = (a - c) / (d - b);
    double point_y = d * point_x + c;
    return new double[] { point_x, point_y };

}
double[] result = Point(b1, k1, b2, k2);
Console.WriteLine($"Точка пересечения прямых y = {k1} * x + {b1}, y = {k2} * x + {b2} => ({result[0]}, {result[1]}) ");

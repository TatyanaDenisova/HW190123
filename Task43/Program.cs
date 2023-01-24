/*Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
 заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)*/

double getUserData(string message)
{
    Console.WriteLine(message);
    double userData = double.Parse(Console.ReadLine()!);
    return userData;
}

void showCrossPoint(double b1, double b2, double k1, double k2)
{
    if (k1 == k2 && b1 != b2)
    {
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.WriteLine("Прямые параллельны");
        Console.ResetColor();
    }
    if (k1 == k2 && b1 == b2)
    {
        Console.ForegroundColor = ConsoleColor.DarkGreen;
        Console.WriteLine($"Прямые совпадают");
        Console.ResetColor();
    }
    if (k1 != k2)
    {
        double x = (b2 - b1) / (k1 - k2);
        double y = k1 * ((b2 - b1) / (k1 - k2)) + b1;
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.WriteLine($"Прямые пересекаются в точке ({x}, {y})");
        Console.ResetColor();
    }
}

double b1 = getUserData("Введите число b1");
double k1 = getUserData("Введите число k1");
double b2 = getUserData("Введите число b2");
double k2 = getUserData("Введите число k2");
showCrossPoint(b1, b2, k1, k2);

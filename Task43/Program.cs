// Напишите программу, которая найдет точку пересечения двух прямых, заданных уравнениями 
// у = k1 * x + b1, у = k2 * x + b2; значения b1, k1, b2, k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

void IntersectionPoint(double b1, double k1, double b2, double k2)
{
    double x = (b1 - b2) / (k2 - k1);
    double y = (k1 * x) + b1;
    Console.WriteLine($"b1 = {b1}, k1 = {k1}, b2 = {b2}, k2 = {k2} -> ({x}; {y})");
}

double EnterNum(string text)
{
    Console.WriteLine(text);
    double num = double.Parse(Console.ReadLine());
    return num;
}

double b1 = EnterNum("Введите точку b1: ");
double k1 = EnterNum("Введите точку k1: ");
double b2 = EnterNum("Введите точку b2: ");
double k2 = EnterNum("Введите точку k2: ");
IntersectionPoint(b1, k1, b2, k2);
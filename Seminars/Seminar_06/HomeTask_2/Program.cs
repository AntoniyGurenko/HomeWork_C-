// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
// значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

double InputNum(string message)
{
    System.Console.Write(message);
    return double.Parse(Console.ReadLine()!);
}

void FindIntersectionPointTwoLines(double b1, double k1, double b2, double k2)
{
    if(k1 == k2 || b1 == b2)
        System.Console.WriteLine("Прямые совпадают");
    else if (k1 == k2)
        System.Console.WriteLine("Прямые паралельны");
    else
    {
        double x = Math.Round((b1 - b2) / (-(k1 - k2)), 2);
        double y = Math.Round(k2 * x + b2, 2);

        Console.WriteLine($"({x}; {y})");
    }
}

// ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
// вопрос: почему при приведённых ниже значениях y = 0,65 при формуле выше, но  если сделать k2 * x + b2, y = 0,66? 
// Получается подстановка x к одному из уровнений работает не точно или у меня ошибка в коде?
// Один сайт показал что выйдет 0,67 ---- https://www.math10.com/ru/geometria/geogebra/geogebra.html

// double k1 = 5;
// double b1 = 9;
// double k2 = 2;
// double b2 = 4;
//+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

double k1 = InputNum("Введите коофициент наклона первой прямой (k1): ");
double b1 = InputNum("Введите b первой прямой: ");
double k2 = InputNum("Введите коофициент наклона второй прямой (k2): ");
double b2 = InputNum("Введите b второй прямой: ");



FindIntersectionPointTwoLines(b1, k1, b2, k2);
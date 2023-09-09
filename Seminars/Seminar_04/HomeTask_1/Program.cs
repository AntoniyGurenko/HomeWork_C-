// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
int InputNum( string message) 
{
    System.Console.WriteLine(message);
    return int.Parse(Console.ReadLine()!);
}

int MathPow(int numA, int numB)
{
    int result = 1;
    for (int i = 1; i <= numB; i++)
    {
        result *= numA;
    }
    return result;
}

bool ValidateDegree(int degree)
{
    if (degree < 0)
    {
        System.Console.WriteLine("Степень не должна быть меньше нуля");
        return false;
    }
    return true;
}

int num = InputNum("Введите число, которое будем возводить в степень");
int degree = InputNum("Введите степень");

if (ValidateDegree(degree))
{
    System.Console.WriteLine($"{num}^{degree} -> {MathPow(num, degree)}");
}
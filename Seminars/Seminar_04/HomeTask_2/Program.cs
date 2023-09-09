// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12
int InputNum( string message) 
{
    System.Console.WriteLine(message);
    return int.Parse(Console.ReadLine()!);
}

int SumDigInNum(int num)
{
    int sum = 0;
    while (num != 0)
    {
        sum += num % 10; 
        num /= 10;
    }
    return sum;
}

int number = InputNum("Введите число");

System.Console.WriteLine();
System.Console.WriteLine($"{number} -> {SumDigInNum(number)}");
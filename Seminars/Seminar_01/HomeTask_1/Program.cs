//Задача 2. Напишите программу, которая на вход принимает 2 числа и выдаёт, какое число большее, а какое меньшее.

Console.WriteLine("Введите первое число:");
int number1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите второе число:");
int number2 = int.Parse(Console.ReadLine()!);
int max = 0;
int min = 0;

if (number1 > number2)
{
    max = number1;
    min = number2;
}
else
{
    max = number2;
    min = number1;
}Console.WriteLine($"Число {max} больше числа {min}.");

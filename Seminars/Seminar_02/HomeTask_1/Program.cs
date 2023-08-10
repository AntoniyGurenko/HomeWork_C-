// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает
//  вторую цифру этого числа. 456 -> 5, 782 -> 8


// int randNumb = new Random().Next(100, 1000); // С рандомным числом

// int secondDig = randNumb / 10 % 10;

// System.Console.WriteLine($"{randNumb} - > {secondDig}");


System.Console.WriteLine("Введите трёхзначное число"); // С числом введённым пользователем
int number = int.Parse(Console.ReadLine()!);
int secondDig = 0;

if (number < 100) System.Console.WriteLine("Ошибка, не выполнены условия задачи");
else if (number > 999) System.Console.WriteLine("Ошибка, не выполнены условия задачи");
else 
{
    secondDig = number / 10 % 10;
    System.Console.WriteLine($"{number} - > {secondDig}");
}
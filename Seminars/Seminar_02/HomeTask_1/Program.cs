// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает
//  вторую цифру этого числа. 456 -> 5, 782 -> 8


// int randNumb = new Random().Next(100, 1000); // С рандомным числом

// int secondDig = randNumb / 10 % 10;

// System.Console.WriteLine($"{randNumb} - > {secondDig}");


int EnterNum (string message)
{
    System.Console.WriteLine(message);
    int result = int.Parse(Console.ReadLine()!);
    return result;
}

// if (number < 100) System.Console.WriteLine("Ошибка, не выполнены условия задачи");
// else if (number > 999) System.Console.WriteLine("Ошибка, не выполнены условия задачи");
// else 
// {
//     secondDig = number / 10 % 10;
//     System.Console.WriteLine($"{number} - > {secondDig}");
// }

int number = EnterNum("Введите трёхзначное число");

if (number < 100 || number > 999) 
{
   System.Console.WriteLine("Ошибка, не выполнены условия задачи");
   return;
}

int secondDig = number / 10 % 10;
System.Console.WriteLine($"{number} - > {secondDig}");
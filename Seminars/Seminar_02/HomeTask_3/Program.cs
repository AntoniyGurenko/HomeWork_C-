// **Задача 15:**

// Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
// и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

System.Console.WriteLine("Введите число дня недели, чтобы узнать выходной это или нет");
int number = int.Parse(Console.ReadLine()!);

switch (number)
{
    case 1: System.Console.WriteLine($"{number} -> нет");
    break;
    case 2: System.Console.WriteLine($"{number} -> нет");
    break;
    case 3: System.Console.WriteLine($"{number} -> нет");
    break;
    case 4: System.Console.WriteLine($"{number} -> нет");
    break;
    case 5: System.Console.WriteLine($"{number} -> нет");
    break;
    case 6: System.Console.WriteLine($"{number} -> да");
    break;
    case 7: System.Console.WriteLine($"{number} -> да");
    break;
    default:System.Console.WriteLine("Такого дня недели нет");
    break;
}
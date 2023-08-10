// **Задача 13:**

// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6

// System.Console.WriteLine("Введите число");

// int number = int.Parse(Console.ReadLine()!);

// if (number / 100 == 0)
// {
//     System.Console.WriteLine("У числа нет третьей цифры");
// }
// else
// {
//     while (number / 1000 != 0)
//     {
//         number = number / 10;
//     }

//     number = number % 10;
//     System.Console.WriteLine();
//     Console.WriteLine($"Третье число - {number}");
// }

int EnterNum (string message)
{
    Console.WriteLine(message);
    int result = int.Parse(Console.ReadLine()!);
    return result;
}

int GetThirdRank(int number)
{
    while (number > 999)
    {
        number /= 10;
    }
    return number % 10;
}

bool ValidateNumber (int number)
{
    if (number < 100)
    {
        Console.WriteLine("Третьей цифры нет");
        return false;
    }
    return true;
}


int number = EnterNum("Введите число");
if (ValidateNumber(number)) Console.WriteLine(GetThirdRank(number));

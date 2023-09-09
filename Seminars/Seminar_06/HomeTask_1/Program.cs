// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int InputNum(string message)
{
    System.Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

int CountingNumsGreatZero(int amntNums)
{
    int count = 0;
    int num;

    for (int i = 0; i < amntNums; i++)
    {
        num = InputNum("Введите число: ");
        if(num > 0) count++;
    }
    return count;
}


int amountNumbers = InputNum("Введите количество вводимых чисел: ");
System.Console.WriteLine($"Количество цифр больше 0 -> {CountingNumsGreatZero(amountNumbers)}");






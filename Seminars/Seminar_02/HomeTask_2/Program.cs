System.Console.WriteLine("Введите число");

int number = int.Parse(Console.ReadLine()!);

if (number / 100 == 0)
{
    System.Console.WriteLine("У числа нет третьей цифры");
}
else
{
    while (number / 1000 != 0)
    {
        number = number / 10;
    }

    number = number % 10;
    System.Console.WriteLine();
    Console.WriteLine($"Третье число - {number}");
}


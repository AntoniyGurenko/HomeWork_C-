// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29


int InputNum(string text)
{
    Console.WriteLine(text);
    return int.Parse(Console.ReadLine()!);
}



bool IsNotNaturalNums(int num1, int num2)
{
    return num1 < 0 || num2 < 0; // я считаю, что 0 это натуральное число. В математике нет консенсуса, на сколька я понял.
}

void Explanation(string text)
{
    System.Console.WriteLine();
    System.Console.WriteLine(text);
    System.Console.WriteLine();
}

int Ackermann(int m, int n)
{
    if (m == 0)
        return n + 1;
    else if (m > 0 & n == 0)
        return Ackermann(m - 1, 1);
    else
        return Ackermann(m - 1, Ackermann(m, n - 1));

}

string DangerStackOverflow(string letter)
{
    System.Console.WriteLine();
    System.Console.WriteLine($"Внимание! Может произойти перерполнение стека! Рекомендую перезаписать значение {letter}:");
    System.Console.WriteLine();
    return letter;
}




int numberM = InputNum("Введите натуральное число M");
int numberN = InputNum("Введите натуральное число N");
while (IsNotNaturalNums(numberM, numberN))
{
    Explanation("К натуральным числам не относятся отрицательные числа. Введите положительные числа: ");
    numberM = InputNum("Введите натуральное число M");
    numberN = InputNum("Введите натуральное число N");
}
if (numberM > 4)
{
    string letter = DangerStackOverflow("M");
    numberM = InputNum($"Введите натуральное число {letter}");
}
if (numberM == 4 & numberN > 0)
{
    string letter = DangerStackOverflow("N");
    numberN = InputNum($"Введите натуральное число {letter}");
}

if (numberN > 5)
{
    string letter = DangerStackOverflow("N");
    numberN = InputNum($"Введите натуральное число {letter}");
}

System.Console.WriteLine();
System.Console.WriteLine($" A({numberM}, {numberN}) -> {Ackermann(numberM, numberN)}");

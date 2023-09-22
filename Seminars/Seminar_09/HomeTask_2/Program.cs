// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int InputNum(string text)
{
    Console.WriteLine(text);
    return int.Parse(Console.ReadLine()!);
}


bool FirstGreaterSecond(int m, int n)
{
    return m > n;
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

int SumNumsInRange(int m, int n)
{
    if (FirstGreaterSecond(m, n))
    {
        int temp = m;
        m = n;
        n = temp;
    }

    int index = m - 1;
    int res = 0;
    while (index < n)
    {
        res += m;
        m++;
        index++;
    }
    return res;
}



int numberM = InputNum("Введите натуральное число M");
int numberN = InputNum("Введите натуральное число N");
while (IsNotNaturalNums(numberM, numberN))
{
    Explanation("К натуральным числам не относятся отрицательные числа. Введите положительные числа: ");
    numberM = InputNum("Введите натуральное число M");
    numberN = InputNum("Введите натуральное число N");
}
System.Console.WriteLine();

System.Console.WriteLine($"Сумма натуральных чисел в промежутке от {numberM} до {numberN} = {SumNumsInRange(numberM, numberN)}");
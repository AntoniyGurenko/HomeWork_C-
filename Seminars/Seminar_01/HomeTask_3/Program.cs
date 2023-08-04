//Задача 6. Напишите программу, которая на вход принимает число и выдаёт, 
//является ли это число чётным (делится ли оно на 2 без остатка).

Console.WriteLine("Введите число:");
int number = int.Parse(Console.ReadLine()!);
bool even = true;

if (number % 2 == 0)
{
    even = true;
}
else
{
    even = false;
}

if (even == true)
{
    Console.WriteLine($"Число {number} является чётным");
}
else
{
    Console.WriteLine($"Число {number} является не чётным");
}
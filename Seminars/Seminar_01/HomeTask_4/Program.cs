﻿//Задача 8. Напишите программу, которая на вход принимает число N, 
//а на выход показывает все чётные числа от 1 до N.

Console.WriteLine("Введите число");
int number = int.Parse(Console.ReadLine()!);
int count = 1;

while (count <= number)
{
    if (count % 2 == 0)
    {
        Console.Write(count);
        if (count < number)
        {
            Console.Write(", ");
        }
    }
    count ++;
}   

// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран. 
// Решили что пользователь задаёт сам количество элементов в массиве
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]
int InputNum( string message) 
{
    System.Console.WriteLine(message);
    return int.Parse(Console.ReadLine()!);
}

string PrintArray (int[] col)
{
	string resArr = "[";
    for (int i = 0; i < col.Length; i++)
    {
        resArr += $"{col[i]}";
        if (i != col.Length - 1)
        {
            resArr += ", ";
        }
    }
    return resArr += "]";
}

void ArraySetting(int[] arr, int length)
{
    string res = " ";
    for (int i = 0; i < length; i++)
    {
        arr[i] = InputNum("Введите элемент массива");

        res += $"{arr[i]}";
        if (i != length - 1)
        {
            res += ", ";
        }
    }
    Console.Write($"{res}");
}

int length = InputNum("Введите количество элементов в массиве");
int[] array = new int[length];

System.Console.WriteLine();
ArraySetting(array, length);
System.Console.WriteLine($" -> {PrintArray(array)}");

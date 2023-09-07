// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2


int[] CreateArray(int size)
{
    return new int[size];
}

void FillArray (int[] collection, int minV, int maxV)
{
    Random rnd = new Random();
    for (int i = 0; i < collection.Length; i++)
        collection[i] = rnd.Next(minV, maxV + 1);
}

void PrintArray (int[] col)
{
    Console.Write("[");
    for (int i = 0; i < col.Length; i++)
    {
        if(i != col.Length - 1)
            Console.Write($"{col[i]}, ");
        else
            Console.Write($"{col[i]}]");
    }
    // System.Console.WriteLine();
}

int AdderAmountEvenNumbers(int[] arr)
{
    int count = 0;
    for ( int i = 0; i < arr.Length; i++)
        if(arr[i] % 2 == 0)
            count ++;
    return count;
}


int[] array = CreateArray(10);

FillArray(array, 100, 999);

PrintArray(array);
System.Console.WriteLine($" количество чётных чисел равно -> {AdderAmountEvenNumbers(array)}");
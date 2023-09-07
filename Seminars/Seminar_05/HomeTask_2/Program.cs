// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

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

int AdderNumsOnOddPos(int[] arr)
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
        if (i % 2 == 1)
            sum += arr[i];
    return sum;
}


int[] array = CreateArray(10);

FillArray(array, 0, 50);

PrintArray(array);
System.Console.WriteLine($" сумма чисел на нечётных позициях равна -> {AdderNumsOnOddPos(array)}");
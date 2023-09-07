// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

double[] CreateArray(int size)
{
    return new double[size];
}

void FillArray (double[] collection, int minV, int maxV)
{
    Random rnd = new Random();
    for (int i = 0; i < collection.Length; i++)
        collection[i] = Math.Round(rnd.NextDouble() + rnd.Next(minV, maxV + 1), 2);
}

void PrintArray (double[] col)
{
    Console.Write("[");
    for (int i = 0; i < col.Length; i++)
        Console.Write($"{col[i]}  ");
    Console.Write("]");
}

double Max(double arg1, double arg2, double arg3)
{
    double result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}

double FindDiffMaxAndMinDig(double[] arr)
{
    
    // double diff = 0;
    // double max = arr[0];
    // double min = arr[0];
    // double maxSubTotal;
    // double minSubTotal;
    // int i = 0;

    // while (i < arr.Length)
    // {
    //     maxSubTotal = arr[i];
    //     minSubTotal = arr[i];
    //     if(arr[i + 1] > maxSubTotal) maxSubTotal = arr[i + 1];
    //     if(arr[i + 2] > maxSubTotal) maxSubTotal = arr[i + 2];
    //     if(arr[i + 1] < minSubTotal) minSubTotal = arr[i + 1];
    //     if(arr[i + 2] < minSubTotal) minSubTotal = arr[i + 2];

    //     if(maxSubTotal > max) max = maxSubTotal;
    //     if(minSubTotal < min) min = minSubTotal;

    //     if(i + 6 > arr.Length)
    //     {
    //         maxSubTotal = arr[i + 3];
    //         minSubTotal = arr[i + 3];

    //         // if(arr.Length - i == 4)
    //         // {
    //         //     if(maxSubTotal > max) max = maxSubTotal;
    //         //     if(minSubTotal < min) min = minSubTotal;
    //         // }
    //         if(arr.Length - i == 5)
    //         {
    //             if(arr[i + 4] > maxSubTotal) maxSubTotal = arr[i + 4];
    //             if(arr[i + 4] < minSubTotal) minSubTotal = arr[i + 4];
    //         }
    //         if(arr.Length - i == 6)
    //         {
    //             if(arr[i + 4] > maxSubTotal) maxSubTotal = arr[i + 4];
    //             if(arr[i + 5] > maxSubTotal) maxSubTotal = arr[i + 5];
    //             if(arr[i + 4] < minSubTotal) minSubTotal = arr[i + 4];
    //             if(arr[i + 5] < minSubTotal) minSubTotal = arr[i + 5];
    //         }

    //         if(maxSubTotal > max) max = maxSubTotal;
    //         if(minSubTotal < min) min = minSubTotal;
    //     }

    //     i += 3; 
    // }

    // diff = max - min;

}


double[] array = CreateArray(10);

FillArray(array, 0, 100);

PrintArray(array);
// System.Console.WriteLine($" разница между большим{} и меньшим{} равна -> {FindDiffMaxAndMinDig(array)}");

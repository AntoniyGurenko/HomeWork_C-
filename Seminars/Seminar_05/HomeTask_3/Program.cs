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
        collection[i] = Math.Round(rnd.NextDouble() + rnd.Next(minV, maxV), 2);
}

string PrintArray (double[] col)
{
    string res = "[";
    for (int i = 0; i < col.Length; i++)
    {
        if(i != col.Length - 1)
            res += $"{col[i]}  ";
        else
        {
            res += $"{col[i]}]";
        }
    }
    return res;
}

double FindMaxDigit(double[] arr)
{
    double res = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i] > res) res = arr[i];
    }
    return res;
}

double FindMinDigit(double[] arr)
{
    double res = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i] < res) res = arr[i];
    }
    return res;
}

double FindDiffMaxAndMinDig(double theMax, double theMin)
{
    return Math.Round(theMax - theMin, 2);
}


double[] array = CreateArray(10);
FillArray(array, 0, 100);

double max = FindMaxDigit(array);
double min = FindMinDigit(array);


System.Console.WriteLine($"{PrintArray(array)} разница между большим {max} и меньшим {min} равна -> {FindDiffMaxAndMinDig(max, min)}");

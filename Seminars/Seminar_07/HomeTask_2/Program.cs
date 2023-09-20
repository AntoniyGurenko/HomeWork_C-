// Внутри класса Answer напишите методы CreateIncreasingMatrix, PrintArray, PrintListAvr и FindAverageInColumns.

// Метод CreateIncreasingMatrix должен создавать матрицу заданной размерности, с каждым новым элементом увеличивающимся на опрделенное число. Метод принимает на вход три числа (n - количество строк матрицы, m - количество столбцов матрицы, k - число, на которое увеличивается каждый новый элемент) и возвращает матрицу, удовлетворяющую этим условиям.

// Метод PrintArray должен выводить на экран сгенерированную методом CreateIncreasingMatrix матрицу.

// Метод FindAverageInColumns принимает целочисленную матрицу типа int[,] и возвращает одномерный массив типа double. Этот метод вычисляет среднее значение чисел в каждом столбце матрицы и сохраняет результаты в виде списка.

// Метод PrintListAvr принимает одномерный массив, возвращенный методом FindAverageInColumns и выводит этот список на экран в формате "The averages in columns are: x.x0 x.x0 x.x0 ...", где x.x0 - это значения средних значений столбцов, округленные до двух знаков после запятой, разделенные знаком табуляции.

// Пример


// n = 3;
// m = 4;
// k = 2;

// int[,] result = CreateIncreasingMatrix(n, m, k);
// PrintArray(result);
// PrintListAvr(FindAverageInColumns(result));

/*
1   3   5   7   
9   11  13  15  
17  19  21  23  
The averages in columns are: 
9.00    11.00   13.00   15.00
*/



int[,] CreateIncreasingMatrix(int n, int m, int k)
{
    int[,] array = new int[n, m];
    int temp = 1 - k;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = temp + k;
            temp = array[i, j];
        }
    }
    return array;
}

void PrintArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]}" + "\t");
        }
        Console.WriteLine();
    }
}



double[] FindAverageInColumns(int[,] matrix)
{
    double[] res = new double[matrix.GetLength(1)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            res[j] += matrix[i, j];
        }
    }
    for (int i = 0; i < res.Length; i++)
    {
        res[i] = res[i] / matrix.GetLength(0);
    }
    return res;
}

void PrintListAvr(double[] list)
{
    double temp = 0;
    Console.WriteLine("The averages in columns are: ");
    for (int i = 0; i < list.Length; i++)
    {
        temp = Math.Round((list[i] - Math.Truncate(list[i])) * 10, 2);
        if (temp - Math.Truncate(temp) != 0)
        {
            temp *= 10;
            Console.Write($"{Math.Truncate(list[i])}.{temp}" + "\t");
        }
        else
            Console.Write($"{Math.Truncate(list[i])}.{temp}0" + "\t");
    }
    System.Console.WriteLine();
    // temp = Math.Round(((23.30 - Math.Truncate(23.30)) * 10), 2);
    // if(temp - Math.Truncate(temp) != 0)
    // {
    //     temp *= 10;
    //     Console.Write($"{23}.{temp}" + "\t");
    // }
    // Console.WriteLine(temp);

}
// Вот такой вариант в автотесте:
// static void PrintListAvr (double [] list)
// {
//     Console.WriteLine("The averages in columns are: ");
//     foreach (double el in list)
//     {
//         Console.Write($"{el:f2}"+"\t");

//     }
//     Console.WriteLine();
// }

int n = new Random().Next(1,15);
int m = new Random().Next(1,15);
int k = new Random().Next(1,10);

int[,] array = CreateIncreasingMatrix(n, m, k);

PrintArray(array);

PrintListAvr(FindAverageInColumns(array));
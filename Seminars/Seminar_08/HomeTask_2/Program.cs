// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и 
// выдаёт номер строки с наименьшей суммой элементов: 1 строка

int InputNum(string msg)
{
    System.Console.Write(msg);
    return int.Parse(Console.ReadLine()!);
}

int[,] Create2DArray(int rws, int colms)
{
    return new int[rws, colms];
}

void Fill2DArray(int[,] collection, int minV, int maxV)
{
    Random rnd = new Random();
    for (int i = 0; i < collection.GetLength(0); i++) // цикл по строкам
        for (int j = 0; j < collection.GetLength(1); j++) // цикл по столбцам
            collection[i, j] = rnd.Next(minV, maxV + 1);

}

void Print2DArray(int[,] col)
{
    for (int i = 0; i < col.GetLength(0); i++)
    {
        for (int j = 0; j < col.GetLength(1); j++)
            Console.Write(col[i, j] + "\t");
        System.Console.WriteLine();
    }
}


int FindRowSmallestSumElem(int[,] arr)
{
    int[] tempArr = new int[arr.GetLength(0)];
    int indexRow = 1;
    int sumRow = 0;
    int minSum = 0;
    for (int i = 0; i < arr.GetLength(1); i++)
        minSum += arr[0, i];
    for (int i = 1; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
            sumRow += arr[i, j];
        if (sumRow < minSum)
        {
            indexRow = i + 1;    /* на сколько я понял задачу, то просят не индекс 
                                    вернуть, а понятный для пользователя номер строки
                                    (я посчитал минимальный в примерах) */
            minSum = sumRow;
        }
        sumRow = 0;
    }
    return indexRow;
}

int rows = InputNum("Введите количество строк прямоугольной матрицы: ");
int columns = InputNum("Введите количество столбцов прямоугольной матрицы: ");
if (rows == columns)
    System.Console.WriteLine("Матрица должна быть прямоугольной");
else
{
    int[,] array = Create2DArray(rows, columns);
    Fill2DArray(array, 1, 2);
    Print2DArray(array);
    System.Console.WriteLine();
    System.Console.WriteLine($"В какой строке наименьшая сумма чисел? -> в {FindRowSmallestSumElem(array)} строке");
}


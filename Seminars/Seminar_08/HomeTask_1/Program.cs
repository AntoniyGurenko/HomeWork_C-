// Задача 54: Задайте двумерный массив. Напишите программу, 
// которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2


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


void DescendingOrderRows(int[,] arr)
{
    int maxPosition = 0;
    int temp = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1) - 1; j++)
        {
            maxPosition = j;
            for (int k = j + 1; k < arr.GetLength(1); k++)
            {
                if(arr[i, k] > arr[i, maxPosition]) 
                    maxPosition = k;
            }
            temp = arr[i, j];
            arr[i, j] = arr[i, maxPosition];
            arr[i, maxPosition] = temp;
        }
    }
}



int[,] array = Create2DArray(5, 5);
Fill2DArray(array, 1, 10);
Print2DArray(array);
System.Console.WriteLine();
DescendingOrderRows(array);
Print2DArray(array);



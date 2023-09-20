// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение 
// двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

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

int[] TransArr2DInLineForProdMatr(int[,] arr) // функция создаёт одномерный массив в который числа записываются столбцами.
{
    int[] res = new int[arr.Length];
    int index = 0;
    for (int j = 0; j < arr.GetLength(1); j++) // столбец
    {
        for (int i = 0; i < arr.GetLength(0); i++) // строка
        {
            res[index] = arr[i, j];
            index++;
        }

    }
    return res;
}



int[,] ProductOfTwoMatr(int[,] matrA, int[,] matrB)
{
    int[,] res = new int[matrA.GetLength(0), matrB.GetLength(1)];
    int[] changedB = TransArr2DInLineForProdMatr(matrB);
    int temp = 0;
    int index = 0;
    for (int i = 0; i < res.GetLength(0); i++)
    {
        for (int j = 0; j < res.GetLength(1); j++)
        {
            for (int k = 0; k < matrA.GetLength(1); k++)
            {
                temp = matrA[i, k] * changedB[index];
                res[i, j] += temp;

                if (index < changedB.Length - 1)
                    index++;
                else
                    index = 0;
            }
        }
    }
    return res;
}

bool ColsAMatchRowsB(int[,] matrA, int[,] matrB)
{
    return matrA.GetLength(1) == matrB.GetLength(0);
}



int[,] matrixA = Create2DArray(4, 5);
int[,] matrixB = Create2DArray(5, 7);
Fill2DArray(matrixA, 1, 10);
Fill2DArray(matrixB, 1, 10);

System.Console.WriteLine("Матрица A: " );
Print2DArray(matrixA);
System.Console.WriteLine();
System.Console.WriteLine("Матрица B: " );
Print2DArray(matrixB);
System.Console.WriteLine();



if (ColsAMatchRowsB(matrixA, matrixB))
{
    int[,] result = ProductOfTwoMatr(matrixA, matrixB);
    Print2DArray(result);
}
else 
{
    System.Console.WriteLine(" В матрицах не совпадают количество столбцов A и количество строк B");
}



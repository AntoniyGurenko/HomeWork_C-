// void PrintArray(int[,] matrix)
// {
//     // Введите свое решение ниже
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//             Console.Write(matrix[i, j] + "\t");
//         System.Console.WriteLine();
//     }

// }

// int[,] CreateIncreasingMatrix(int n, int m, int k)
// {
//     // Введите свое решение ниже
//     int[,] array = new int[n, m];
//     array[0, 0] = 1;
//     int temp = array[0, 0];
//     for (int i = 0; i < array.GetLength(0); i++)
//         for (int j = 1; j < array.GetLength(1); j++)
//         {
//             array[i, j] = temp + k;
//             temp = array[i, j];
//         }
//     return array;


// }

// int[] FindNumberByPosition(int[,] matrix, int rowPosition, int columnPosition)
// {
//     // Введите свое решение ниже
//     int[] array;
//     if (rowPosition > matrix.GetLength(0) || columnPosition > matrix.GetLength(1))
//         array = new int[0];
//     else
//     {
//         array = new int[2];
//         array[0] = matrix[rowPosition - 1, columnPosition - 1];
//     }
//     return array;
// }

// void PrintCheckIfError(int[] results, int X, int Y)
// {
//     // Введите свое решение ниже
//     if (results != null)
//         Console.WriteLine($"The number in [{X}, {Y}] is {results[0]}");
//     else
//         Console.WriteLine("There is no such index");
// }

// int n = 4;
// int m = 5;
// int k = 3;
// int x = 2;
// int y = 2;

// int[,] array = CreateIncreasingMatrix(n, m, k);

// PrintArray(array);

// PrintCheckIfError(FindNumberByPosition(array, y, x), x, y);

using System;

public class Answer
{
    public static void PrintArray(int[,] matrix)
    {
        // Введите свое решение ниже
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
                Console.Write(matrix[i, j] + "\t");
            System.Console.WriteLine();
        }

    }

    public static int[,] CreateIncreasingMatrix(int n, int m, int k)
    {
        // Введите свое решение ниже
        int[,] array = new int[n, m];
        int temp = 1 - k;
        for (int i = 0; i < array.GetLength(0); i++)
            for (int j = 0; j < array.GetLength(1); j++)
            {
                array[i, j] = temp + k;
                temp = array[i, j];
            }
        return array;


    }

    public static int[] FindNumberByPosition(int[,] matrix, int rowPosition, int columnPosition)
    {
        // Введите свое решение ниже
        int[] array = new int[2];
        if (rowPosition > matrix.GetLength(0) || columnPosition > matrix.GetLength(1))
            array[1] = 1;
        else
        {
            array = new int[2];
            array[0] = matrix[rowPosition - 1, columnPosition - 1];
        }
        return array;
    }

    public static void PrintCheckIfError(int[] results, int X, int Y)
    {
        // Введите свое решение ниже
        if (results[1] == 0)
            Console.WriteLine($"The number in [{X}, {Y}] is {results[0]}");
        else
            Console.WriteLine("There is no such index");


    }


    // Не удаляйте и не меняйте метод Main! 
    public static void Main(string[] args)
    {
        int n, m, k, x, y;

        if (args.Length >= 5)
        {
            n = int.Parse(args[0]);
            m = int.Parse(args[1]);
            k = int.Parse(args[2]);
            x = int.Parse(args[3]);
            y = int.Parse(args[4]);
        }
        else
        {
            // Здесь вы можете поменять значения для отправки кода на Выполнение
            n = 3;
            m = 4;
            k = 2;
            x = 8;
            y = 3;

        }

        // Не удаляйте строки ниже
        int[,] result = CreateIncreasingMatrix(n, m, k);
        PrintArray(result);
        PrintCheckIfError(FindNumberByPosition(result, x, y), x, y);
    }
}
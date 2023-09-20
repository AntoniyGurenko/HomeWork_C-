// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)



int[,,] Create3DArray(int pages, int rws, int colms) 
/* честно я не понимаю позиционирование массива в примере, я решил сделать по страницам 

например какая из цифр обозначает ось Z?
Если 3-я то мне понятно как он расположен, но не понятно почему 3-я
Если 1-я то тогда большие вопросы к расположению и то как это вывести на экран,
но с другой стороны в этом случае цифра стоит верно*/
{
    return new int[pages, rws, colms];               

}


int[] CreateArrayTwoDigNums()
{
    int[] res = new int[90];
    int num = 10;
    for (int i = 0; i < res.Length; i++)
    {
        res[i] = num;
        num++;
    }
    return res;
}

void MixingArray(int[] arr)
{
    int temp = 0;
    Random rnd = new Random();
    int randIndex = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        randIndex = rnd.Next(1, arr.Length);
        temp = arr[i];
        arr[i] = arr[randIndex];
        arr[randIndex] = temp;
    }
}


void Fill3DArrayDiffTwoDigNums(int[,,] collection)
{
    int[] arrTwoDig = CreateArrayTwoDigNums();
    MixingArray(arrTwoDig);
    int index = 0;
    for (int i = 0; i < collection.GetLength(0); i++)
    {
        for (int j = 0; j < collection.GetLength(1); j++)
        {
            for (int k = 0; k < collection.GetLength(2); k++)
            {
                collection[i, j, k] = arrTwoDig[index];
                if(index < arrTwoDig.Length - 1)
                    index++;
                else
                {
                    MixingArray(arrTwoDig);
                    index = 0;
                }
                    
            }
        }
    }
}

void Print3DArray(int[,,] col)
{
    for (int i = 0; i < col.GetLength(0); i++)
    {
        System.Console.WriteLine($"Page N{i + 1}");
        for (int j = 0; j < col.GetLength(1); j++)
        {
            for (int k = 0; k < col.GetLength(2); k++)
            {
                Console.Write($"{col[i, j, k]}({i}, {j}, {k})" + "\t");
            }
            System.Console.WriteLine();
        }
        System.Console.WriteLine();
    }

}





int[,,] array = Create3DArray(2, 2, 2);
Fill3DArrayDiffTwoDigNums(array);
Print3DArray(array);
System.Console.WriteLine();

// Внутри класса Answer напишите метод ShowCube, который принимает на вход число (N) и 
// выводит таблицу кубов чисел от 1 до N (включительно) каждое на новой строке.

int InputNum( string message) 
{
    System.Console.WriteLine(message);
    return int.Parse(Console.ReadLine()!);
}

void ShowCube(int N)
{
    int count = 1;
    while (count <= N)
    {
        Console.WriteLine($"{Math.Pow(count,3)}");
        count ++;
    }
}

int number = InputNum("Введите число");
ShowCube(number);
// Внутри класса Answer напишите метод IsPalindrome, который принимает на вход пятизначное число number и проверяет, является ли оно палиндромом.

// Метод должен проверить является ли число пятизначным, в противном случае - вывести Число не пятизначное и False в следующей строке.

// Для остальных чисел вернуть True или False.


// ТУТ ДВА ВАРИАНТА РЕШЕНИЯ ОДНО МОЁ ДРУГОЕ ПОД ВЛИЯНИЕМ УЧИТЕЛЯ - БОЛЕЕ ЭЛЕГАНТНОЕ

int InputNum( string message) 
{
    System.Console.WriteLine(message);
    return int.Parse(Console.ReadLine()!);
}

// bool IsPalindrome(int number)
// {
//     int firstDigit = number / 10000;
//     int secondDigit = number / 1000 % 10;
//     int thirdDigit = number / 100 % 10;
//     int fourthDigit = number / 10 % 10;
//     int fifthDigit = number % 10;

//     if (firstDigit == fifthDigit && secondDigit == fourthDigit)
//     {
//         return true;
//     }
//     else
//     {
//         return false;
//     }
// }

// int num = InputNum("Введите пятизначное число");

// if (num > 99999 || num < 10000)
// {
//     Console.WriteLine($"{num} -> Число не пятизначиное");
//     Console.WriteLine("False");
// }
// else
// {
//     if (IsPalindrome(num) == true)
//     {
//         Console.WriteLine($"{num} -> True");
//     }   
//     else 
//     {
//         Console.WriteLine($"{num} -> False");
//     }
// }

bool IsFiveDigit(int num)
{
	return num > 9999 && num < 100000;
}
bool IsPalindrome(int number)
{
    //int firstDigit = number / 10000;
    //int secondDigit = number / 1000 % 10;
    //int fourthDigit = number / 10 % 10;
    //int fifthDigit = number % 10;

    //if (number / 10000 == number % 10 && number / 1000 % 10 == number / 10 % 10)
    //{
        //return true;
    //}
    //else
    //{
        //return false;
    //}
		return number / 10000 == number % 10 && number / 1000 % 10 == number / 10 % 10;
}

int num = InputNum("Введите пятизначное число");
if (IsFiveDigit(num))
{
	// bool res = IsPalindrome(num);
	if (IsPalindrome(num))
	{
		Console.WriteLine($"{num} -> True");
	}
	else
	{
		Console.WriteLine($"{num} -> False");
	}
}
else
{
	Console.WriteLine($"{num} -> Число не пятизначиное");
	Console.WriteLine("False");
}
//Задача 63: Задайте число N. Напишите программу,
//которая выведет все натуральные числа в промежудке от 1 до N. 
Console.Clear();
//Вариант 1.

// System.Console.WriteLine("Enter N: ");

// int n = int.Parse(Console.ReadLine());

// System.Console.WriteLine(PrintNumbers(1,n));;

// string PrintNumbers(int start, int end)
// {
//     if (start == end) return start.ToString();
//     return (start + " " + PrintNumbers(start + 1, end));
// }
//Вариант 2.

// string NumbersRec (int a, int b)
// {
//     if (a <= b) return $"{a} " + NumbersRec (a + 1, b);
//     else return string.Empty; //возврат пустой строки в случае не выполнения условия (а <= b)
// }

// // System.Console.WriteLine(NumbersFor(1, 10)); // 1 2 3 4 5 6 7 8 9 10
// System.Console.WriteLine("Введите число:");
// int b = Convert.ToInt32(Console.ReadLine());
// int a = 1;
// System.Console.WriteLine($"N = {b} -> {NumbersRec(a, b)}"); // 1 2 3 4 5 6 7 8 9 10

//Задача 65: Задайте значения M и N. Напишите программу,
//которая выведет все натуральные числа в промежудке от M до N. 


// System.Console.WriteLine("Enter M: ");
// int m = int.Parse(Console.ReadLine());

// System.Console.WriteLine("Enter N: ");
// int n = int.Parse(Console.ReadLine());

// System.Console.WriteLine(PrintNumbers(m,n));;

// string PrintNumbers(int start, int end)
// {
//     if (start == end) return start.ToString();
//     return (start + " " + PrintNumbers(start + 1, end));
// }

//Задача 67: Напишите программу, которая будет принимать на вход число и
// возвращать сумму его цифр.

// Console.Write("Введите число: ");
// int start = int.Parse(Console.ReadLine());
// int sum = 0;
// System.Console.WriteLine($"{start} -> {AmountNumbers(start, sum)}");

// string AmountNumbers(int start, int sum)
// {
//     sum += start % 10;
//     if (start == 0) return sum.ToString();
//     return (AmountNumbers(start / 10, sum));
// }

//Задача 69: Напишите программу, которая на вход принимает два числа А и В, и 
//возводит число А в степень В с помощью рекурсии.

//Вариант 1:
// Console.Write("Введите число: ");
// int num = int.Parse(Console.ReadLine());
// Console.Write("Введите степень числа: ");
// int expo = int.Parse(Console.ReadLine());
// Console.Write($"Число {num} в степени {expo} = {Exponentiation (num, expo)} ");

// int Exponentiation (int num, int expo)
// {
//     if (expo == 0) return 1;
//     return num * Exponentiation (num, expo - 1);
// }

//Вариант 2 без (ограничения по возведению в степень "0"):

Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());
Console.Write("Введите степень числа: ");
int expo = int.Parse(Console.ReadLine());

Console.Write($"Число {num} в степени {expo} = {Exponentiation (num, expo)} ");

int Exponentiation (int num, int expo)
{
    return (expo == 1) ? num: num * Exponentiation (num, expo - 1);
}
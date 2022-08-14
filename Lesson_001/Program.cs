// // 1. Напишите программу, которая на вход принимает число и выдаёт его квадрат (число умноженное само на себя)

// Console.Clear();

// Console.Write("Введите число: ");

// int number = Convert.ToInt32(Console.ReadLine());
// //int sqrt = number * number;
// // number *= number;
// int sqrt1 = Convert.ToInt32(Math.Pow(number, 2));

// Console.Write("Число в квадрате: " + sqrt1);

// 2. Напишите программу, которая на вход принимает два числа и проверяет является ли первое число квадратом второго числа.

// Console.Clear();
// Console.Write("Введите первое число: ");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите второе число: ");
// int num2 = Convert.ToInt32(Console.ReadLine());
// if (num1 == num2 * num2)
//     Console.Write("Первое число является квадратом второго числа");
// else
//     Console.Write("Первое число не является квадратом второго числа");

// 3. Напишите программу, которая будет выдавать название дня недели по заданному номеру.

Console.Clear();

Console.Write("Напишите номер дня недели: ");
int day = Convert.ToInt32(Console.ReadLine());

if (day < 1 || day > 7)
{
    Console.Write("Дня недели с таким номером не существует");
}

else
{
    if ( day == 1)
    {
        Console.Write("Понедельник");
    }
    if ( day == 2)
    {
        Console.Write("Вторник");
    }
    if ( day == 3)
    {
        Console.Write("Среда");
    }
    if ( day == 4)
    {
        Console.Write("Четверг");
    }
    if ( day == 5)
    {
        Console.Write("Пятница");
    }
    if ( day == 6)
    {
        Console.Write("Суббота");
    }
    if ( day == 7)
    {
        Console.Write("Воскресенье");
    }
}

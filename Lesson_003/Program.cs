//Задача 17. Напишите программу, которая принимает на вход координаты точки (X и Y), причём X=/0 и Y=/0 
// и выдаёт номер чеверти плоскости, в которой находится эта точка.

Console.Clear();

// Console.Write ("Введите координаты точки Х не равные 0: ");
// int x = Convert.ToInt32 (Console.ReadLine());
// Console.Write ("Введите координаты точки Y не равные 0: ");
// int y = Convert.ToInt32(Console.ReadLine());

// // моё решение

// if (x > 0 && y > 0) Console.Write ("Первая четверть");
// if (x < 0 && y > 0) Console.Write ("Вторая четверть");
// if (x < 0 && y < 0) Console.Write ("Третья четверть");
// if (x > 0 && y < 0) Console.Write ("Четвёртая четверть");
// if (x == 0 || y == 0) Console.Write ("Ввели координаты равные 0. Повторите попытку.");

// //решение Александра

// string msg = "";

// switch (x, y)
// {
//     case (>0, >0): msg = "первая четверть"; break;
//     case (<0, >0): msg = "вторая четверть"; break;
//     case (<0, <0): msg = "третья четверть"; break;
//     case (>0, <0): msg = "четвёртая четверть"; break;
//     default: msg = "Ввели координаты раные 0"; break;
// }
// Console.WriteLine (msg);

// решение через функцию(метод)

// void printQuarter (int a, int b)
// {
// if (a > 0 && b > 0) Console.Write ("Первая четверть"); 
// if (a < 0 && b > 0) Console.Write ("Вторая четверть");
// if (a < 0 && b < 0) Console.Write ("Третья четверть");
// if (a > 0 && b < 0) Console.Write ("Четвёртая четверть");
// if (a == 0 || b == 0) Console.Write ("Ввели координаты равные 0. Повторите попытку.");
// }

// Console.Write ("Введите координаты точки Х не равные 0: ");
// int x = Convert.ToInt32 (Console.ReadLine());
// Console.Write ("Введите координаты точки Y не равные 0: ");
// int y = Convert.ToInt32(Console.ReadLine());
// printQuarter(x, y);

// Задача 18. Напишите программу, которая по заданному номеру четверти,
//показывает диапозон возможных координат точек в этой четверти (х и у).

// Console.Write("Введите номер четверти: ");
// int quarter = int.Parse(Console.ReadLine());

// switch (quarter)
// {
//     case 1 : Console.WriteLine("X > 0 Y > 0"); break;
//     case 2 : Console.WriteLine("X < 0 Y > 0"); break;
//     case 3 : Console.WriteLine("X < 0 Y < 0"); break;
//     case 4 : Console.WriteLine("X > 0 Y < 0"); break;
    
//     default: Console.WriteLine("Введена неправильная четверть"); break;
// }

// Задача 21. Напишите программу, которая принимает на вход координаты
// двух точек и находит расстояние между ними в 2D пространстве.

// Console.Write("Введите Х1:");
// int x1 = int.Parse(Console.ReadLine());
// Console.Write("Введите Y1:");
// int y1 = int.Parse(Console.ReadLine());
// Console.Write("Введите Х2:");
// int x2 = int.Parse(Console.ReadLine());
// Console.Write("Введите Y2:");
// int y2 = int.Parse(Console.ReadLine());

// double d = Math.Sqrt(Math.Pow(x1-x2, 2)) + Math.Pow(y1-y2, 2);

// Console.WriteLine($"d = {d:f3}"); //f3 - округление до 3 числа.

//Задача 22. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.


Console.Write("Введите положительное число: ");
int num =Int16.Parse(Console.ReadLine());

if (num < 0) Console.WriteLine($" Число {num} не является положительным");

int i = 0;

while (i < num)
{
    i++;

    Console.Write( i * i + ", ");
}


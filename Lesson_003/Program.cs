//Напишите программу, которая принимает на вход координаты точки (X и Y), причём X=/0 и Y=/0 
// и выдаёт номер чеверти плоскости, в которой находится эта точка.

Console.Clear();

Console.Write ("Введите координаты точки Х не равные 0: ");
int x = Convert.ToInt32 (Console.ReadLine());

Console.Write ("Введите координаты точки Y не равные 0: ");
int y = Convert.ToInt32(Console.ReadLine());
// // моё решение
// if (x > 0 && y > 0) Console.Write ("Первая четверть");
// if (x < 0 && y > 0) Console.Write ("Вторая четверть");
// if (x < 0 && y < 0) Console.Write ("Третья четверть");
// if (x > 0 && y < 0) Console.Write ("Четвёртая четверть");
// if (x == 0 || y == 0) Console.Write ("Ввели координаты равные 0. Повторите попытку.");

//решение Александра

string msg = "";

switch (x, y)
{
    case (>0, >0): msg = "первая четверть"; break;
    case (<0, >0): msg = "вторая четверть"; break;
    case (<0, <0): msg = "третья четверть"; break;
    case (>0, <0): msg = "четвёртая четверть"; break;
    default: msg = "Ввели координаты раные 0"; break;
}
Console.WriteLine (msg);


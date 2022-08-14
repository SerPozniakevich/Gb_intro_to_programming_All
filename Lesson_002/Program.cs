// Задача 9. Напишите программу, которая выводит случайное число из отрезка [10, 99]
// и показывает наибольшую цифру числа.

Console.Clear();
int num = new Random().Next(10, 99);

Console.WriteLine($"Случайное число отрезка [10, 99] = {num}");

int fig1 = num / 10;
Console.WriteLine($"Первая цифра числа = {fig1}");

int fig2 = num % 10;
Console.WriteLine($"Вторая цифра числа = {fig2}");

int max = fig1;

if (fig1 < fig2) max = fig2;
Console.WriteLine($"Наибольшая цифра = {max}");
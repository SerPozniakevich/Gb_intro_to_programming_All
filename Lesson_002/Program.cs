﻿// Задача 9. Напишите программу, которая выводит случайное число из отрезка [10, 99]
// и показывает наибольшую цифру числа.

// Console.Clear();
// int num = new Random().Next(10, 99);

// Console.WriteLine($"Случайное число отрезка [10, 99] = {num}");

// int fig1 = num / 10;
// Console.WriteLine($"Первая цифра числа = {fig1}");

// int fig2 = num % 10;
// Console.WriteLine($"Вторая цифра числа = {fig2}");

// int max = fig1;

// if (fig1 < fig2) max = fig2;
// Console.WriteLine($"Наибольшая цифра = {max}");

// Задача 11. Напишите программу, которая выводит случайное трёхзначное число 
// и удаляет вторую цифру этого числа.

// Console.Clear();
// int num1 = new Random().Next(100, 999);
// Console.WriteLine($"Число = {num1}");

// int fig1 = num1 / 100;
// int fig2 = num1 % 10;
// Console.WriteLine($"Число без второй цифры = {fig1}{fig2}");

// Задача 12. Напишите программу, которая будет принимать на вход два числа и 
// выводить, является ли второе число кратным первому.
// Если число 2 не кратно числу 1, то программа выводит остаток деления.

Console.Clear();
Console.Write("Введите первое число:");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число:");
int num2 = Convert.ToInt32(Console.ReadLine());

if (num2 % num1  == 0)
{
    Console.Write($"Число {num2} кратно числу {num1}");
}
else
{
    int rem = num2 % num1;
    Console.Write($"Число {num2} не кратно числу {num1}, остаток {rem}");
}



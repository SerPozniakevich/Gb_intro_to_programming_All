﻿// Задача 24. Напишите программу, которая принимает на вход число (А)
// и выдаёт сумму чисел от 1 до А

Console.Clear();

// int GetSumNums(int number); // функция, "GetSumNumbers" - придуманное название.
// {
//     int sum = 0;
//     for (int i = 1; i <= number; i++) // int i -стартовое значение, условие, действие.
//     {
//        sum += i;                   // суммарное сохранение каждого значения при проходе цикла
//     }
//     return sum;                  // вывод итога, после завершения цикла
// }

 
// Console.Write("Введите число: ");
// int num = int.Parse(Console.ReadLine());
// Console.WriteLine($"Сумма цифр от 1 до {num} = {GetSumNums(num)}");


//Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.

// Вариант 1

// Console.Write("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// int ind = 0;

// while (num != 0 )
// {
//     num = num / 10;
//     ind += 1;
// }
// Console.Write($"В числе - {ind} цифр.");

//Вариант 2

Console.Write("Введите число: ");

double N = Convert.ToDouble(Console.ReadLine());

double digits_num = Math.Floor(Math.Log10(N) + 1);
Console.WriteLine("Количество цифр введённом числе - " + digits_num);




//Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.

// Console.Write("Введите число: ");
// int num = int.Parse(Console.ReadLine());
//     int mult = 1; // начинаем с 1, так как при умножении на 0 = 0.
//     for (int i = 1; i <= num; i++) // int i -стартовое значение, условие, действие.
//     {
//        mult *= i;                   //  сохранение произведения каждого значения при проходе цикла
//     }

// Console.WriteLine($"Произведение чисел от 1 до {num} = {mult}");






//Задача 30. Напишите программу, которая выводит массив из 8 элементов, 
//заполненный нулями и единицами в случайном порядке. [1,0,1,1,0,1,0,0]


// int[] array = new int[8];

// Random rnd = new Random();
// Console.Write("Случайный массив из 8 элементов в диапозоне [0, 1] - ");
// for (int i = 0; i < 8; i++)
// {
//     array[i] = rnd.Next(0, 2);
//     Console.Write (array[i] + ",");
// }
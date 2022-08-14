// Задача 9. Напишите программу, которая выводит случайное число из отрезка [10, 99]
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

Console.Clear();
int num1 = new Random().Next(100, 999);
Console.WriteLine($"Число = {num1}");

int fig1 = num1 / 100;
int fig2 = num1 % 10;
Console.WriteLine($"Число без второй цифры = {fig1}{fig2}");

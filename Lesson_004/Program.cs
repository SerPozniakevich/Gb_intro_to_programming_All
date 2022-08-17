// Задача 24. Напишите программу, которая принимает на вход число (А)
// и выдаёт сумму чисел от 1 до А

int GetSumNums(int number); // функция, "GetSumNumbers" - придуманное название.
{
    int sum = 0;
    for (int i = 1; i <= number; i++) // int i -стартовое значение, условие, действие.
    {
       sum += i;                   // суммарное сохранение каждого значения при проходе цикла
    }
    return sum;                  // вывод итога, после завершения цикла
}

Console.Clear();
Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());
Console.WriteLine($"Сумма цифр от 1 до {num} = {GetSumNums(num)}");

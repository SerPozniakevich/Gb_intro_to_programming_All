
Console.Clear();

// // Создание и вывод массива.

// //Функция генерации рандомного массива с N индексом.

// int[] CreateRandomArray(int N, int start, int end) //[]-обозначение создания массива, 
//                                                   //N - длинна массива, start - генерация рандомного числа,
//                                                   // end - диапазон для генерации рандомного числа
// {
//     int[] RandomArray = new int[N]; //int[]-созание пустого массива и определение длинны массива
//     for (int i = 0; i < N; i++)
//     {
//         RandomArray[i] = new Random().Next(start, end + 1);// запись в элемент массива [i] нового числа
//                                                             // из диапазона от start до end+1
//     }
//     return RandomArray;
// }

// //Функция создания массива с вводимыми данными (название RandomArray - просто название)))

// int[] CreateArray()
// {
//     Console.WriteLine("Введите количество элементов массива");//Запрос 
//     int size = Convert.ToInt32(Console.ReadLine());//сохранение в переменную "size"
//     int[] RandomArray = new int[size];//создание массива заданого размера
//     for (int i = 0; i < size; i++)// цикл с запросом введения значений для каждой ячейки по заданному размеру
//     {
//         Console.WriteLine($"Введите {i+1} элемент массива");// "i+1" - чтобы не путать пользователя с нулевым индексом ячейки
//         RandomArray[i] = Convert.ToInt32(Console.ReadLine());
//     }
//     return RandomArray;
// }


// void ShowArray(int[] array)//Выводит массив на экран
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
//     Console.WriteLine();
// }


// Console.WriteLine("Введите количество элементов в массиве");
// int num = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите первое число сучайного диапазона");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите последее число случайного диапазона");
// int max = Convert.ToInt32(Console.ReadLine());

// int[] myRandomArray = CreateRandomArray(num, min, max);
// ShowArray(myRandomArray);
// Console.WriteLine("------------");
// int[] myArray = CreateArray();
// ShowArray(myArray);


//Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9].
// Найдите сумму отрицательных и положительных элементов.
// Например, в массиве [3, 9, -8, 1, 0, -7, 2, -1, 8, -3, -1, 6] 
//сумма положительных чисел равна 29, сумма отрицательных равна -20

// int[] CreatRandomArray(int size, int min, int max)
// {
//     int[] array = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         array[i] = new Random().Next(min, max + 1);
//     }
//     return array;
// }
// void ShowArray(int[] array)  // функция вывода готового результата
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + ", ");
//     }
//     Console.WriteLine();
// }

// int[] myArray = CreatRandomArray(12, -9, 9);
// ShowArray(myArray);

// int sum_poz = 0;
// int sum_neg = 0;
// for (int i = 0; i < myArray.Length; i++)
// {
//     if (myArray[i] > 0)
//         sum_poz +=myArray[i];
//     else
//         sum_neg += myArray[i];
// }

// Console.WriteLine($"Сумма положительных чисел: {sum_poz}. Сумма отрицательных: {sum_neg}");


// Задача 32. Напишите программу замена элементов массива: 
// положительные замените на соответствующие отрицательные, и наоборот.

// int[] CreatRandomArray(int size, int min, int max)
// {
//     int[] array = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         array[i] = new Random().Next(min, max + 1);
//     }
//     return array;
// }
// void ShowArray(int[] array)  // функция вывода готового результата
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + ", ");
//     }
//     Console.WriteLine();
// }

// int[] myArray = CreatRandomArray(12, -9, 9);
// ShowArray(myArray);
// Console.WriteLine("----------------------------------------");


// int i = 0;
// while (i < myArray.Length)
// {
//     myArray[i] = myArray[i]*-1;
//     i++;

// }
// ShowArray(myArray);

//Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
int[] CreatRandomArray(int size, int min, int max)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(min, max + 1);
    }
    return array;
}

void ShowArray(int[] array)  // функция вывода готового результата
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + ", ");
    }
    Console.WriteLine();
}
Console.WriteLine("Введите количество элементов в массиве");
int size = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите первое число сучайного диапазона");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите последее число случайного диапазона");
int max = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число из этого диапазона:");
int find = Convert.ToInt32(Console.ReadLine());
bool flag = false;
int[] array = CreatRandomArray(size, min, max);
ShowArray(array);  // функция вывода готового результата

for (int i = 0; i < size; i++)
{
    if (array[i] == find)
    {
        flag = true;
    }
  
}
if (flag == true)
{
    Console.WriteLine($"Число {find} есть в заданном масиве.");
} 
else Console.WriteLine($"Числа {find} нет в заданном масиве.");

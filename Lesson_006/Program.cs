// Написать программу, которая перевернёт одномерный массив
//(последний элемент будет на первом месте, а первый на последнем и т.д.)

Console.Clear();

// int[] array = GetArray(10, 0, 10);
// Console.WriteLine(String.Join(" ", array));

// int[] reversArray=ReversArray2(array);
// Console.WriteLine(String.Join(" ", reversArray));

// ReversArray1(array);
// Console.WriteLine(String.Join(" ", array));

// int[] GetArray(int size, int minValue, int maxValue) // Функция создания массива
// {
//     int[] res = new int[size];

//     for (int i = 0; i < size; i++)
//     {
//         res[i] = new Random(). Next(minValue, maxValue + 1);
//     }
//     return res;

// }

// void ReversArray1(int[] inArray) //Метод реверса массива при помощи временной переменной
// {
//     for (int i = 0; i < inArray.Length / 2; i++)
//     {
//         int k = inArray[i];
//         inArray[i] = inArray[inArray.Length - 1 -i];
//         inArray[inArray.Length - 1 - i] = k; 
//     }
// }





// int[] ReversArray2(int[] inArray) // метод реверса массива созданием нового и записывания значений в нужном порядке
// {   int[] result = new int [inArray.Length];
//     for (int i = 0; i < inArray.Length; i++)
//     {
//         result[i] = inArray[inArray.Length - 1 - i];
//     }
//     return result;
// }

//40: Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник со сторонами такой длинны.


Console.WriteLine("Введите первое число массива: ");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите первое число массива: ");
int b = int.Parse(Console.ReadLine());
Console.WriteLine("Введите первое число массива: ");
int c = int.Parse(Console.ReadLine());
int [] TriArray = {a, b, c};

Console.WriteLine($"[{String.Join(", ", TriArray)}]");

if(TriArray[0] < TriArray[1] + TriArray[2] && TriArray[1] < TriArray[0] + TriArray[2] && TriArray[0] + TriArray[1] > TriArray[2])
{
    Console.WriteLine($"Треугольник с данными длинами сторон возможен");
}
else Console.WriteLine($"Треугольник с данными длинами сторон невозможен");




//42: Напишите программу, которая будет преобразовывать десятичное в двоичное.






//44: Не используя рекурсию выведите первые N чисел Фибоначчи. Первые два числа: 0 и 1.


//45: Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.
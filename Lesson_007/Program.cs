// int Prompt(string messadge) - функция Prompt берёт в качестве параметра какое-то сообщение
//



// НЕОБХОДИМА ДОРАБОТКА!!!
//Сгенерировать двумерный массив со случайными числами, вывести его на экран,
// оформить в виде функции (пригодьтся в дальнейшем)

int Prompt(string message)
{
    System.Console.Write(message);                    //Вывести сообщение
    int result = Convert.ToInt32(Console.ReadLine()); // Считывает значение
    return result;                                    // Возвращает результат
}


int[,] FillArray(int numLine, int numColumns, int maxRand = 20, int minRand = 0) //Функция заполнения матицы случайными числами, ограничено [0; 20)
{
    int[,] matrix = new int[numLine, numColumns];
    for (int i = 0; i < matrix.GetLength(0); i++)  //Строка
    {
        for (int j = 0; j < matrix.GetLength(1); j++) //Столбец
        {
            matrix[i, j] = new Random().Next(minRand, maxRand); //[0; 20) по умолчанию
        }
    }
    return matrix;
}


void PrintArray(int[,]matrix)                        //функция печати массива
{
    for (int i = 0; i < matrix.GetLength(0); i++)       //Строка
    {
        for (int j = 0; j < matrix.GetLength(1); j++)   //Столбец
        {
            Console.Write($"{matrix[i, j]}\t");     // "\t" - символ обозначает табуляцию
        }
        Console.WriteLine();
    }
}

int numLine = Prompt("Введите количество строк массива ");
int numColumns = Prompt("Введите количество столбцов массива ");
int maxRand = Prompt("Введите верхнюю границу диапазона "); //необязательно
int minRand = Prompt("Введите верхнюю границу диапазона "); //необязательно
int [,] matrix = FillArray(numLine, numColumns, maxRand, minRand); //Диапазон значений можно не у
PrintArray(matrix);


//Задайте двумерный массив размера m на n, каждый элемент в массиве
// находится по формуле: A = m+n. Выведете полученный массив на экран.

// int Prompt(string message)
// {
//     System.Console.Write(message);
//     int result = Convert.ToInt32(Console.ReadLine());
//     return result;
// }

// int[,] FillArray(int numLine, int numColumns)
// {
//     int[,] matrix = new int[numLine, numColumns];
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i, j] = i + j; // Заполнение массива по формуле А = m +n
//         }
//     }
//     return matrix;
// }

// void PrintArray(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//        for (int j = 0; j < matrix.GetLength(1); j++)
//        {
//             Console.Write($"{matrix[i,j]}\t");
//        } 
//        Console.WriteLine();
//     }
// }

// int[,]array = FillArray(Prompt("Введите число строк > "), Prompt("Введите число колонок > "));
// PrintArray(array);


//Найдите элементы, у которых обе позиции чётные, и замените эти элементы на их квадраты.


// int Prompt(string message)
// {
//     System.Console.Write(message);
//     int result = Convert.ToInt32(Console.ReadLine());
//     return result;
// }

// int[,] FillArray(int numLine, int numColumns, int maxRand = 20, int minRand = 0)
// {
//     int[,] matrix = new int[numLine, numColumns];//Создание нового массива
//     for (int i = 0; i < matrix.GetLength(0); i++)//Условие для создания строки
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++) //Условие для создания столбца
//         {
//             matrix[i, j] = new Random().Next(minRand, maxRand); // Заполнение массива по формуле А = m +n
//         }
//     }
//     return matrix; // Возвращение результата
// }

// void PrintArray(int[,] matrix) //Печать массива
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//        for (int j = 0; j < matrix.GetLength(1); j++)
//        {
//             Console.Write($"{matrix[i,j]}\t"); //Заполнение строки (вывод очередной строки)
//        } 
//        Console.WriteLine(); //переход на следущую строку
//     }
// }


// int[,] ConvertToSQR(int [,] array) //Функция для замены значений с чётными строками и столбцами на их квадрат
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j= 0; j< array.GetLength(1); j++)
//         {
//             if(i % 2 == 0 && j % 2 == 0) // 
//             {
//                 array[i, j] = array[i, j] * array[i, j];
//             }
//         }
//     }
//     return array;
// }

// int[,] massiv = FillArray(5, 5); //Объявляем массив "massiv", и указываем по какой функции он будет заполняться, указываем размер
// PrintArray(massiv); // выводим на экран полученное
// System.Console.WriteLine(); //Печать пустой строки
// int[,] newmassiv = ConvertToSQR(massiv); //объявление нового массива и запуск функции SQR
// PrintArray(newmassiv);// вывод результата на печать


//Задайте двумерный массив. Найдите сумму элементов главной диагонали.

// Random rand = new Random();

// void FillMatrix (int[,] matr)
// {
//     for (int i = 0; i < matr.GetLength(0); i++)
//     {
//         for (int j = 0; j < matr.GetLength(1); j++)
//         {
//             matr[i, j] = rand.Next(1, 15);
//         }
//     }
// }

// void PrintArray(int[,] arr)
// {
//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//        for (int j = 0; j < arr.GetLength(1); j++)
//        {
//             Console.Write($"{arr[i, j]}\t");
//        } 
//        System.Console.WriteLine();
//     }
// }



// int[,] matrix = new int[3, 3];

// FillMatrix(matrix);
// PrintArray(matrix);
// System.Console.WriteLine(GetSum(matrix));
// int GetSum (int[,] matrix)
// {
//     int sum = 0;
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         sum += matrix[i, i];
//     }
//     return sum;
// }


//Задача: Задайте двумерный массив. Введите элементы, найдите его первое вхождение.
// Выведете позицию по горизонтали и вертикали, или напишите, что такого элемента нет.
//Например:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4 

//Введённый элемент: 2, результат: [1, 4]

//Введённый элемент: 6, результат: такого элемента нет.

// Random rand = new Random();

// void FillMatrix (int[,] matr)
// {
//     for (int i = 0; i < matr.GetLength(0); i++)
//     {
//         for (int j = 0; j < matr.GetLength(1); j++)
//         {
//             matr[i, j] = rand.Next(1, 15);
//         }
//     }
// }

// void PrintArray(int[,] arr)
// {
//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//        for (int j = 0; j < arr.GetLength(1); j++)
//        {
//             Console.Write($"{arr[i, j]}\t");
//        } 
//        System.Console.WriteLine();
//     }
// }



// int[,] matrix = new int[3, 3];

// FillMatrix(matrix);
// PrintArray(matrix);

// System.Console.WriteLine("Input a number: ");
// int element = int.Parse(Console.ReadLine());
// FindElem(matrix, element);

// void FindElem (int[,] matrix, int element)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//            if (element == matrix[i, j])
//            {
//              System.Console.WriteLine($"Введённое число {element} находится на позиции {i},{j} ");
//              return;
//            }
//         }
//     }
//     System.Console.WriteLine("Введённого элемента нет в массиве.");

// }
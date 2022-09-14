// Задача 53: Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.

Console.Clear();

// Random rand = new Random();

// void FillMatrix (int[,] matr)
// {
//     for (int i = 0; i < matr.GetLength(0); i++)
//     {
//         for (int j = 0; j < matr.GetLength(1); j++)
//         {
//             matr[i, j] = rand.Next(1, 10);
//         }
//     }
// }

// void PrintArray(int[,] matr)
// {
//     for (int i = 0; i < matr.GetLength(0); i++)
//     {
//        for (int j = 0; j < matr.GetLength(1); j++)
//        {
//             Console.Write($"{matr[i, j]}  ");
//        } 
//        System.Console.WriteLine();
//     }
// }

// void ReplaceLine (int[,] matr) //Функция замены значений попозиционно (matr[0, j] на matr[matr.GetLenght(0)-1, j])
// {
//     int n = 0;
//     int m = matr.GetLength(0) - 1;
//     int temp = 0;
//     System.Console.WriteLine();
//     for (int i = 0; i < matr.GetLength(0); i++)
//     {
//         if(i != n)
//         {
//             for (int j = 0; j < matr.GetLength(1); j++)
//             {
//                 Console.Write($"{matr[i, j]}  ");
//             }
//             Console.WriteLine(); 
//         }
//         else
//         {
//             for (int j = 0; j < matr.GetLength(1); j++)
//             {
//                 temp = matr[n, j];
//                 matr[n, j] = matr[m, j];
//                 matr[m, j] = temp;
//                 Console.Write($"{matr[i, j]}  ");
//             }
//             System.Console.WriteLine();

//         }
//     }
// }


// int[,] matrix = new int[4, 3];

// FillMatrix(matrix);
// PrintArray(matrix);
// ReplaceLine(matrix);

//Задача 55: Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. 
//В случае, если это не возможно, программа должна вывести сообщение для пользователя.

// Random rand = new Random();

// void FillMatrix (int[,] matr)
// {
//     for (int i = 0; i < matr.GetLength(0); i++)
//     {
//         for (int j = 0; j < matr.GetLength(1); j++)
//         {
//             matr[i, j] = rand.Next(1, 10);
//         }
//     }
// }

// void PrintArray(int[,] matr)
// {
//     for (int i = 0; i < matr.GetLength(0); i++)
//     {
//        for (int j = 0; j < matr.GetLength(1); j++)
//        {
//             Console.Write($"{matr[i, j]}  ");
//        } 
//        System.Console.WriteLine();
//     }
// }

// void VertUTurnMatrix (int[,] matr)
// {
// if (matr.GetLength(0) <= matr.GetLength(1))
// {
//         for (int i = 0; i < matr.GetLength(0); i++)
//         {
//             for (int j = 0; j < matr.GetLength(0); j++)
//             {
//                 Console.Write($"{matr[j, i]}  ");
//             }
//             Console.WriteLine(); 
//         }
// }
// else
// {
//   Console.WriteLine("Произвести разворот невозможно"); 
// }
// }





Random rand = new Random();

void FillMatrix (int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = rand.Next(1, 10);
        }
    }
}

void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
       for (int j = 0; j < matr.GetLength(1); j++)
       {
            Console.Write($"{matr[i, j]}  ");
       } 
       System.Console.WriteLine();
    }
}


int[,] matrix = new int[4, 4];
FillMatrix(matrix);
PrintArray(matrix);
System.Console.WriteLine("---------------------------");




            for (int i = 0; i < matrix.GetLength(0); i++) // Array Sorting
            {
                for (int j = matrix.GetLength(1) - 1; j > 0; j--)
                {


                    for (int k = 0; k < j; k++)
                    {
                        if (matrix[i, k] > matrix[i, k + 1])
                        {
                            int temp = matrix[i, k];
                            matrix[i, k] = matrix[i, k + 1];
                            matrix[i, k + 1] = temp;
                        }
                    }
                }
                Console.WriteLine();
            }


            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write("{0,3}", matrix[i, j]);
                }
                Console.WriteLine();
            }

﻿// Задача 53: Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.

Console.Clear();

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

void ReplaceLine (int[,] matr) //Функция замены значений попозиционно (matr[0, j] на matr[matr.GetLenght(0)-1, j])
{
    int n = 0;
    int m = matr.GetLength(0) - 1;
    int temp = 0;
    System.Console.WriteLine();
    for (int i = 0; i < matr.GetLength(1); i++)
    {
        if(i == n)
        {
            for (int j = 0; j < matr.GetLength(1); j++)
            {
                temp = matr[n, j];
                matr[n, j] = matr[m, j];
                matr[m, j] = temp;
                Console.Write($"{matr[i, j]}  ");
            }
            System.Console.WriteLine(); 
        }
        else
        {
            for (int j = 0; j < matr.GetLength(1); j++)
            {
                Console.Write($"{matr[i, j]}  "); 
            }
            System.Console.WriteLine();
        }
    }
}


int[,] matrix = new int[3, 4];

FillMatrix(matrix);
PrintArray(matrix);
ReplaceLine(matrix);
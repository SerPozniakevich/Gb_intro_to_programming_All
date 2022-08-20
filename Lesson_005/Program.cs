
Console.Clear();

// Создание и вывод массива.

//Функция генерации рандомного массива с N индексом.

int[] CreateRandomArray(int N, int start, int end) //[]-обозначение создания массива, 
                                                  //N - длинна массива, start - генерация рандомного числа,
                                                  // end - диапазон для генерации рандомного числа
{
    int[] RandomArray = new int[N]; //int[]-созание пустого массива и определение длинны массива
    for (int i = 0; i < N; i++)
    {
        RandomArray[i] = new Random().Next(start, end + 1);// запись в элемент массива [i] нового числа
                                                            // из диапазона от start до end+1
    }
    return RandomArray;
}

//Функция создания массива с вводимыми данными (название RandomArray - просто название)))

int[] CreateArray()
{
    Console.WriteLine("Введите количество элементов массива");//Запрос 
    int size = Convert.ToInt32(Console.ReadLine());//сохранение в переменную "size"
    int[] RandomArray = new int[size];//создание массива заданого размера
    for (int i = 0; i < size; i++)// цикл с запросом введения значений для каждой ячейки по заданному размеру
    {
        Console.WriteLine($"Введите {i+1} элемент массива");// "i+1" - чтобы не путать пользователя с нулевым индексом ячейки
        RandomArray[i] = Convert.ToInt32(Console.ReadLine());
    }
    return RandomArray;
}


void ShowArray(int[] array)//Выводит массив на экран
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

Console.Clear();
Console.WriteLine("Введите количество элементов в массиве");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите первое число сучайного диапазона");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите последее число случайного дапазона");
int max = Convert.ToInt32(Console.ReadLine());

int[] myRandomArray = CreateRandomArray(num, min, max);
ShowArray(myRandomArray);
Console.WriteLine("------------");
int[] myArray = CreateArray();
ShowArray(myArray);








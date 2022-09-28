// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

// Чтение данных из консоли
int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

// Печать двумерного массива
void Print2DArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

// Заполняем массив случайными числами
void Fill2DArray(int[,] matr, int min, int max)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(min, max + 1);
        }
    }
}

//  Сортируем строки по убыванию
void Sort2DArray(int[,] matr)
{
    int[] arr = new int[matr.GetLength(1)];
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            arr[j] = matr[i, j];
        }
        BoobleSort(arr);
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = arr[j];
        }
    }
}

// сортировка пузырьком
void BoobleSort(int[] arr)
{
    int tempNum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        for (int j = 0; j < arr.Length - 1 - i; j++)
        {
            if (arr[j] < arr[j + 1])
            {
                tempNum = arr[j];
                arr[j] = arr[j + 1];
                arr[j + 1] = tempNum;
            }
        }
    }
}

int m = ReadData("Введите количество строк M: ");
int n = ReadData("Введите количество столбцов N: ");
int[,] matrix = new int[m, n];

Fill2DArray(matrix, 1, 9);
Print2DArray(matrix);

Sort2DArray(matrix);
Print2DArray(matrix);
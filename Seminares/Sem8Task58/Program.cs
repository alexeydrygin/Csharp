// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

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

//  Умножаем две матрицы
int[,] Multiple2DArray(int[,] matr, int[,] arr)
{
    int[,] matrix = new int[matr.GetLength(0), arr.GetLength(1)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matr.GetLength(1); k++)
            {
                matrix[i, j] += matr[i, k] * arr[k, j];
            }
        }
    }
    return matrix;
}

// Печать результата
void PrintResult(string prefix, string data)
{
    Console.WriteLine(prefix + data);
}

int m = ReadData("Введите количество строк первой матрицы M: ");
int n = ReadData("Введите количество столбцов первой матрицы N: ");
int[,] matrix = new int[m, n];

Fill2DArray(matrix, 1, 9);
Print2DArray(matrix);

PrintResult("Количество строк втрой матрицы должно равняться количеству столбцов первой, поэтому M2 = ", n.ToString());
int n1 = ReadData("Введите количество столбцов N2: ");
int[,] matrix1 = new int[n, n1];



Fill2DArray(matrix1, 1, 9);
Print2DArray(matrix1);

Print2DArray(Multiple2DArray(matrix, matrix1));
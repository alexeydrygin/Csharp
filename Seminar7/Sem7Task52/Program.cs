// ---------------------------------------------------------------------
//                                 Задача 52
// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом
// столбце.
// * Дополнительно вывести среднее арифметическое по диагоналям и диагональ выделить разным
// цветом.
// ---------------------------------------------------------------------


// Чтение данных из консоли
int ReadData(string line)
{
    // Выводим сообщение
    Console.Write(line);
    // Считываем число
    int number = int.Parse(Console.ReadLine() ?? "0");
    // Возвращаем значение
    return number;
}

// Создаём список цветов терминала
ConsoleColor[] col = new ConsoleColor[]{ConsoleColor.Black,ConsoleColor.Blue,ConsoleColor.Cyan,
                                        ConsoleColor.DarkBlue,ConsoleColor.DarkCyan,ConsoleColor.DarkGray,
                                        ConsoleColor.DarkGreen,ConsoleColor.DarkMagenta,ConsoleColor.DarkRed,
                                        ConsoleColor.DarkYellow,ConsoleColor.Gray,ConsoleColor.Green,
                                        ConsoleColor.Magenta,ConsoleColor.Red,ConsoleColor.White,
                                        ConsoleColor.Yellow};


// // Печать двумерного массива цветом (Надо доделать!!!)
// void Print2DArrayColor(int[,] matr)
// {
//     Console.WriteLine();
//     for (int i = 0; i < matr.GetLength(0); i++)
//     {
//         for (int j = 0; j < matr.GetLength(1); j++)
//         {
//             if (i == j)
//             {
//                 Console.ForegroundColor = col[15];
//                 Console.Write($"{matr[i, j]} ");
//                 Console.ResetColor();
//             }
//             else if (i + 1 == j)
//             {
//                 Console.ForegroundColor = col[13];
//                 Console.Write($"{matr[i, j]} ");
//                 Console.ResetColor();
//             }
//             else if (i + 2 == j)
//             {
//                 Console.ForegroundColor = col[7];
//                 Console.Write($"{matr[i, j]} ");
//                 Console.ResetColor();
//             }
//             else if (i + 3 == j)
//             {
//                 Console.ForegroundColor = col[6];
//                 Console.Write($"{matr[i, j]} ");
//                 Console.ResetColor();
//             }
//             else if (i + 4 == j)
//             {
//                 Console.ForegroundColor = col[5];
//                 Console.Write($"{matr[i, j]} ");
//                 Console.ResetColor();
//             }
//             else if (i == j + 1)
//             {
//                 Console.ForegroundColor = col[11];
//                 Console.Write($"{matr[i, j]} ");
//                 Console.ResetColor();
//             }
//             else if (i == j + 2)
//             {
//                 Console.ForegroundColor = col[10];
//                 Console.Write($"{matr[i, j]} ");
//                 Console.ResetColor();
//             }
//             else if (i == j + 3)
//             {
//                 Console.ForegroundColor = col[9];
//                 Console.Write($"{matr[i, j]} ");
//                 Console.ResetColor();
//             }
//             else if (i == j + 4)
//             {
//                 Console.ForegroundColor = col[8];
//                 Console.Write($"{matr[i, j]} ");
//                 Console.ResetColor();
//             }
//             else
//             {
//                 Console.Write($"{matr[i, j]} ");
//             }
//         }
//         Console.WriteLine();
//     }
// }

// Печать двумерного массива
void Print2DArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]}\t");
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

// Находим среднее арифметическое по столбцам
double[] Count(int[,] matr)
{
    double[] arr = new double[matr.GetLength(1)];

    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            arr[j] = arr[j] + matr[i, j];
        }
    }

    FindMidleArifmetic(arr, matr.GetLength(0));
    return arr;
}

// Находим среднее арифметическое
double[] FindMidleArifmetic(double[] arr, int numbers)
{
    for (int k = 0; k < arr.Length; k++)
    {
        arr[k] = Math.Round(arr[k] / numbers, 2);
    }
    return arr;
}

// печатаем массив
void PrintArray(double[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]}\t");
    }
    Console.WriteLine();
}





int m = ReadData("Введите количество строк M: ");
int n = ReadData("Введите количество столбцов N: ");
int[,] matrix = new int[m, n];

Fill2DArray(matrix, 10, 99);
Print2DArray(matrix);
PrintArray(Count(matrix));
// Print2DArrayColor(matrix);
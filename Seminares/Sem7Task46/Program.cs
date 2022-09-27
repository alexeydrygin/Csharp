// Задача №46
// Задайте двумерный массив размером m×n,
// заполненный случайными целыми числами.
// Например:
// m = 3, n = 4.
// -1 4 8 19
// 5 -2 33 -2
// -77 3 8 1

//семинар с 0-26

int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

// //Печать результата
// void PrintData(string prefix, string data) //разбили на две части вывод в консоль
// {
//     Console.WriteLine(prefix + data);
// }

//Универсальный метод генерации и заполнения 2D массива
int[,] Fill2DArray(int countRow, int countColumn, int downBorder, int topBorder)
{
    System.Random rand = new System.Random();
    int[,] array2D = new int[countRow, countColumn];
    if (downBorder < topBorder)
        //Заполняем массив
        for (int i = 0; i < countRow; i++) //проходим строки
        {
            for (int j = 0; j < countColumn; j++) //проходим столбцы
            {
                array2D[i, j] = rand.Next(downBorder, topBorder + 1);
            }
        }
    //Возвращаем результат
    return array2D;
}

// //Печать двумерного массива
// void Print2DArray(int[,] matr)
// {
//     for (int i = 0; i < matr.GetLength(0); i++)
//     {
//         for (int j = 0; j < matr.GetLength(1); j++)
//         {
//             Console.Write($"{matr[i, j]}\t"); //\t табуляция
//         }
//         Console.WriteLine();
//     }
// }

// //Печать двумерного массива цветом
// void Print2DArrayColored(int[,] matr)
// {
//     for (int i = 0; i < matr.GetLength(0); i++)
//     {
//         for (int j = 0; j < matr.GetLength(1); j++)
//         {
//             Console.ForegroundColor = ConsoleColor.Green;
//             Console.Write($"{matr[i, j]}\t");
//             Console.ResetColor();
//         }
//         Console.WriteLine();
//     }
// }

ConsoleColor[] col = new ConsoleColor[]{ConsoleColor.Black, ConsoleColor.Blue, ConsoleColor.Cyan,
                                        ConsoleColor.DarkBlue, ConsoleColor.DarkCyan, ConsoleColor.DarkGray,
                                        ConsoleColor.DarkGreen, ConsoleColor.DarkMagenta,ConsoleColor.DarkRed,
                                        ConsoleColor.DarkYellow, ConsoleColor.Gray, ConsoleColor.Green,
                                        ConsoleColor.Magenta, ConsoleColor.Red, ConsoleColor.White,
                                        ConsoleColor.Yellow};


//Печать двумерного массива рандомным цветом
void Print2DArrayColored(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.ForegroundColor = col[new System.Random().Next(0, 16)];
            Console.Write($"{matr[i, j]} ");
            Console.ResetColor();
        }
        Console.WriteLine();
    }
}

int row = ReadData("Введите количество строк ");
int column = ReadData("Введите количество столбцов ");

int[,] arr2D = Fill2DArray(row, column, 10, 99);
Print2DArrayColored(arr2D);
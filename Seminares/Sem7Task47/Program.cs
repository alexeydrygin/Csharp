// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

//Чтение данных от пользователя
int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

//Метод генерации и заполнения 2D массива вещественными числами
double[,] Fill2DArrayWithDot(int countRow, int countColumn, int downBorder, int topBorder)
{
    System.Random rand = new System.Random();
    double[,] array2D = new double[countRow, countColumn];
    if (downBorder < topBorder)
        //Заполняем массив
        for (int i = 0; i < countRow; i++) //проходим строки
        {
            for (int j = 0; j < countColumn; j++) //проходим столбцы
            {
                array2D[i, j] = Convert.ToDouble(new Random().Next(downBorder, topBorder)) / 10;
            }
        }
    //Возвращаем результат
    return array2D;
}

//Печать двумерного массива
void Print2DArray(double[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]}\t");
        }
        Console.WriteLine();
    }
}


int row = ReadData("Введите количество строк ");
int column = ReadData("Введите количество столбцов ");

double[,] arr2D = Fill2DArrayWithDot(row, column, 10, 90);
Print2DArray(arr2D);
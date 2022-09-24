// Задача №48
// Задайте двумерный массив размера m на n, каждый
// элемент в массиве находится по формуле: Aₘₙ =
// m+n. Выведите полученный массив на экран.
// Пример:
// m = 3, n = 4.
// 0 1 2 3
// 1 2 3 4
// 2 3 4 5

//семинар с 0-53

//Универсальный метод генерации и заполнения 2D массива
int[,] Fill2DArrayMN(int m, int n)
{
    int[,] array2D = new int[m, n];
    for (int i = 0; i < m; i++) //проходим строки
    {
        for (int j = 0; j < n; j++) //проходим столбцы
        {
            array2D[i, j] = i + j;
        }
    }
    //Возвращаем результат
    return array2D;
}

//Печать двумерного массива рандомным цветом
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
}

int[,] arr2D = Fill2DArrayMN(7, 7);
Print2DArray(arr2D);
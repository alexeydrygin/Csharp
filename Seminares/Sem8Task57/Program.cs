// ---------------------------------------------------------------------
//                                 Задача 57
// Составить частотный словарь элементов
// двумерного массива. Частотный словарь содержит
// информацию о том, сколько раз встречается
// элемент входных данных.
// ---------------------------------------------------------------------

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

// печатаем массив
void PrintArray(int[] arr)
{
    for (int i = 1; i < arr.Length - 1; i++)
    {
        Console.Write($"{arr[i]} ");
    }
}

// создаём частотный словарь
int[] FreqDicLoad(int[,] arr)
{
    int[] dic = new int[10];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            dic[arr[i, j]]++;
        }
    }
    return dic;
}

int m = ReadData("Введите количество строк M: ");
int n = ReadData("Введите количество столбцов N: ");
int[,] matrix = new int[m, n];

Fill2DArray(matrix, 0, 9);
Print2DArray(matrix);

PrintArray(FreqDicLoad(matrix));






//  Mikhail

// // Создает двумерный массив размером m×n
// int[,] GenerateArray(int countRow, int countColumn, int topBorder, int downBorder)
// {
//     Random rand = new Random();
//     int[,] array = new int[countRow, countColumn];
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = rand.Next(topBorder, downBorder);
//         }
//     }
//     return array;
// }


// // Возвращает частотный словарь элементов двумерного массива
// SortedDictionary<int, int> CountDictionary(int[,] array)
// {
//     SortedDictionary<int, int> dict = new SortedDictionary<int, int>();
//     for (int i = 0; i < array.GetLength(0); i++)
//     {

//         for (int j = i + 1; j < array.GetLength(1); j++)
//         {
//             if (dict.ContainsKey(array[j, i]))
//                 dict[array[j, i]] = dict[array[j, i]] + 1;
//             else
//                 dict.Add(array[j, i], 1);
//         }
//     }
//     return dict;
// }
// // вывод двумерного массива
// void Print2DArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write($"{array[i, j]} ");

//         }
//         Console.WriteLine();
//     }
// }

// // вывод ответа
// void PrintAnswer(string answer, string title = "")
// {
//     Console.WriteLine("{0} -> {1}", title, answer);
// }



// int[,] array = GenerateArray(5, 5, 0, 10);

// Console.WriteLine("\n------- Исходная матрица -------\n");
// Print2DArray(array);

// SortedDictionary<int, int> dict = CountDictionary(array);

// PrintAnswer("Сколько повторений\n", "\nЧисло");
// foreach (KeyValuePair<int, int> kvp in dict)
// {
//     PrintAnswer(kvp.Value.ToString(), kvp.Key.ToString());
// }

// Задача №61
// Вывести первые N строк треугольника Паскаля.
// Сделать вывод в виде равнобедренного
// треугольника
//----------------------------------------------------------------------------------------
// // Вычисляем факториал
// float factorial(int n)
// {
//     float i, x = 1;
//     for (i = 1; i <= n; i++)
//     {
//         x *= i;
//     }
//     return x;
// }

// int i, n, c;
// Console.WriteLine("Введите нужное количество строк треугольника Паскаля:");
// string s = Console.ReadLine();
// n = Convert.ToInt32(s);

// for (i = 0; i < n; i++)
// {
//     // создаём после каждой строки n-i отступов от левой стороны консоли, 
//     // чем ниже строка, тем меньше отступ
//     for (c = 0; c <= (n - i); c++)
//     {
//         Console.Write(" ");
//     }
//     for (c = 0; c <= i; c++)
//     {
//         // создаём пробелы между элементами треугольника
//         Console.Write(" ");
//         //формула вычисления элементов треугольника
//         Console.Write(factorial(i) / (factorial(c) * factorial(i - c)));
//     }

//     Console.WriteLine();
//     // после каждой строки с числами отступаем две пустые строчки
//     Console.WriteLine();
// }
// Console.ReadLine();

//-------------------------------------------------------------------------

///Вывод треугольника Паскаля двумерным массивом:
///минус в лишних нулях((

Console.WriteLine("Введите количество строк треугольника Паскаля:");
int numberRows = int.Parse(Console.ReadLine());

///Метод заполнения массива алгоритмом Паскаля:
int[,] FillPascalArray(int numberRows)
{
    int rows = numberRows;
    int columns = numberRows + 2;
    int[,] array = new int[rows, columns];
    //array[0, 0] = 0;
    array[0, 1] = 1;
    //array[0, 2] = 0;
    for (int i = 1; i < array.GetLength(0); i++)
    {
        for (int j = 1; j < array.GetLength(1); j++)
        {
            array[i, j] = array[i - 1, j - 1] + array[i - 1, j];
        }
    }
    return array;
}


///Метод печати массива Паскаля:
void PrintPascalArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int k = array.GetLength(0); k > i; k--)
        {
            Console.Write("  ");
        }
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write("{0,4}", array[i, j]);
        }
        Console.WriteLine();
    }
}

int[,] array = FillPascalArray(numberRows);
Console.WriteLine();

PrintPascalArray(array);

//-------------------------------------------------------------------------
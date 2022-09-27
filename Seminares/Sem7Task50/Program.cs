// Задача 50. 
// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и
// возвращает значение этого элемента или же указание, что такого элемента нет
// * Заполнить числами Фиббоначи и выделить цветом найденную цифру

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

// Печать результата
void PrintResult(string prefix, string data)
{
    if (data.Equals("-1"))
    {
        Console.WriteLine("Искомый элемент отсутствует");
    }
    else
    {
        Console.WriteLine(prefix + data);
    }
}

// Печать двумерного массива
void Print2DArray(double[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}

// Числа Фибоначи рекурсией
double Fibonachi(int n)
{
    if (n == 0 || n == 1)
    {
        return n;
    }
    else
    {
        return Fibonachi(n - 1) + Fibonachi(n - 2);
    }
}

// Заполняем массив числами Фибоначи
void Fill2DArray(double[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = Fibonachi(j + matr.GetLength(1) * i);
        }
    }
}

// Ищем элемент по индексам
double FindElement(int x, int y, double[,] matr)
{
    if (x < matr.GetLength(0) && y < matr.GetLength(1))
    {

        return matr[x, y];
    }
    else { return -1; }
}

// Печать двумерного массива с цветом
void Print2DArrayColor(int x, int y, double[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            if (i == x && j == y)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write($"{matr[i, j]} ");
                Console.ResetColor();
            }
            else { Console.Write($"{matr[i, j]} "); }
        }
        Console.WriteLine();
    }
}

int m = ReadData("Введите количество строк M: ");
int n = ReadData("Введите количество столбцов N: ");
double[,] matrix = new double[m, n];

int x = ReadData("Введите искомый строку(от 0 до M): ");
int y = ReadData("Введите искомую столбец(от 0 до N): ");

Fill2DArray(matrix);
Print2DArray(matrix);
PrintResult("Искомый элемент: ", FindElement(x, y, matrix).ToString());
Print2DArrayColor(x, y, matrix);
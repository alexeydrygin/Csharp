// ---------------------------------------------------------------------
//                                 Задача 65
// Задайте значения M и N. Напишите программу, которая найдёт все натуральные элементы в промежутке от M до N.
// ---------------------------------------------------------------------

// Чтение данных из консоли
int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

// Печать результата
void PrintResult(string prefix)
{
    Console.WriteLine(prefix);
}

// Все натуральные элементы от m до n
string RecMN(int m, int n)
{
    if (m >= n) return n.ToString();
    return m + " " + RecMN(m + 1, n);
}

int m = ReadData("Введите число: ");
int n = ReadData("Введите число: ");

PrintResult(m > n ? RecMN(n, m) : RecMN(m, n));

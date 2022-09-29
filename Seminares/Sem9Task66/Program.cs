// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

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

//Метод нахождения суммы натуральных элементов в промежутке от M до N
void SumFromMtoN(int m1, int n1, int sum)
{
    if (m1 > n1)
    {
        Console.WriteLine($"Сумма натуральных элементов в промежутке от M до N: {sum}");
        return;
    }
    sum = sum + (m1++);
    SumFromMtoN(m1, n1, sum);
}

int m = ReadData("Введите число: ");
int n = ReadData("Введите число: ");

PrintResult(m > n ? RecMN(n, m) : RecMN(m, n));
SumFromMtoN(m, n, 0);
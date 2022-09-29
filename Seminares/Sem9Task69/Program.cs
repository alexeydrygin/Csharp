// ---------------------------------------------------------------------
//                                 Задача 69
// принимает на вход числа и возвращает степень числа
// ---------------------------------------------------------------------

// Чтение данных из консоли
int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

// Печать результата
void PrintResult(int prefix)
{
    Console.WriteLine(prefix);
}

int RecPow(int A, int B)
{
    if (B == 1) return A;
    return A * RecPow(A, B - 1);
}

int NoRecPow(int num, int pow)
{
    int result = 1;
    for (int i = 0; i < pow; i++)
    {
        result = result * num;
    }
    return result;
}

int A = ReadData("Введите число: ");
int B = ReadData("Введите степень: ");

PrintResult(RecPow(A, B));

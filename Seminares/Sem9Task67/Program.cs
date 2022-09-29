// ---------------------------------------------------------------------
//                                 Задача 67
// примает на вход число и возвращает сумму числа
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

int RecSumDig(int num)
{
    if (num == 0) return 0;
    return num % 10 + RecSumDig(num / 10);
}

int numN = ReadData("Введите число: ");

PrintResult(RecSumDig(numN).ToString());

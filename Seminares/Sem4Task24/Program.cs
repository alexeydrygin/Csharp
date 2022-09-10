// Задача №24
// Напишите программу, которая принимает на вход
// число (А) и выдаёт сумму чисел от 1 до А.
// Например:
// 7 -> 28
// 4 -> 10
// 8 -> 36

// Чтение данных из консоли
int ReadData(string line)
{
    //Выводим сообщение
    Console.WriteLine(line);
    //Считываем число
    int number = int.Parse(Console.ReadLine() ?? "0");
    //Возвращаем значение
    return number;
}

//Метод вывода данных
void PrintResult(string line)
{
    Console.WriteLine(line);
}

//Метод суммирования, возвращает сумму из цикла
int VariantSumSimple(int numA)
{
    int sumOfNumbers = 0;
    for (int i = 1; i <= numA; i++) //for от нуля до того пока не достигнем числа А прибавляем по единице
    {
        sumOfNumbers += i;//накапливаем i
    }
    return sumOfNumbers;
}

//Метод суммирования по Гауссу
int VariantSumGause(int numA)
{
    int sumOfNumbers = 0;
    sumOfNumbers = ((1 + numA) * numA) / 2;
    return sumOfNumbers;
}


//получаем число от пользователя
int numberA = ReadData("\n Введите число А");

DateTime d1 = DateTime.Now;
int res1 = VariantSumSimple(numberA);
Console.WriteLine(DateTime.Now - d1);

DateTime d2 = DateTime.Now;
int res2 = VariantSumGause(numberA);
Console.WriteLine(DateTime.Now - d2);

PrintResult("Сумма чисел от 1 до A равна (простой метод):  " + res1);
PrintResult("Сумма чисел от 1 до A равна (по Гауссу):  " + res2);



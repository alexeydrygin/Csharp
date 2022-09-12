//-----------Чтение данных из консоли----------------

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

//-----------Метод вывода данных----------------

//Метод вывода данных
void PrintResult(string line)
{
    Console.WriteLine(line);
}

//-----------Метод суммирования, возвращает сумму из цикла----------------

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

//-----------Метод суммирования по Гауссу S=((A1+An)\*N)/2----------------

//Метод суммирования по Гауссу
int VariantSumGause(int numA)
{
    int sumOfNumbers = 0;
    sumOfNumbers = ((1 + numA) \*numA) / 2;
return sumOfNumbers;
}

//-----------Метод измерения скорости выполнения----------------

// Метод измерения скорости выполнения кода
DateTime d1 = DateTime.Now;
TestMetod(metod);
Console.WriteLine(DateTime.Now - d1);

DateTime d2 = DateTime.Now;
TestMetod(metod);
Console.WriteLine(DateTime.Now - d2);

//-----------Метод вычисления суммы цифр в числе----------------

//Метод вычисления суммы цифр в числе
int SumDigit(int num)
{
    int sum = 0;
    while (num > 0)
        sum += num % 10;
    num = num / 10;
    return sum;
}

//-----------Метод вычисления количества цифр в числе----------------

//Метод вычисления количества цифр в числе
int DigitCount(int num)
{
    int sum = 0;
    while (num > 0)
    {
        sum += 1;
        num = num / 10;
    }
    return sum;
}

//-----------Метод вычисления произведения цифр в числе----------------

//Метод вычисления произведения цифр в числе
long MuttA(int number)
{
    int i = 1;
    long sum = 1;
    while (i <= number)
    {
        sum = sum * i;
        i++;
    }
    return sum;
}

//---------------------------
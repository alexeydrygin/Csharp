//Задача №26
// Напишите программу, которая принимает на вход
// число и выдаёт количество цифр в числе.
// Пример:
// 456 -> 3
// 78 -> 2
// 89126 -> 5
//Семинар с 1-04


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

//Вариант1. Метод вычисления длины строки
int CalculateDigits(int num)
{
    string numString = num.ToString();
    return numString.Length;
}

//Вариант2. Метод вычисления длины строки через логарифм
int CalculateDigitsLog(int num)
{
    return (int)(Math.Log10(num) + 1);
}

//Вариант3. Метод вычисления количества цифр в числе
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
//Метод вывода данных
void PrintResult(string line)
{
    Console.WriteLine(line);
}

Console.WriteLine("Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.");
int number = ReadData("\n \n Введите число: ");

DateTime d1 = DateTime.Now;
int numberOfDigits = CalculateDigits(number);
PrintResult("\n Количество цифр в числе (ToString): " + numberOfDigits);
Console.WriteLine(DateTime.Now - d1);

DateTime d2 = DateTime.Now;
int numberOfDigitsLog = CalculateDigitsLog(number);
PrintResult("\n Количество цифр в числе (Math.Log): " + numberOfDigitsLog);
Console.WriteLine(DateTime.Now - d2);

DateTime d3 = DateTime.Now;
int digitCount = DigitCount(number);
PrintResult("\n Количество цифр в числе (Цикл): " + digitCount);
Console.WriteLine(DateTime.Now - d3);
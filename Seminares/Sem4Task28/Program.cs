// Задача №28
// Напишите программу, которая принимает на вход
// число N и выдаёт произведение чисел от 1 до N.
// Например:
// 4 -> 24
// 5 -> 120

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

Console.WriteLine("Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.");
int number = ReadData("\n \n Введите число: ");

DateTime d3 = DateTime.Now;
long muttA = MuttA(number);
PrintResult("\n произведение цифр в числе: " + muttA);
Console.WriteLine("Время выполнения программы");
Console.WriteLine(DateTime.Now - d3);

//Метод вывода данных
void PrintResult(string line)
{
    Console.WriteLine(line);
}
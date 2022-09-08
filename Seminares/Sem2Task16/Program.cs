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

//Тест на квадрат
bool SqrTest(int firstNum, int secondNum)
{
    if (firstNum == secondNum * secondNum)
    {
        return true;
    }
    else
    {
        return false;
    }

}

//Вывод данных
void PrintData(int firstNum, int secondNum)
{
    if (SqrTest(firstNum, secondNum))
    {
        Console.WriteLine("Число " + firstNum + " квадрат числа " + secondNum);
    }
    else
    {
        Console.WriteLine("Число " + firstNum + " не квадрат числа " + secondNum);
    }
}

int num1 = ReadData("Введите первое число: ");
int num2 = ReadData("Введите второе число: ");

PrintData(num1, num2);
PrintData(num2, num1);
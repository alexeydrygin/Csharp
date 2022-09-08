//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.

//время в семинаре 55-27

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

//Расстояние между двумя точками
double CalcData(int x1, int y1, int x2, int y2)
{
    return Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));
}

//Собираем данные пользователя
int x1 = ReadData("Введите X1: ");
int y1 = ReadData("Введите Y1: ");
int x2 = ReadData("Введите X2: ");
int y2 = ReadData("Введите Y2: ");


//Выводим результат
//Math.Round(d, x) округляет число d до x знаков
PrintResult(Math.Round(CalcData(x1, y1, x2, y2), 2).ToString());


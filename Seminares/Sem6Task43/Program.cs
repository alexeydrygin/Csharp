// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

// Console.WriteLine("введите значение b1");
// double b1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("введите число k1");
// double k1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("введите значение b2");
// double b2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("введите число k2");
// double k2 = Convert.ToInt32(Console.ReadLine());

// double x = (-b2 + b1) / (-k1 + k2);
// double y = k2 * x + b2;

// Console.WriteLine($"две прямые пересекутся в точке с координатами - (X: {x}, Y: {y})");

// ---------------------------------------------------------------------

// Чтение данных из консоли
double ReadData(string line)
{
    // Выводим сообщение
    Console.Write(line);
    // Считываем число
    double number = double.Parse(Console.ReadLine() ?? "0");
    // Возвращаем значение
    return number;
}

// Печать результата
void PrintResult(string prefix, string data)
{
    Console.WriteLine(prefix + data);
}

// Поиск точки пересечения двух прямых
double[] PointFind(double k1, double b1, double k2, double b2)
{
    double[] outtArr = new double[2];
    double x = (b2 - b1) / (k1 - k2);
    double y = k1 * x + b1;
    outtArr[0] = x;
    outtArr[1] = y;
    return outtArr;
}

double k1 = ReadData("Введите k1: ");
double b1 = ReadData("Введите b1: ");
double k2 = ReadData("Введите k2: ");
double b2 = ReadData("Введите b2: ");
double[] point = PointFind(k1, b1, k2, b2);
PrintResult("Точка пересечения двух прямых: ", $"({point[0]};{point[1]})");
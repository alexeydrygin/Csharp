// Задача №40
// Напишите программу, которая принимает на вход
// три числа и проверяет, может ли существовать
// треугольник с сторонами такой длины.

//Семинар с 0-19

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

//Вариант-1
// bool TrglTest(int a, int b, int c)
// {
//     return (a + b > c) && (a + c > b) && (b + c > a);
// }

//Вариант-2
bool TrglTest(int a, int b, int c)
{
    if ((a + b > c) && (a + c > b) && (b + c > a))
    {
        return true;
    }
    else
    {
        return false;
    }
}


int a = ReadData("Введите длину стороны a: ");
int b = ReadData("Введите длину стороны b: ");
int c = ReadData("Введите длину стороны c: ");

PrintResult(TrglTest(a, b, c) ? "Такой треугольник существует" : "Такой треугольник не существует");

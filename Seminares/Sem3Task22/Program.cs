// Напишите программу, которая принимает на вход число N и выдает таблицу квадратов чисел от 1 до N

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

//-----------------------------------------------

// // 1 2 3 4 5 6
// // 1 4 9 6 25 36

// //Метод вывода чисел по порядку до N
// string LineNumbers(int numberN)
// {
//     int i = 1;
//     string outLine = string.Empty;
//     while (i < numberN)
//     {
//         outLine = outLine + i + "\t"; // \t для табуляции вместо пробела
//         ++i;
//     }
//     outLine = outLine + numberN;

//     return outLine;
// }

// ////Метод вывода квадрата чисел по порядку до N
// string LineSqer(int numberN)
// {
//     int i = 1;
//     string outLine = string.Empty;
//     while (i < numberN)
//     {
//         outLine = outLine + i * i + "\t"; // \t для табуляции вместо пробела
//         ++i;
//     }
//     outLine = outLine + numberN * numberN;

//     return outLine;
// }

// //Метод вывода данных
// void PrintResult(string line)
// {
//     Console.WriteLine(line);
// }

// int num = ReadData("Введите число N: ");
// string lineTop = LineNumbers(num);
// string lineBottom = LineSqer(num);

// PrintResult(lineTop);
// PrintResult(lineBottom);

//-----------------------------------------------

//Метод вывода чисел по порядку до N
string LineNumbers(int numberN, int pow)
{
    int i = 1;
    string outLine = string.Empty;
    while (i < numberN)
    {
        outLine = outLine + Math.Pow(i, pow) + "\t"; // \t для табуляции вместо пробела
        ++i;
    }
    outLine = outLine + Math.Pow(numberN, pow);

    return outLine;
}

//Метод вывода данных
void PrintResult(string line)
{
    Console.WriteLine(line);
}

int num = ReadData("Введите число N: ");

PrintResult(LineNumbers(num, 1));
PrintResult(LineNumbers(num, 2));
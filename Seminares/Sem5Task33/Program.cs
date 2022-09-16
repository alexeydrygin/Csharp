// Задача №33
// Задайте массив. Напишите программу, которая
// определяет, присутствует ли заданное число в
// массиве.
// Например:
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да

//Метод считывания данных пользователя
int ReadData(string line)
{
    //Выводим сообщение
    Console.Write(line);
    //Считываем число
    int number = int.Parse(Console.ReadLine() ?? "0");
    //Возвращаем значение
    return number;
}

//Универсальный метод генерации и заполнения массива
int[] FillArray(int num, int downDorder, int topBorder)
{
    //Генератор случайных чисел
    Random numSintezator = new Random();
    //Создаем массив
    int[] arr = new int[num];
    //Тест границ массива
    if (downDorder < topBorder)
        //Заполняем массив
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = numSintezator.Next(downDorder, topBorder + 1);
        }
    //Возвращаем результат
    return arr;
}

//Печатаем одномерный массив
void Print1DArr(int[] arr)
{
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ", ");
    }
    Console.WriteLine(arr[arr.Length - 1]);
}

//Метод поиска элемента в массиве
bool FindElem(int[] arr, int elem)
{
    bool res = false;
    for (int i = 0; i < arr.Length - 1; i++)
    {
        if (arr[i] == elem)
        {
            res = true;
            break;
        }
    }
    return res;
}

//Метод вывода данных
void PrintResult(string line)
{
    Console.WriteLine(line);
}

int arrayLength = ReadData("Введите длину массива: ");
int downBorder = ReadData("Введите нижнюю границу массива: ");
int topBorder = ReadData("Введите верхнюю границу массива: ");
int num = ReadData("Введите число для проверки: ");

int[] arr = FillArray(arrayLength, downBorder, topBorder);
Print1DArr(arr);
PrintResult(num + " -> " + FindElem(arr, num));
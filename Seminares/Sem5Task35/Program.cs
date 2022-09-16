// Задача №35
// Задайте одномерный массив из 123 случайных
// чисел. Найдите количество элементов массива,
// значения которых лежат в отрезке [10,99].
// Например:
// Пример для массива из 5, а не 123 элементов. В
// своем решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

//семинар с 1-21

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
    Console.WriteLine("[{0}]", string.Join(", ", arr));
}

// {
//     for (int i = 0; i < arr.Length - 1; i++)
//     {
//         Console.Write(arr[i] + ", ");
//     }
//     Console.WriteLine(arr[arr.Length - 1]);
// }

//Метод вывода данных
void PrintResult(int line)
{
    Console.WriteLine(line);
}

//Метод подсчета элементов массива в заданном диапазоне индексов массива
int CountElem(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if ((arr[i] > 10) && (arr[i] < 99)) //Если элемент массива больше 10 И менише 99, то
            count++; //Счетчик count прибавляет единицу
    }
    return count;
}

// //Метод подсчета элементов массива в заданном диапазоне индексов массива через метод
// bool Test(int a)
// {
//     return (a > 10 && a < 99);//Если элемент массива больше 10 И менише 99
// }

// int CountElem(int[] arr)
// {
//     int count = 0;
//     for (int i = 0; i < arr.Length; i++)
//     {
//         if (Test(arr[i])) ; //Если элемент массива больше 10 И менише 99, то
//         count++; //Счетчик count прибавляет единицу
//     }
//     return count;
// }

int[] arr = FillArray(12, 1, 200);

Print1DArr(arr);
PrintResult(CountElem(arr));
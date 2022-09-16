// Задача №37
// Найдите произведение пар чисел в одномерном
// массиве. Парой считаем первый и последний
// элемент, второй и предпоследний и т.д. Результат
// запишите в новом массиве.
// Например:
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

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

//Считаем числа в массиве
int[] MultiTask(int[] arr)
{
    int[] arrMult = new int[arr.Length / 2];
    for (int i = 0; i < arr.Length / 2; i++)
    {
        arrMult[i] = arr[i] * arr[arr.Length - 1 - i];
    }
    return arrMult;
}

int[] arr = FillArray(21, 1, 10);

Print1DArr(arr);
Print1DArr(MultiTask(arr));
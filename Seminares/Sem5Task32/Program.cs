// Задача №32
// Напишите программу замена элементов массива:
// положительные элементы замените на
// соответствующие отрицательные, и наоборот.
// Пример:
// [-4, -8, 8, 2] -> [4, 8, -8, -2]

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

//Метод инверсии массива
int[] InversArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] *= -1;
        //arr[i] = arr[i] * (-1);
    }
    return arr;
}

int[] inputArray = FillArray(8, -9, 9);
Print1DArr(inputArray);

int[] invArray = InversArray(inputArray);
Print1DArr(invArray);
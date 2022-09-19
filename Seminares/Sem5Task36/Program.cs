// №36 Задайте одномерный массив, заполненный случайными числами. Найдите сумму
// элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [3, 7, -2, 1] -> 8
// [-4, -6, 89, 6] -> 0
// * Найдите все пары в массиве и выведите пользователю

Console.Clear();
Console.WriteLine($"Задача №36 Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.\n");

int[] numbers = new int[10];

//метод генерации и заполнения массива
void FillArray(int[] arr, int min, int max)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(min, max);

    }
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

//Метод определения суммы элементов на нечетных позициях
int SumElem(int[] arr)
{
    int sumElem = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (i % 2 != 1)
        {
            sumElem = sumElem + arr[i];
        }
    }
    return sumElem;
}

FillArray(numbers, 1, 100);
Print1DArr(numbers);
Console.WriteLine();

int sumElem = SumElem(numbers);
Console.WriteLine($"Cумма элементов, стоящих на нечётных позициях.: {sumElem}");
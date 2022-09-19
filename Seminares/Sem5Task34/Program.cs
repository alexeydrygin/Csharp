// №34 Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2
// [845, 222, 367, 123 -> 1
// * Отсортировать массив методом пузырька

// Семинар с 1-49

Console.Clear();
Console.WriteLine($"Задача 34. Количество чётных чисел в массиве:\n");
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

//Метод определения четных чисел в массиве
int EventCont(int[] arr)
{
    int quantity = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 1)
        {
            quantity++;
        }
    }
    return quantity;
}

FillArray(numbers, 1, 100);
Print1DArr(numbers);
Console.WriteLine();

int quantity = EventCont(numbers);
Console.WriteLine($"Количество чётных чисел в массиве: {quantity}");

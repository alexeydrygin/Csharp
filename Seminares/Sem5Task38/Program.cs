// // №38 Задайте массив вещественных чисел. Найдите разницу между максимальным и
// // минимальным элементов массива.
// // [3 7 22 2 78] -> 76
// // [2 0,4 9 7,2 78] -> 77,6
// // * Отсортируйте массив методом вставки и методом подсчета, а затем найдите
// // разницу между первым и последним элементом. Для задачи со звездочкой
// // использовать заполнение массива целыми числами.


Console.Clear();
Console.WriteLine($"Задача №38 Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.\n");

double[] numbers = new double[10];
double minNum = Int32.MaxValue;
double maxNum = Int32.MinValue;

//метод генерации и заполнения массива
void FillArray(double[] arr, int min, int max)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = Convert.ToDouble(new Random().Next(min * 100, max * 100)) / 100;
        if (arr[i] > maxNum)
        {
            maxNum = arr[i];
        }
        if (arr[i] < minNum)
        {
            minNum = arr[i];
        }
    }
}

//Печатаем одномерный массив
void Print1DArr(double[] arr)
{
    Console.WriteLine("[{0}]", string.Join(", ", arr));
}


FillArray(numbers, 1, 100);
Print1DArr(numbers);
Console.WriteLine();

Console.WriteLine($"Всего {numbers.Length} элементов массива. \nМаксимальное значение = {maxNum}, \nМинимальное значение = {minNum}");
Console.WriteLine($"Разница между максимальным и минимальным значением = {maxNum - minNum}");
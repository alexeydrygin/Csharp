// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]


// int[] array = new int[8];
// for (int i = 0; i < array.Length; i++)
// {
//     array[i] = new Random().Next(0, 101);
// }
// PrintArray(array);

// void PrintArray(int[] arr)
// {
//     string result = "[";
//     for (int i = 0; i < array.Length; i++)
//     {
//         string ch = ", ";
//         if (i == array.Length - 1)
//         {
//             ch = "]";
//         }
//         result += array[i] + ch;
//     }
//     Console.WriteLine("Вывод массива:  " + result);
// }

//Второй вариант от преподавателя
int[] array = new int[8];
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(0, 101);
}

void PrintArray(int[] arr)
{
    string result = "[";
    int i = 0;
    for (i = 0; i < array.Length - 1; i++)
    {
        result += array[i] + ", ";
    }
    result += array[i] + "]";
    Console.WriteLine("Вывод массива: " + result);
}

PrintArray(array);
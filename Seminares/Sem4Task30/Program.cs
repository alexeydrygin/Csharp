// Задача №30
// Напишите программу, которая выводит массив из 8
// элементов, заполненный нулями и единицами в
// случайном порядке.
// Например:
// [1,0,1,1,0,1,0,0]

// семинар с 1-34
//Решение с семинара не заработало, скопипастил другое решение

// //Генерируем массив
// int[] GenArray(int arrLen)
// {
//     int[] array = new int[arrLen];
//     Random ren = new Random();
//     for (int i = 0; i < arrLen; i++)
//     {
//         array[i] = ren.Next(0, 2);
//     }
//     return array;
// }

// //Печатаем массив
// void PrintArray(int[] array)
// {
//     for (int i = 0; i < Array.Length - 1; i++)
//     {
//         Console.Write(Array[i] + ", ");
//         Console.WriteLine(Array[Array.Length - 1]);
//     }
// }


// int n = 8;
// int[] array = new int[n];
// Random rand = new Random();
// for (int i = 0; i < array.Length; i++)
// {
//     array[i] = rand.Next(0, 2);
// }
// Console.WriteLine(string.Join(", ", array));
// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3


// Console.Write("Введите числа через запятую: ");
// int[] numbers = StringToNum(Console.ReadLine());
// PrintArray(numbers);
// int sum = 0;
// for (int i = 0; i < numbers.Length; i++)
// {
//     if (numbers[i] > 0)
//     {
//         sum++;
//     }
// }
// Console.WriteLine();
// Console.WriteLine($"количество значений больше 0 = {sum}");


// int[] StringToNum(string input)
// {
//     int count = 1;
//     for (int i = 0; i < input.Length; i++)
//     {
//         if (input[i] == ',')
//         {
//             count++;
//         }
//     }

//     int[] numbers = new int[count];
//     int index = 0;

//     for (int i = 0; i < input.Length; i++)
//     {
//         string temp = "";

//         while (input[i] != ',')
//         {
//             if (i != input.Length - 1)
//             {
//                 temp += input[i].ToString();
//                 i++;
//             }
//             else
//             {
//                 temp += input[i].ToString();
//                 break;
//             }
//         }
//         numbers[index] = Convert.ToInt32(temp);
//         index++;
//     }
//     return numbers;
// }

// //Печатаем одномерный массив
// void PrintArray(int[] arr)
// {
//     Console.WriteLine("[{0}]", string.Join(", ", arr));
// }

// Чтение данных из консоли
int ReadData(string line)
{
    // Выводим сообщение
    Console.Write(line);
    // Считываем число
    int number = int.Parse(Console.ReadLine() ?? "0");
    // Возвращаем значение
    return number;
}

// Печать результата
void PrintResult(string prefix, string data)
{
    Console.WriteLine(prefix + data);
}

// Считаем положительные числа
int Count(int m)
{
    int res = 0;
    for (int i = 0; i < m; i++)
    {
        int num = ReadData("Введите число: ");
        if (num > 0) res++;
    }

    return res;
}

PrintResult("Пользователь ввёл чисел больше ноля: ", Count(ReadData("Введите количество чисел: ")).ToString());
// код с использованием генератора случайных чисел и с использованием методов, затем описываем метод который выводит все элементы по порядку, затем превращаем код поиска нужного нам идекса в метод.

void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 10);
        //index = index + 1;
        index++;
    }
}

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}

int IndexOf(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = -1;

    while (index < count)
    {
        if (collection[index] == find)
        {
            position = index;
            break;
        }
        index++;
    }
    return position;
}

// new int[10] конструкция означает создай новый массив из 10 элементов
int[] array = new int[10];

FillArray(array);
PrintArray(array);
Console.WriteLine();

int pos = IndexOf(array, 46);
Console.WriteLine(pos);

if (pos == -1)
{
    Console.WriteLine("такой позиции нет");
}

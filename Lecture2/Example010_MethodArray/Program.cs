//поиск позиции нужного элемента в одномерном массиве

int[] array = { 16, 25, 37, 84, 95, 60, 97, 82 };

//получаем число элементов массива через array.Length
int n = array.Length;
//найти элемент массива равный find
int find = 84;

//установить счетчик index в позицию 0
int index = 0;

//устанавливаем цикл
while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }

    //index = index + 1; в короткой форме ниже
    index++;
}
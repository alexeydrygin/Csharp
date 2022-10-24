//Таблица умножения

Console.WriteLine("Введите количество цифр для перемножения");
int n = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[n, n];
for (int i = 1; i <= n; i++)
{
    for (int j = 1; j <= n; j++)
    {
        Console.Write(i * j);
        Console.Write("\t");
    }
    Console.WriteLine();
    Console.WriteLine();
}
void FillArray (int [] arr)
{
    int length = arr.Length;
    for (int i = 0; i < length; i++)
    {
        arr [i] = new Random().Next(-100, 100);
    }
}

void PrintArray (int [] arr)
{
    int length = arr.Length;
    for (int i = 0; i < length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
}

Console.Write("Введите длину массива length= ");
int length = Convert.ToInt32(Console.ReadLine());
int i = 0;
int sum = 0;

int[] array = new int[length];

FillArray(array);
PrintArray(array);
Console.WriteLine();
for (i = 0; i < array.Length; i++)
{
    if (i % 2 != 0)
    {
        sum = sum + array[i];
    }
}
Console.WriteLine($"Сумма элементов с нечетными индексами равна {sum}");
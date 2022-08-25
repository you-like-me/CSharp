void FillArray (double [] arr)
{
    int length = arr.Length;
    for (int i = 0; i < length; i++)
    {
        arr [i] = new Random().Next(-100, 100);
    }
}

void PrintArray (double [] arr)
{
    int length = arr.Length;
    for (int i = 0; i < length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
}

Console.Write("Введите длину массива length= ");
int length = Convert.ToInt32(Console.ReadLine());
double[] array = new double[length];
int i = 0;
double min = array[0];
double max = array[0];
double difference = 0;

FillArray(array);
PrintArray(array);
Console.WriteLine();

for (i = 0; i < array.Length; i++)
{
    if (array[i] > max)
    {
      max = array[i];
    }
    if (array[i] < min)
    {
      min = array[i];
    }
    difference = max - min;
}
Console.WriteLine($"Разница между максимальным и минимальным элементами массива равна {difference}");

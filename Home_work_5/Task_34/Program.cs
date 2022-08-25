Console.Write("Введите длину массива length= ");
int length = Convert.ToInt32(Console.ReadLine());

int i = 0;
int count = 0;
int[] array = new int[length];


void FillArray(int[] element)
{
    int length = element.Length;
    int index = 0;
    while (index < length)
    {
        element[index] = new Random().Next(100, 1000);
        index++;
    }
}

void PrintArray(int[] elem)
{
    int count = elem.Length;
    int position = 0;
    while (position < count)
    {
        Console.Write($"{elem[position]}" + ", ");
        position++;
    }
}

FillArray(array);
PrintArray(array);
for (i = 0; i < length; i++)
{
    if (array[i] % 2 == 0) 
    {
        count++;
    }
}

Console.WriteLine($"Количество четных элементов массива равно {count}");
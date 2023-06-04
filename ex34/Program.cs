int[] NewArray (int size, int minValue, int maxValue)
{
    int[] array = new int[size];
    for (int i = 0; i<size; i++)
    {
        array[i] = new Random().Next(minValue, maxValue+1);
    }
    return array;
}
Console.WriteLine("Введите размер массива");
int s = int.Parse(Console.ReadLine());

Console.WriteLine();

void PrintArray (int[] mas)
{
    for (int i = 0; i < s; i++)
    {
        Console.WriteLine(mas[i]);
    }
}

void FindChet (int[] array)
{
    int count = 0;
    foreach (int el in array)
    {
        if ((el % 2) == 0)
        {
            count++;
        }
    }
    Console.WriteLine ("Колличество четных элементов в массиве = " +count);
}

int[] massiv = NewArray(s, 100, 1000);
PrintArray(massiv);
FindChet(massiv);





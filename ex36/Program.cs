Console.WriteLine("Введите размер массива");
int s = int.Parse(Console.ReadLine());
Console.WriteLine("Введите минимальную границу диапазона");
int min = int.Parse(Console.ReadLine());
Console.WriteLine("Введите максимальную границу диапазона");
int max = int.Parse(Console.ReadLine());

int[] NewArray (int size, int minValue, int maxValue)
{
    int[] array = new int[size];
    for (int i = 0; i<size; i++)
    {
        array[i] = new Random().Next(minValue, maxValue+1);
    }
    return array;
}

void PrintArray (int[] mas)
{
    for (int i = 0; i < s; i++)
    {
        Console.WriteLine(mas[i]);
    }
}

void FindNechetSum (int[] array)
{
    int sumNechet = 0;
    for (int count = 0; count < s; count++)
    {
        if (count % 2 > 0)
        {
            sumNechet += array[count];
        } 
    }
    Console.WriteLine(sumNechet);
}


int[] massiv = NewArray(s, min, max+1);
PrintArray(massiv);
FindNechetSum(massiv);

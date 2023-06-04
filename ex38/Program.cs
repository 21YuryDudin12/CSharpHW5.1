//Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным элементов массива.
Console.WriteLine("Введите количество элементов массива:");
int size = int.Parse(Console.ReadLine());

Console.WriteLine("Введите нижнюю границу диапазона:");
double minValue = double.Parse(Console.ReadLine());

Console.WriteLine("Введите верхнюю границу диапазона:");
double maxValue = double.Parse(Console.ReadLine());

double[] array = new double[size];
Random random = new Random();

for (int i = 0; i < size; i++)
{
    double randomNumber = random.NextDouble() * (maxValue - minValue) + minValue;
    array[i] = Math.Round(randomNumber,2);
    Console.WriteLine(array[i]);
}

void FindDifference (double[] massiv)
{
double min = array[0];
double max = array[0];

for (int i = 0; i < size; i++)
{
    if (massiv[i] > max)
    {
        max = massiv[i];
    }
    if (massiv[i] < min)
    {
        min = massiv[i];
    }
}
Console.WriteLine(max - min);
}
Console.WriteLine("Разница между максимальным и минимальным значением массива равна: ");
FindDifference(array);
// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и 
// минимальным элементов массива.

Console.Clear();

double[] NewArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 101);
    }

    return array;
}

double FindMaxMinDif(double[] array)
{
    double max = 0, min = 101, diff = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] > max)
        {
            max = array[i];
        }
    }
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] < min)
        {
            min = array[i]; 
        }

    }
    diff = max - min;
    return diff;
}


Console.WriteLine("Введите желаемый размер массива?");
int size = int.Parse(Console.ReadLine());
double[] array = new double[size];
array = NewArray(array);
Console.WriteLine("Ваш случайный массив:");
Console.WriteLine("[" + string.Join(", ", array) + "]");

Console.WriteLine("Разница между максимальным и минимальным элементом: " + FindMaxMinDif(array));
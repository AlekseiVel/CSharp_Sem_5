// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

Console.Clear();

int[] NewArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100, 1000);
    }

    return array;
}

int CountOfEven(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            count++;
        }
    }
    return count;
}

Console.WriteLine("Введите желаемый размер массива?");
int size = int.Parse(Console.ReadLine());
int[] array = new int[size];
array = NewArray(array);
Console.WriteLine("Ваш случайный массив:");
Console.WriteLine("[" + string.Join(", ", array) + "]");

Console.WriteLine("Количество четных чисел: " + CountOfEven(array));
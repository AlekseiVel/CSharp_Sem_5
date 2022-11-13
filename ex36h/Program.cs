// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

Console.Clear();

int[] NewArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100, 1000);
    }

    return array;
}

int SummOfOddIndexes(int[] array)
{
    int sumOdd = 0;
    for (int i = 1; i < array.Length; i+=2)
    {
        sumOdd = sumOdd + array[i];
    }
    return sumOdd;
}

Console.WriteLine("Введите желаемый размер массива?");
int size = int.Parse(Console.ReadLine());
int[] array = new int[size];
array = NewArray(array);
Console.WriteLine("Ваш случайный массив:");
Console.WriteLine("[" + string.Join(", ", array) + "]");

Console.WriteLine("Сумма элементов, стоящих на нечётных позициях: " + SummOfOddIndexes(array));
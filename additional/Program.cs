// Дополнительно. Дан массив чисел. Напишите функцию, которая ищет 
// заданное число в массиве и показывает нужный индекс в нем. 
// При отсутствии числа возвращать -1.

Console.Clear();

int[] NewArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-10, 11);
    }

    return array;
}

string Search(int[] array, int number)
{
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] == number)
        return ("Ваше число есть в массиве! Его индекс: " + i);
    }
    return ("Вашего числа нет в массиве! Получите -1 =)");
}

Console.WriteLine("Введите желаемый размер массива?");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = new int[size]; 
array = NewArray(array);
Console.WriteLine("Ваш случайный массив:");
Console.WriteLine("[" + string.Join(", ", array) + "]");

Console.WriteLine("Какое число нужно найти?");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Search(array, number));
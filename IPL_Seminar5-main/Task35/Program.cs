// Задача 35: Задайте одномерный массив из 123 случайных чисел.
// Найдите количество элементов массива, значения которых лежат в
// отрезке [10,99].
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для
// 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5


System.Console.Write("Введите значение размера массива: ");
int sizeArray = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите начальное значение диапазона заполнения массива: ");
int minRangeArray = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите конечное значение диапазона заполнения массива: ");
int maxRangeArray = Convert.ToInt32(Console.ReadLine());

int[] FillArray(int size, int min, int max)
{
    Random rnd = new Random();
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.Next(min, max + 1);
    }
    return array;
}

void PrintArray(int[] array)
{
    System.Console.Write("[");
    for (int i = 0; i < array.Length; i++) 
    {
        if(i == array.Length-1) Console.Write($"{array[i]}");
        else Console.Write($"{array[i]},");
    }
    System.Console.Write("]");
}

int[] array = FillArray(sizeArray, minRangeArray, maxRangeArray);
PrintArray(array);

int FindNum(int[] array, int minRangeSearch , int maxRangeSearch )
{
    int result = default;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 10 && array[i] < 100)
        {
            result ++;
        }
    }
    return result;
}

int resultSearch = FindNum(array, 10, 100);

System.Console.WriteLine($" => {resultSearch}");
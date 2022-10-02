// Задача 37: Найдите произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и предпоследний
// и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

System.Console.Write("Введите значение размера массива: ");
int sizeArray = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите начальное значение диапазона заполнения массива: ");
int minRangeArray = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите конечное значение диапазона заполнения массива: ");
int maxRangeArray = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите искомое число: ");

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

int[] MultipleArrayElements(int[] array)
{
    int LengthNewArray = array.Length / 2;
    if(array.Length % 2 != 0) LengthNewArray++;

    int[] result = new int[LengthNewArray];

    for (int i = 0; i < LengthNewArray; i++)
    {
        result[i] = array[i] * array[array.Length - i - 1];
    }

    if (array.Length % 2 != 0)
    {
        result[LengthNewArray-1] = array[array.Length / 2];
    }
    return result;
}

System.Console.Write(" => ");

int[] newArray = MultipleArrayElements(array);
PrintArray(newArray);

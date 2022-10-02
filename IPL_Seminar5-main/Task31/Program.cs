// Задача 31: Задайте массив из 12 элементов, заполненный
// случайными числами из промежутка [-9, 9]. Найдите сумму
// отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма
// положительных чисел равна 29, сумма отрицательных равна
// -20.


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
    System.Console.WriteLine("]");
}

int[] array = FillArray(sizeArray, minRangeArray, maxRangeArray);
PrintArray(array);

int[] FindSumPositiveNegativeElements(int[] array)
{
    int sumPositive = default;
    int sumNegative = default;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] > 0) sumPositive += array[i];
        else sumNegative += array[i];
    }
    return new int[]{sumNegative, sumPositive};
}

int FindSumPositiveElements (int[] array)
{
    int sumPositive = default;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] > 0) sumPositive += array[i];
    }
    return sumPositive;
}

int FindSumNegativeElements (int[] array)
{
    int sumNegative = default;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] < 0) sumNegative += array[i];
    }
    return sumNegative;
}

int[] sumElements = FindSumPositiveNegativeElements(array);

int sumPos = FindSumPositiveElements(array);

int sumNeg = FindSumNegativeElements(array);

PrintArray(sumElements);
System.Console.WriteLine($" сумма положительных элементов равна {sumPos};");
System.Console.WriteLine($" сумма отрицательных элементов равна {sumNeg};");
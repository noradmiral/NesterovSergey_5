// Задача 33: Задайте массив. Напишите программу, которая
// определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// 3; массив [6, 7, 19, 345, 3] -> да


System.Console.Write("Введите значение размера массива: ");
int sizeArray = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите начальное значение диапазона заполнения массива: ");
int minRangeArray = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите конечное значение диапазона заполнения массива: ");
int maxRangeArray = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите искомое число: ");
int desiredNumber = Convert.ToInt32(Console.ReadLine());

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
        else Console.Write($"{array[i]}, ");
    }
    System.Console.Write("]");
}

int[] array = FillArray(sizeArray, minRangeArray, maxRangeArray);

bool FindNumber(int[] array, int desiredNum)
{
    bool result = false;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == desiredNum)
        {
            result = true;
            break;
        }
    }
    return result;
}

System.Console.Write($"{desiredNumber}; массив ");
PrintArray(array);

if (FindNumber(array, desiredNumber)) System.Console.WriteLine($"=> да");
else System.Console.WriteLine($"=> нет");
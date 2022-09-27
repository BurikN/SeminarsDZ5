//Задача 34
/*
int[] FillArray(int size)
{
    int[] num = new int[size];

    for (int i = 0; i < num.Length;i++)
    {
        num[i] = new Random().Next(100, 1000);
    }

    return num;
}

int CountMulti(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++ )
    {
        if (array[i] % 2 == 0)
        {
            count+=1;
        }
    }
    return count;
}

int DataEntry(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
} 

int size = 10;
int[] num = FillArray(size);
Console.WriteLine("[{0}]", string.Join(",", num));
Console.WriteLine($"В массиве {CountMulti(num)} чисел кратных {2}");
*/
//Задача 36
/*
void FillArray(int[] array,int size)
{
    for (int i = 0; i < size;i++)
    {
        array[i] = new Random().Next(-99, 100);
    }
}

int DataEntry(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
} 

int SumN(int[] array)
{
    int result = 0;
    for (int i = 0;i < array.Length;i +=2)
    {
        result += array[i];
    }
    return result;
}

int size = DataEntry("Введите размер массива:");
int[] num = new int[size];
FillArray(num, size);
Console.Write("[{0}]", string.Join(",", num));
Console.WriteLine();
Console.WriteLine($"Сумма нечетных элементов массива равна= {SumN(num)}");
*/
//Задача 38
int DataEntry(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
} 

void FillArray(double[] array)
{
    for (int i = 0; i < array.Length;i++)
    {
        array[i] = new Random().Next(-99, 100);
    }
}

double DiffMaxMin(double[] array)
{
    double max = array[0];
    double min = array[0];
    for (int i = 1;i < array.Length;i++)
    {
        if(array[i] > max)
        {
            max = array[i];
        }
        if(array[i] < min)
        {
            min = array[i];
        }
    }
    return max-min;
}

int size = DataEntry("Введите размер массива:");
double[] num = new double[size];
FillArray(num);
Console.Write("[{0}]", string.Join(",", num));
Console.WriteLine();
Console.WriteLine($"Разница между максимальным и минимальным значением равна:{DiffMaxMin(num)}");



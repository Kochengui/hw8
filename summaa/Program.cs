Console.WriteLine($"Введите размер массива m , n :");
int m = Numbers("Введите m: ");
int n = Numbers("Введите n: ");
int range = Numbers("Введите диапазон: от 1 до ");

int[,] array = new int[m, n];
FillArray(array);
PrintArray(array);

int minSum = 0;
int sum = SumElement(array, 0);
for (int i = 1; i < array.GetLength(0); i++)
{
    int blockSum = SumElement(array, i);
    if (sum > blockSum)
    {
        sum = blockSum;
        minSum = i;
    }
}

Console.WriteLine($"{minSum + 1} -  наименьшая сумма ({sum}) элементов ");

int SumElement(int[,] array, int i)
{
    int sum = array[i, 0];
    for (int j = 1; j < array.GetLength(1); j++)
    {
        sum += array[i, j];
    }
    return sum;
}

int Numbers(string input)
{
    Console.Write(input);
    int output = Convert.ToInt32(Console.ReadLine());
    return output;
}

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(range);
        }
    }
}
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}















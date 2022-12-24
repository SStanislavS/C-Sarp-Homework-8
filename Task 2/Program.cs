// Программа, которая будет находить строку с наименьшей суммой элементов в прямоугольном двумерном массиве.
Console.Write("Введите количество строк: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int column = Convert.ToInt32(Console.ReadLine());
int[,] numbers = new int[row, column];
FillArrayRandomNumbers(numbers);
Console.WriteLine("Исходный массив: ");
PrintArray(numbers);

int index = 0, minSum = 0;
for (int i = 0; i < numbers.GetLength(0); i++)
{
    int sum = 0;
    for (int j = 0; j < numbers.GetLength(1); j++)
    {
        sum += numbers[i, j];
    }
    Console.WriteLine($"Сумма {i + 1} строки = {sum}");
    if (i == 0)
    {
        minSum = sum;
    }
    else if (sum < minSum)
    {
        minSum = sum;
        index = i;
        index++;
    }
}
string line = string.Empty;
for (int j = 0; j < numbers.GetLength(1); j++)
{
    line += numbers[index, j] + " ";
}

Console.WriteLine($"Строка с наименьшей суммой элементов: {index} строка");

void FillArrayRandomNumbers(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(0, 10);
        }
    }
}

void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i, j] + " ");
        }
        Console.Write("]");
        Console.WriteLine("");
    }
}


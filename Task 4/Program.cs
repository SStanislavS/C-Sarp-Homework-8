// Сформируйте двухмерный массив из неповторяющихся случайных двузначных чисел. 
// Напишите программу, которая будет выводить полученный массив. 
Console.Write("Введите количество строк: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int column = Convert.ToInt32(Console.ReadLine());
int[,] numbers = new int[row, column];
FillArrayRandomNumbers(numbers);
Console.WriteLine("Массив из неповторяющихся чисел: ");
PrintArray(numbers);

bool Contains( int [,] array1, int elem)
{
    for (int i = 0; i < array1.GetLength(0); i++)
    {
        for (int j = 0; j < array1.GetLength(1) - 1; j++)
        {
            if (array1[i, j] == elem)
            {
                return true;
            }
        }
    }
    return false;
}

void FillArrayRandomNumbers(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(10, 100);
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
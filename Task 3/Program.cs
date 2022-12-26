// Задайте две квадратные матрицы одинакового размера. Программа, которая находит произведение двух матриц.
Console.Write("Введите количество строк 1-ой матрицы: ");
int row1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов 1-ой матрицы: ");
int column1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество строк 2-ой матрицы: ");
int row2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов 2-ой матрицы: ");
int column2 = Convert.ToInt32(Console.ReadLine());

int[,] Matrix1 = new int[row1, column1];
FillArrayRandomNumbers(Matrix1);
Console.WriteLine("Первая матрица: ");
PrintArray(Matrix1);

int[,] Matrix2 = new int[row2, column2];
FillArrayRandomNumbers(Matrix2);
Console.WriteLine("Вторая матрица: ");
PrintArray(Matrix2);

int[,] Matrix3 = new int[row1, column2];
Console.WriteLine("Произведение первой и второй матрицы: ");
PrintArray(Matrix3);

{
    for (int i = 0; i < Matrix1.GetLength(0); i++)
    {
        for (int j = 0; j < Matrix2.GetLength(1); j++)
        {
            Matrix3 [i, j] = 0;
            for (int k = 0; k < Matrix2.GetLength(1); k++)
            {
                Matrix3 [i, j] += Matrix1[i, k] * Matrix2[k, j];
            }
        }
    }
}

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

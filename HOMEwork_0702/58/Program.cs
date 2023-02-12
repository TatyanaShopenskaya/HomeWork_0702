// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3

// Результирующая матрица будет:
// 18 20
// 15 18


Console.WriteLine("Введите количество строк первой матрицы");
int rows1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов первой матрицы");
int columns1 = Convert.ToInt32(Console.ReadLine());
int rows2 = columns1;        //кол-во строк 2 матрицы должны быть равно кол-ву столбцов 1 матрицы
Console.WriteLine("Введите количество столбцов второй матрицы");
int columns2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
int[,] array2D1 = CreateMatrixRndInt1(rows1, columns1, 1, 9);
int[,] array2D2 = CreateMatrixRndInt2(rows2, columns2, 1, 9);
PrintMatrix(array2D1);
Console.WriteLine("------------");
PrintMatrix(array2D2);
Console.WriteLine();
Console.WriteLine("------------");
Console.WriteLine();


//создаем первую матрицу
int[,] CreateMatrixRndInt1(int rows1, int columns1, int min, int max)
{
    int[,] matrix = new int[rows1, columns1];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);

        }
    }
    return matrix;
}


//создаем вторую матрицу
int[,] CreateMatrixRndInt2(int columns1, int columns2, int min, int max)
{
    int[,] matrix = new int[rows2, columns2];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);

        }
    }
    return matrix;
}


//выводим на печать матрицу
void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],4}");
            else Console.WriteLine($"{matrix[i, j],4}");
        }
    }
}

int[,] newArray2D = new int[rows1, columns2];      //задаем матрицу произведений

//метод для нахождения произведения заданных матриц
void ProductOfMatrices(int[,] array2D1, int[,] array2D2, int[,] newArray2D)
{
    for (int i = 0; i < array2D1.GetLength(0); i++)
    {
        for (int j = 0; j < array2D1.GetLength(1); j++)
        {
            int result = 0;
            for (int b = 0; b < array2D1.GetLength(1); b++)     //с помощью b проходимся по столбцам новой матрицы
            {
                result = result + array2D1[i, b] * array2D2[b, j];
            }      
            newArray2D [i,j]=result;
        }
    }
}

ProductOfMatrices(array2D1, array2D2, newArray2D);
PrintMatrix(newArray2D);
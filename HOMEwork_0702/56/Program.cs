//  Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка


Console.WriteLine("Введите количество строк двумерного массива");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов двумерного массива");
int columns = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
int[,] array2D = CreateMatrixRndInt(rows, columns, 1, 9);
PrintMatrix(array2D);
Console.WriteLine();
MinSumInRows(array2D);


//создаем двумерный массив
int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
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


//выводим на печать двумерный массив
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


// создаем метод для поиска номера СТРОКИ с минимальной суммой элементов
void MinSumInRows(int[,] array2D)
{
    int minSum = 0;
    int index = 0;
    for (int i = 0; i < array2D.GetLength(0); i++) //проходимся по строкам
    {
        int sum = 0;
        for (int j = 0; j < array2D.GetLength(1); j++)  //проходимся по столбцам
        {
            sum = sum + array2D[i, j];                      //вычисляем сумму в каждой строке
        }
        Console.WriteLine($"Сумма {i + 1} строки = {sum}");
        if (i==0) minSum=sum;
        else if(sum < minSum)
        {
            minSum = sum;                    //отбор самой маленькой суммы
            index = i;
        }
    }
    Console.WriteLine($"Строка с минимальной суммой = {index + 1}");
}

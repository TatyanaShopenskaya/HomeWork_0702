// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2


Console.WriteLine("Введите количество строк двумерного массива");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов двумерного массива");
int columns = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
int[,] array2D = CreateMatrixRndInt(rows, columns, 1, 9);
PrintMatrix(array2D);
Console.WriteLine();
ReplaceNumbersInRows(array2D);   //вызвали метод сортировки
PrintMatrix(array2D);            //напечатали измененный массив


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


//создаем метод для сортировки элементов в строках массива
void ReplaceNumbersInRows(int[,] array2D)
{
    for (int i = 0; i < array2D.GetLength(0); i++)       //проходимся по строкам
    {
        for (int j = 0; j < array2D.GetLength(1); j++)   //проходимся по столбцам
        {
            for (int b = 0; b < array2D.GetLength(1) - 1; b++) //вводим b-обозначение столбца, в котором будем сортировать
            {
                if (array2D[i, b + 1] > array2D[i, b])
                {
                    int tmp = array2D[i, b + 1];       //вводим временную переменную tmp и кладем туда большее значение из сравниваемых
                    array2D[i, b + 1] = array2D[i, b]; //кладем самое большое значение в первый элемент строки
                    array2D[i, b] = tmp;               //меньшее значение перемещаем в tmp
                }
            }
        }
    }
}



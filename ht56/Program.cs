// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Console.WriteLine("Ввведите кол-во строк:");
int line = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ввведите кол-во столбцов:");
int col = Convert.ToInt32(Console.ReadLine());

int[,] FillMatrix(int rows,int columns)
{
int [,] matrix = new int [rows,columns];
    for(int i = 0;i<matrix.GetLength(0);i++)
    {
        for(int j = 0; j<matrix.GetLength(1);j++)
        {
        matrix[i,j] = new Random().Next(1,10);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
for(int i = 0;i<matrix.GetLength(0);i++)
{
    for(int j = 0; j<matrix.GetLength(1);j++)
    {
        Console.Write(matrix[i,j]+" ");
    }
    Console.WriteLine();
}
}
int [,] matrix = FillMatrix(line,col);
PrintMatrix(matrix);
Console.WriteLine();

int [] array = new int [matrix.GetLength(0)];
int sum = 0;
for(int i = 0;i<matrix.GetLength(0);i++)
{
    for(int j = 0; j<matrix.GetLength(1);j++)
    {
        sum = sum + matrix[i,j];
        array[i] = sum;
    }
    sum = 0;
    Console.WriteLine($"Сумма строки {i+1}: "+array[i]+" ");
}

Console.WriteLine();

int index =0;
for (int k = 0; k<array.Length;k++)
{
    int min = array[0];
    if (array[k]<min)  
    {
    min = array[k];
    index = k;
    }

}
Console.WriteLine($"Строка с наименьшей суммой элементов {index+1}");
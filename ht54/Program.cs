// Задайте двумерный массив. Напишите программу, которая 
// упорядочит по убыванию элементы каждой строки двумерного массива.

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

for(int i = 0;i<matrix.GetLength(0);i++)
{
    for(int j = 0; j<matrix.GetLength(1);j++)
    {
        for (int k = j+1; k<matrix.GetLength(1);k++ )
        {
            if (matrix[i,j] < matrix[i,k])
            {
            int temporary = matrix[i,j];
            matrix[i,j] = matrix[i,k];
            matrix[i,k] = temporary;
            }
        }
    }
}
PrintMatrix(matrix);
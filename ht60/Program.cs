// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, 
// которая будет построчно выводить массив, добавляя индексы каждого элемента

Console.WriteLine("Ввведите длину матрицы:");
int line = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ввведите ширину матрицы:");
int col = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ввведите глубину матрицы:");
int depth = Convert.ToInt32(Console.ReadLine());

int[,,] FillMatrix(int rows,int columns,int dep)
{
int [,,] matrix = new int [rows,columns,dep];
    for(int i = 0;i<matrix.GetLength(0);i++)
    {
        for(int j = 0; j<matrix.GetLength(1);j++)
        {
            for(int k = 0; k<matrix.GetLength(2);k++)
            {
                matrix[i,j,k] = new Random().Next(1,10);
            }
        }
    }
    return matrix;
}

void PrintMatrix(int[,,] matrix)
{
for(int i = 0;i<matrix.GetLength(0);i++)
{
    for(int j = 0; j<matrix.GetLength(1);j++)
    {
        for(int k = 0; k<matrix.GetLength(2);k++)
        {
         Console.Write($"{matrix[i,j,k]}({i},{j},{k}) ");
        }
    Console.WriteLine();
    }
}
}
int [,,] matrix = FillMatrix(line,col,depth);
PrintMatrix(matrix);
Console.WriteLine();

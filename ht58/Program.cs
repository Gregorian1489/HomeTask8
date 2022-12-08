// SЗадайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Console.WriteLine("Ввведите кол-во строк первой матрицы:");
int line = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ввведите кол-во столбцов первой матрицы:");
int col = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ввведите кол-во строк второй матрицы:");
int lineSecond = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ввведите кол-во столбцов второй матрицы:");
int colSecond = Convert.ToInt32(Console.ReadLine());

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
int [,] matrixSecond = FillMatrix(lineSecond,colSecond);
PrintMatrix(matrix);
Console.WriteLine();
PrintMatrix(matrixSecond);
Console.WriteLine();
if (col != lineSecond)
{
    Console.WriteLine("Произведения матриц не существует, т.к. число столбцов 1й матрицы не равно кол-ву строк 2й");
}
else if (line==colSecond)
{
Console.WriteLine("Искомая матрица:");
int [,] matrixResult = new int[line,colSecond];
int num = 0;
for(int i = 0;i < line;i++)
    {
        for(int j = 0; j < colSecond;j++)
        {
            for (int k = 0; k<line;k++)
            {
                num = num + matrix[i,0+k]*matrixSecond[0+k,0+j];
            }
            matrixResult[i,j] = num;
            Console.Write(matrixResult[i,j] + " ");
            num = 0;
        }
        Console.WriteLine();
    }
}
else if (line!=colSecond)
{
Console.WriteLine("Искомая матрица:");
int [,] matrixResult = new int[line,colSecond];
int num = 0;
for(int i = 0;i < line;i++)
    {
        for(int j = 0; j < colSecond;j++)
        {
            for (int k = 0; k<=line;k++)
            {
                num = num + matrix[i,0+k]*matrixSecond[0+k,0+j];
            }
            matrixResult[i,j] = num;
            Console.Write(matrixResult[i,j] + " ");
            num = 0;
        }
        Console.WriteLine();
    }
}

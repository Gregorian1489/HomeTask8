// Напишите программу, которая заполнит спирально массив 4 на 4.

int count = 0;
int [,] matrix = new int [4,4];
    for(int j = 0;j<matrix.GetLength(0);j++)
    {
        int i = 0;
        count++;
        matrix[i,j] = count;
    }
    count = count +1;
    for(int i = 1;i<matrix.GetLength(0);i++)
    {
        int j = 3;
        matrix[i,j] = count++;
    }
    for(int j = 2;j>=0;j--)
    {
        int i = 3;
        matrix[i,j] = count++;
    }
    for(int i = 2;i>=1;i--)
    {
        int j = 0;
        matrix[i,j] = count+1;
    }
    for(int i = 2;i>=1;i--)
    {
        int j = 0;
        matrix[i,j] = count++;
    }
    for(int j = 1;j<=2;j++)
    {
        int i = 1;
        matrix[i,j] = count++;
    }
    for(int j = 2;j>=1;j--)
    {
        int i = 2;
        matrix[i,j] = count++;
    }





void PrintMatrix(int[,] matrix)
{
for(int i = 0;i<matrix.GetLength(0);i++)
{
    for(int j = 0; j<matrix.GetLength(1);j++)
    {
        if (matrix[i,j]<10)
        {
            Console.Write("0"+matrix[i,j]+" ");
        }
        else
        {
        Console.Write(matrix[i,j]+" ");
        }
    }
    Console.WriteLine();
}
}
PrintMatrix(matrix);

// Три дня пытался вывести алгоритм для спирального заполнения любой матрицы
// Не хватает времени, декабрь... Понятно, что этот метод заполнения ужасен,
// подскажите пожалуйста, как сделать лучше. Спасибо!
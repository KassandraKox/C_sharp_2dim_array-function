// Задайте две квадратные матрицы одного размера. Напишите программу, которая будет
// находить произведение двух матриц.
//Например, даны 2 матрицы:
//2 4 | 3 4
//3 2 | 3 3
//Результирующая матрица будет:
//18 20
//15 18

// 0. 
int start = 1;
int stop = 10;

// 1. Матрица А
Console.WriteLine("Сформируем матрицу A:");

Console.WriteLine("Введи количество строк: *рекомендую 2");
int linesCountA = int.Parse(Console.ReadLine());
Console.WriteLine("Введи количество столбцов: *рекомендую 3");
int columnsCountA = int.Parse(Console.ReadLine());

int [,] twoDimArrayA = new int[linesCountA, columnsCountA];
Random rnd = new Random();

for (int i=0; i<linesCountA; i++)
{
    for (int j=0; j<columnsCountA; j++)
    {
        twoDimArrayA[i,j] = rnd.Next(start, stop);
        Console.Write(twoDimArrayA[i,j] + " ");
    }
    Console.WriteLine();
}

// 2. Матрица B
Console.WriteLine("Сформируем матрицу B:");

Console.WriteLine($"Количество строк: {columnsCountA}");
int linesCountB = columnsCountA;
Console.WriteLine("Введи количество столбцов: *рекомендую 3");
int columnsCountB = int.Parse(Console.ReadLine());

int [,] twoDimArrayB = new int[linesCountB, columnsCountB];
Random rand = new Random();

for (int i=0; i<linesCountB; i++)
{
    for (int j=0; j<columnsCountB; j++)
    {
        twoDimArrayB[i,j] = rand.Next(start, stop);
        Console.Write(twoDimArrayB[i,j] + " ");
    }
    Console.WriteLine();
}

// 3. Создать матрицу C
int [,] twoDimArrayC = new int[linesCountA, columnsCountB];

// 4. Заполнить матрицу C
Console.WriteLine("Матрица С:");
for (int i=0; i<linesCountA; i++)
{
    for (int j=0; j<columnsCountB; j++)
    {
        int product = 0;
        for (int k=0; k<linesCountB; k++)
        {
            product += twoDimArrayA[i,k] * twoDimArrayB[k,j];
        }
        twoDimArrayC[i,j] = product;
        Console.Write(twoDimArrayC[i,j]);
        Console.Write(" ");
    }
    Console.WriteLine();
}
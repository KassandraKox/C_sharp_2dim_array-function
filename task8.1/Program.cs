//Задайте двум. массив. Напишите прог, кот. будет находить строку с min суммой элементов.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//5 2 6 7
//Номер строки с наименьшей суммой элементов: 1 строка
//(допускается указывать индекс строки в массиве, в данном примере - 0)

// 1. Создать двумерный массив.
Console.WriteLine("Введи количество строк:");
int linesCount = int.Parse(Console.ReadLine());
Console.WriteLine("Введи количество столбцов:");
int columnsCount = int.Parse(Console.ReadLine());

int [,] twoDimArray = new int[linesCount, columnsCount];
Random rnd = new Random();

for (int i=0; i<linesCount; i++)
{
    for (int j=0; j<columnsCount; j++)
    {
        twoDimArray[i,j] = rnd.Next(1, 100);
        Console.Write(twoDimArray[i,j] + " ");
    }
    Console.WriteLine();
}

// 2. Посчитать сумму по каждой строке.
int [] totalArray = new int [linesCount];  // однострочный массив
for (int i=0; i<linesCount; i++)
{
    int total = 0;
    for (int j=0; j<columnsCount; j++)
    {
        total += twoDimArray[i,j];
    }
    totalArray[i] = total;
}

// 3. Внести каждую сумму в однострочный массив.
Console.WriteLine(string.Join(", ", totalArray)); // вывод массива

// 4. Найти минимальное число в массиве.
int min = 100 * columnsCount; //                   n раз по 100 макс число
int line = 0;
for (int i=0; i<linesCount; i++)
{
    if (totalArray[i] < min)
    {
        min = totalArray[i];
        line = i+1;
    }  
}

// 5. Вывод минимальной строки.
Console.WriteLine($"Номер строки с наименьшей суммой элементов: {line} строка"); // вывод массива

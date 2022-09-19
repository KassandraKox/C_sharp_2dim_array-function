// Задача 3. Сформируйте двухмерный массив из неповторяющихся двузначных чисел (размер массива
// не более 50 элементов). Напишите программу, которая будет построчно выводить массив.
// Вариант создания функции:
// Проверить число на присутствие в массиве (bool Contains(int[,] arr, int value){...} )
// Пример:
// Массив размером 3 x 3
// 10 11 55
// 33 41 23
// 17 28 34

// 1. Создать 2мерный массив.
Console.WriteLine("Введи количество строк: *рекомендую 3");
int linesCount = int.Parse(Console.ReadLine());
Console.WriteLine("Введи количество столбцов: *рекомендую 3");
int columnsCount = int.Parse(Console.ReadLine());
int volume = linesCount * columnsCount;
Console.WriteLine(volume);
if (volume <= 50)
{
    int start = 10;
    int stop = 100;

    int [,] twoDimArray = new int[linesCount, columnsCount];

    // 2. Заполнять рандомными двузначными числами.
    Random rnd = new Random();
    for (int i=0; i<linesCount; i++)
    {
        for (int j=0; j<columnsCount; j++)
        {
            int[] temp = new int[volume];
            // 3. Проверять рандомное число на уникальность.
            int  number;
            for (int k = 0; k < volume; k++)
            {
                temp[k] = new Random().Next(start, stop);
                number = temp[k];
                if (k >= 1)
                {
                    for (int m = 0; m < k; m++)
                    {
                        while (temp[k] == temp[m])
                        {
                            temp[k] = new Random().Next(start, stop);
                            m = 0;
                            number = temp[k];
                        }
                        number = temp[k]; 
                    }
                }
            }
            // 4. вывести массив.
            int count = 0; 
            for (int x = 0; x < linesCount; x++)
            {
                for (int y = 0; y < columnsCount; y++)
                {
                    twoDimArray[i,j] = temp[count];
                    Console.Write(twoDimArray[i,j] + " ");
                    count++;
                }
                Console.WriteLine();
            }
        }
    }
}
else
{
    Console.WriteLine("Размер массива должен быть не более 50 элементов.");
}

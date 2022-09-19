// Задача 3. Сформируйте двухмерный массив из неповторяющихся двузначных чисел (размер массива
// не более 50 элементов). Напишите программу, которая будет построчно выводить массив.
// Вариант создания функции:
// Проверить число на присутствие в массиве (bool Contains(int[,] arr, int value){...} )
// Пример:
// Массив размером 3 x 3
// 10 11 55
// 33 41 23
// 17 28 34

// 1. Функция на проверку присутствия числа в массиве.
bool Contains(int[] arr, int value)
{
    for (int i = 0; i<arr.Length; i++)
    {
        if (arr[i] == value)
        {
            return true;
        }
    }
    return false;
}

// 2. Создать 2мерный массив.
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
    int[] temp = new int[volume];

    // 3. Генерируем 1мерный массив уникальных значений.
    for (int k=0; k<volume; k++)
    {
        int rand = new Random().Next(start, stop);
        // 4. Если уникальное значение уже есть в 1мерном массиве, генерируем новое.
        while (Contains(temp, rand))
        {
            rand = new Random().Next(start, stop);
        }
        // 5. Поместить уникальное значение в 1мерный массив.
        temp[k] = rand;
    }

    int count = 0;
    // 6. Заполнить 2мерный массив ранее сгенерированными числами из 1мерного массива.
    for (int i=0; i<linesCount; i++)
    {
        for (int j=0; j<columnsCount; j++)
        {
            twoDimArray[i, j] = temp[count];
            count++;
        }
                
    }
    // 7. вывести массив.
    for (int x = 0; x < linesCount; x++)
        {
        for (int y = 0; y < columnsCount; y++)
            {
                Console.Write(twoDimArray[x, y] + " ");
            }
        Console.WriteLine();
    }
}        
else
{
    Console.WriteLine("Размер массива должен быть не более 50 элементов.");
}


    
    
    
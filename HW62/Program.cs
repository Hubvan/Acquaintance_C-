// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.     
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07


int[,] array = new int[4, 4];

int rowStart = 0;
int rowEnd = array.GetLength(0) - 1;
int colStart = 0;
int colEnd = array.GetLength(1) - 1;
int num = 1;

while (rowStart <= rowEnd && colStart <= colEnd)
{
    for (int i = colStart; i <= colEnd; i++)
    {
        array[rowStart, i] = num++;
    }

    for (int i = rowStart + 1; i <= rowEnd; i++)
    {
        array[i, colEnd] = num++;
    }

    if (rowStart < rowEnd && colStart < colEnd)
    {
        for (int i = colEnd - 1; i > colStart; i--)
        {
            array[rowEnd, i] = num++;
        }

        for (int i = rowEnd; i > rowStart; i--)
        {
            array[i, colStart] = num++;
        }
    }

    rowStart++;
    rowEnd--;
    colStart++;
    colEnd--;
}

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        Console.Write(array[i, j].ToString("D2") + " ");
    }
    Console.WriteLine();
}
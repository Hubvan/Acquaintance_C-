// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

int ReadInt(string arg)
{
    Console.Write($"Input {arg}: ");
    int result = 0;

    while (!int.TryParse(Console.ReadLine(), out result))
    {
        Console.Write("Try again! ");
    }

    return result;
}

int[,] CreateTwoDimensionArray(int firstLength, int secondLength)
{
    int[,] result = new int[firstLength, secondLength];
    Random rand = new Random();

    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            result[i, j] = rand.Next(0, 10);
        }
    }

    return result;
}

string TwoDimensionArrayToString(int[,] array)
{
    string result = string.Empty;

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            result += $"{array[i, j]} ";
        }

        result += Environment.NewLine;
    }

    return result;
}

int[,] array = CreateTwoDimensionArray(ReadInt("First Length"), ReadInt("Second Length"));
Console.WriteLine(TwoDimensionArrayToString(array));
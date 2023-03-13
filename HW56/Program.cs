// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
//Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

Console.Clear();
Console.WriteLine("Введите размер двумерного прмоугольного массива размером m x n, введите диапазон случайных чисел от и до ");
Console.WriteLine();
int m = ReadInt("кол-во строк - m");
int n = ReadInt("кол-во столбцов - n");
int rangeFrom = ReadInt("диапазон от ");
int rangeTo = ReadInt("диапазон до ");

int[,] firstArray = new int[m, n];
CreateArray(firstArray);
Console.WriteLine($"\nЗадан массив: ");
PrintArray(firstArray);
FindRowSumMinElements(firstArray);


void FindRowSumMinElements(int[,] firstArray)             // Модуль поиска строки с минимальной суммой значений элементов 
{
  int minRow = 0;
  int minSumRow = 0;
  int sumRow = 0;
  for (int i = 0; i < firstArray.GetLength(1); i++)
  {
    minRow += firstArray[0, i];
  }
  for (int i = 0; i < firstArray.GetLength(0); i++)
  {
    for (int j = 0; j < firstArray.GetLength(1); j++) sumRow += firstArray[i, j];
    if (sumRow < minRow)
    {
      minRow = sumRow;
      minSumRow = i;
      Console.WriteLine($"\n {minSumRow + 1}-я строка с наименьшей суммой элементов, равной {sumRow}");
      Console.WriteLine();
    }
    sumRow = 0;
  }
}


int ReadInt(string argument)                              // Модуль ввода данных
{
  Console.Write($"Введите {argument}: ");
  int result = 0;

  while (!int.TryParse(Console.ReadLine(), out result))
  {
    Console.WriteLine("Try again");
  }
  return result;
}

void CreateArray(int[,] firstArray)                   // Модуль заполнения массива случайными числами
{
  for (int i = 0; i < firstArray.GetLength(0); i++)
  {
    for (int j = 0; j < firstArray.GetLength(1); j++)
    {
      firstArray[i, j] = new Random().Next(rangeFrom, rangeTo);
    }
  }
}

void PrintArray(int[,] firstArray)                      // Модуль печати  массива
{
  for (int i = 0; i < firstArray.GetLength(0); i++)
  {
    for (int j = 0; j < firstArray.GetLength(1); j++)
    {
      Console.Write(firstArray[i, j] + " ");
    }
    Console.WriteLine();
  }
}
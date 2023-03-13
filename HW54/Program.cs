//Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4                  
// В итоге получается вот такой массив:                    
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

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

Console.WriteLine($"\nИтоговый массив: ");
SortArrayRows(firstArray);
PrintArray(firstArray);
Console.WriteLine();

void SortArrayRows(int[,] firstArray)                     // Модуль сортировки строк массива
{
  for (int i = 0; i < firstArray.GetLength(0); i++)
  {
    for (int j = 0; j < firstArray.GetLength(1); j++)
    {
      for (int k = 0; k < firstArray.GetLength(1) - 1; k++)
      {
        if (firstArray[i, k] < firstArray[i, k + 1])
        {
          int temp = firstArray[i, k + 1];
          firstArray[i, k + 1] = firstArray[i, k];
          firstArray[i, k] = temp;
        }
      }
    }
  }
}

int ReadInt(string argument)                              // Модуль ввода данных
{
  Console.Write($" Введите {argument}: ");
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
// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
//Например, даны 2 матрицы:
//2 4 | 3 4
//3 2 | 3 3
//Результирующая матрица будет:
//18 20
//15 18

Console.Clear();
Console.WriteLine("Матрицу A можно умножить на матрицу B только в том случае, если число столбцов матрицы A равняется числу строк матрицы B");
Console.WriteLine();
int rows = ReadInt("количество строк");
int columns = ReadInt("количество столбцов");
int rows1 = ReadInt("количество строк");
int columns1 = ReadInt("количество столбцов");
// int rangeFrom = ReadInt("диапазон от ");
// int rangeTo = ReadInt("диапазон до ");

int[,] firstArray = new int[rows, columns];
int[,] secondArray = new int[rows1, columns1];
int[,] resultArray = new int[rows, columns];

FillArrayRandom(firstArray);
PrintArray(firstArray);
Console.WriteLine();

FillArrayRandom(secondArray);
PrintArray(secondArray);
Console.WriteLine();

if (firstArray.GetLength(0) != secondArray.GetLength(1))         //проверка условия возможности перемножение матриц
{
  Console.WriteLine(" Нельзя перемножить ");
  return;
}
for (int i = 0; i < firstArray.GetLength(0); i++)
{
  for (int j = 0; j < secondArray.GetLength(1); j++)
  {
    resultArray[i, j] = 0;
    for (int k = 0; k < firstArray.GetLength(1); k++)
    {
      resultArray[i, j] += firstArray[i, k] * secondArray[k, j]; // вычисление по формуле перемножение матриц
    }
  }
}

PrintArray(resultArray);
Console.WriteLine();



int ReadInt(string argument)                   // Модуль ввода данных
{
  Console.Write($"Введте {argument}: ");
  int result = 0;

  while (!int.TryParse(Console.ReadLine(), out result))
  {
    Console.WriteLine("Try again");
  }
  return result;
}


void FillArrayRandom(int[,] array)        // Функция заполнения массива рандомными числами
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      array[i, j] = new Random().Next(0, 10);
    }
  }
}


void PrintArray(int[,] array)             // Функция вывода массива
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      Console.Write($"{array[i, j]} ");
    }
    Console.WriteLine();
  }
}
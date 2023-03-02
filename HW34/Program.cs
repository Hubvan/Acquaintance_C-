// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.

int[] array = GetRandomArray(9, 100, 999);

int count = SumEven(array);


Console.WriteLine($"В массиве [{string.Join(", ", array)}] : {count} чётных элементов");


int[] GetRandomArray(int length, int min, int max)
{
  int[] array = new int[length];
  Random num = new Random();

  for (int counter = 0; counter < length; counter++)
  {
    array[counter] = num.Next(min, max + 1);
  }

  return array;
}

int SumEven(int[] array)
{
  int count = 0;

  for (int i = 0; i < array.Length; i++)
  {
    if (array[i] % 2 == 0)
    {
      count++;
    }
  }
  return count;
}

  
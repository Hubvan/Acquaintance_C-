// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.

int[] array = GetRandomArray(9, 10, 99);

int sum = SumOdd(array);


Console.WriteLine($"В массиве [{string.Join(", ", array)}] : сумма элементов стоящих на нечётных позициях = {sum} ");



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

int SumOdd(int[] array)
{
    int sum = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 != 0)
        {
            sum = sum + array[i];
        }
    }
    return sum;
}
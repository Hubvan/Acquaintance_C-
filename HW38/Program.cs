// Задайте массив вещественных чисел. Найдите разницу между 
// максимальным и минимальным элементов массива.

double[] array = GetRandomArrayDouble(6, -99, 99);

double diff = DiffMaxMin(array);

Console.WriteLine($"В массиве [{string.Join(", ", array)}] : разницу между максимальным и минимальным элементами = {diff}");

double[] GetRandomArrayDouble(int length, int minValue, int maxValue)
{
  double[] array = new double[length];

  Random random = new Random();

  for (int i = 0; i < array.Length; i++)
  {
    array[i] = random.Next(minValue, maxValue +1);
  }
  return array;
}

double DiffMaxMin(double[] array)
{
  double maxDigit = array[0];

  double minDigit = array[0];

  for (int i = 1; i < array.Length; i++)
  {
    if (maxDigit < array[i])
    {
      maxDigit = array[i];
    }
    if (minDigit > array[i])
    {
      minDigit = array[i];
    }
  }
    return maxDigit - minDigit;
}
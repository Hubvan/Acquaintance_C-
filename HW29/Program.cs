// Задача 29: Напишите программу, которая задает 
//массив из 8 элементов, выводит их значение на экран.

int Prompt(string message)
{
  Console.Write(message);
  string ReadInput = Console.ReadLine();
  int result = int.Parse(ReadInput);
  return result;
}

int[] GenerateArray(int Length, int minValue, int maxValue)
{
  int[] array = new int[Length];
  Random random = new Random();
  for (int i = 0; i < Length; i++)
  {
    array[i] = random.Next(minValue, maxValue + 1);
  }

  return array;
}

void PrintArray(int[] array)
{
  Console.Write("|");
  for (int i = 0; i < array.Length - 1; i++)
  {
    Console.Write($"{array[i]}, ");  
  }
  Console.Write($"{array[array.Length - 1]}");

  Console.WriteLine("|");
}

int length = Prompt("Длина массива: ");
int min = Prompt("Начальное значение, для диапозона случайного числа: ");
int max = Prompt("Конечное значение, для диапозона случайного числа: ");
int[] array = GenerateArray(length, min, max);

PrintArray(array);



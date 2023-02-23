// Задача 23. Напишите программу, которая принимает на 
//вход число (N) и выдает таблицу кубов чисел от 1 до N.

Console.WriteLine("Введите число:");
int N = Convert.ToInt32(Console.ReadLine());
int index = 1;

while (index <= N)
{
  int result = (int)Math.Pow(index, 3);
  Console.Write(result);
  Console.Write(" ");
  index++;
}
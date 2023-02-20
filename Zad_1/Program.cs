if (int.TryParse(Console.ReadLine(), out int i))
{
  int sum = (int)Math.Pow(i, 2);
  Console.WriteLine(sum);
}
else
{
  Console.WriteLine("Вы ввели нецелое число");
}
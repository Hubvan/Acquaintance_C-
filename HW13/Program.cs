//Задача 13: Напишите программу, которая выводит третью 
//цифру заданного числа или сообщает, что третьей цифры нет.
Console.Write("Введите число:");
int.TryParse(Console.ReadLine(), out int chislo);

int three = chislo / 100;

if (three == 0)
{
   Console.WriteLine($"В числе {chislo} третьей цифры нет");
}
else  
{
string s = chislo.ToString();
string result = s[(s.Length - 3)].ToString();
Console.WriteLine($"Третья цифра числа {s} : {result}");
}

//Задача 10: Напишите программу, которая принимает на вход 
//трёхзначное число и на выходе показывает вторую цифру этого числа.

Console.Write("Введите трёхзначное число:");
int.TryParse(Console.ReadLine(), out int chislo);

string s = chislo.ToString();

string result = s[1].ToString();

Console.WriteLine($"Вторая цифра числа {s} : {result}");
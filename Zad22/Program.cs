//Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа

int i = 359;

string s = i.ToString();

string result = s[0].ToString() + s[2].ToString();

Console.WriteLine(result);

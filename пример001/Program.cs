//using System;
//using static System.Console; --- позволяет не вводить "Console." постоянно.

Console.Clear();
Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
//int number1 = int.Parse(Console.ReadLine());

int sqrNumber = number*number;
//int sqrNumber1 = Convert.ToInt32(Math.Pow(number1,2));

Console.WriteLine(sqrNumber);
//Console.WriteLine(sqrNumber1);
﻿Console.Write("Введите трехзначное число: "); // Ввод значения пользователем 
int number = Convert.ToInt32(Console.ReadLine());

int secondNumber = (number % 100) / 10;

Console.Write("Итак, вторая цифра заданного числа - это ");

Console.WriteLine(secondNumber);

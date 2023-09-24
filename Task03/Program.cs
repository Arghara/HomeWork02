﻿Console.Write("Введите цифру, обозначающую день недели: "); // Ввод значения пользователем
int dayWeek = Convert.ToInt32(Console.ReadLine());

if (dayWeek == 6 || dayWeek == 7)
{
    Console.WriteLine("{0} -> Ура! Этот день выходной", dayWeek);
}
else if (dayWeek >= 1 && dayWeek <= 5)
{
    Console.WriteLine("{0} -> Увы, этот день не выходной", dayWeek);
}
else
{
    Console.WriteLine("{0} -> Дня недели с такой цифрой нет", dayWeek);
}
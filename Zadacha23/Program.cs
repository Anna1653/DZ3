﻿/* Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125*/

Console.WriteLine("Введите число: ");
int a = int.Parse(Console.ReadLine());

for (int i = 1; i <= a; i++)
{
    int result = (int) Math.Pow(i, 3);
    Console.Write($"{result} ");
}

﻿/*
Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3
*/
Console.Write("input number1 => ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("input number2 => ");
int number2 = Convert.ToInt32(Console.ReadLine());
if (number1 > number2)
{
    Console.Write("max = ");
    Console.WriteLine(number1);
    Console.Write("min = ");
    Console.WriteLine(number2);
}
else
{
    Console.Write("max = ");
    Console.WriteLine(number2);
    Console.Write("min = ");
    Console.WriteLine(number1);
}

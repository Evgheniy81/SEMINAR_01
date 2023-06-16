/*
Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
5 -> 2, 4
8 -> 2, 4, 6, 8
*/
Console.Write("input number => ");
int number = Convert.ToInt32(Console.ReadLine());
int n = 1;
while (number >= n)
{
   if (n % 2 == 0)
   {
    Console.Write(" ");
    Console.Write (n);
      } 
       n ++;
}
 
﻿
// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да 
// 7 -> да 
// 1 -> нет

int num = new Random().Next(1,8);  
Console.WriteLine(num);

if (num > 5)
{
  Console.WriteLine("да");
}
else
{
  Console.WriteLine("нет");
}




// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
// что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6


Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
if (number >= 100 && number <=999) 
{
  int a = number % 10;
  Console.WriteLine(a);
}
if (number <= 99) 
{
  Console.WriteLine(" третьей цифры нет");
}
if (number >= 10000 && number <=99999) 
{
  int b = number/100 % 10;
  Console.WriteLine(b);
}

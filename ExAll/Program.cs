// // Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// // 456 -> 5
// // 782 -> 8 
// // 918 -> 1
// Console.WriteLine("Введите трехзначное число");
// int number = Convert.ToInt32(Console.ReadLine());
// int a = number / 10;
// int b = a % 10;
// Console.WriteLine(b);


// // Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
// // что третьей цифры нет.
// // 645 -> 5
// // 78 -> третьей цифры нет
// // 32679 -> 6
// Console.WriteLine("Введите число");
// int number = Convert.ToInt32(Console.ReadLine());
// if (number >= 100 && number <=999) 
// {
//   int a = number % 10;
//   Console.WriteLine(a);
// }
// if (number <= 99) 
// {
//   Console.WriteLine(" третьей цифры нет");
// }
// if (number >= 10000 && number <=99999) 
// {
//   int b = number/100 % 10;
//   Console.WriteLine(b);
// }


// // Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// // 6 -> да 
// // 7 -> да 
// // 1 -> нет
// int num = new Random().Next(1,8);  
// Console.WriteLine(num);
// if (num > 5)
// {
//   Console.WriteLine("да");
// }
// else
// {
//   Console.WriteLine("нет");
// }

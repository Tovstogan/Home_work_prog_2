/*
Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1
*/

Console.Clear();
Console.WriteLine("Задача 10");
Console.Write("Введите число: ");
Random rnd= new Random();
int number = rnd.Next(100,1000);
Console.WriteLine(number);
int firstN = number/ 100;
int secondN = (number / 10) % 10;
int thirdN = number % 10;
Console.WriteLine("Полученное число {0}",secondN);


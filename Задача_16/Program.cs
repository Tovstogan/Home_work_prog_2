/*Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет
*/

Console.Clear();
Console.WriteLine("Задача 16");
Console.Write("Введите номер дня недели: ");
int dayOfWeekNumber = int.Parse(Console.ReadLine());

if (dayOfWeekNumber >= 1 && dayOfWeekNumber <= 5)
{
Console.WriteLine("нет");
}
else if (dayOfWeekNumber>=6 && dayOfWeekNumber <= 7)
{
Console.WriteLine("Да");
}
else 
{
    Console.WriteLine("Такого дня недели нет");
}
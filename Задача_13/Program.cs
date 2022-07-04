/*Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

645 -> 5

78 -> третьей цифры нет

32679 -> 6
*/

Console.Clear();
Console.WriteLine("Задача 13");
Console.WriteLine("Введитие число");
string number = Console.ReadLine();
int numberStr = int.Parse(number);
if (numberStr>=100 && numberStr<=999)
{
    int thirdNumber = numberStr%10;
    Console.WriteLine("Третья цифра {0}", thirdNumber);
}
  else
{
    Console.WriteLine("Число не трехзначное");
}

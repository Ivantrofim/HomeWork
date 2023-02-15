// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6

Console.WriteLine("Введите любое число от 1 до 100000");
int number = Convert.ToInt32(Console.ReadLine());
string num = Convert.ToString(number);
if (num.Length > 2)
{
    Console.WriteLine("Третья цифра -> " + num[2]);
}
else
{
    Console.WriteLine("-> Третьей цифры нет");
}

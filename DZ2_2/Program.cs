// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Введите число из трех и более цифр: ");
string str = Console.ReadLine();
if (str.Length <= 2)
{
   Console.WriteLine(str + " -> третьей цифры нет");
} 
Console.WriteLine(str + " -> " + str[2]);
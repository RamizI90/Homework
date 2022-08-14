// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или 
// сообщает, что третьей цифры нет.

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Введите трехзначное число: ");
string? numberstring = Console.ReadLine();
if (numberstring!.Length > 2)
{
    Console.WriteLine(numberstring[2]);
}

else
{
    Console.WriteLine("Третьей цифры нет!");
}



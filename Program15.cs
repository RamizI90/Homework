// Задача 15: Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели,и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите число от 1 до 7 обозначающую день недели ");
string? numberstring = Console.ReadLine();
int number = int.Parse(numberstring!);

if (number > 0&&number < 8 )
    if (number == 6|| number == 7)
    {
        Console.WriteLine("Ура!!! Выходной день)))");
    }

    else
    {
        Console.WriteLine("Будни, все работаем(((");
    }

else
{
    Console.WriteLine("Вы ввели неверное число. Введите корректное число от 1 до 7 ");
}
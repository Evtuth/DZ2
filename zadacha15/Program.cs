﻿//Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным
// 6 -> да
// 7 -> да
// 1 -> нет

Console.Write("Введите номер дня недели: ");
int a = Convert.ToInt32(Console.ReadLine());

switch (a)
{
    case 1:
        Console.WriteLine("Понедельник не является выходным!");
        break;

    case 2:
        Console.WriteLine("Вторник не является выходным!");
        break;

    case 3:
        Console.WriteLine("Среда не является выходным!");
        break;

    case 4:
        Console.WriteLine("Четверг не является выходным!");
        break;

    case 5:
        Console.WriteLine("Пятница не является выходным!");
        break;

    case 6:
        Console.WriteLine("Суббота - выходной!");
        break;

    case 7:
        Console.WriteLine("Воскресенье - выходной!");
        break;
    default:
        Console.WriteLine("Введен некоректный номер дня недели!");
        break;
}
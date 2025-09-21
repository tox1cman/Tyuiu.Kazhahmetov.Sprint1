﻿using Tyuiu.Kazhahmetov.Sprint1.Task6.V15.Lib;

DataService ds = new DataService();

Console.Title = "Спринт #1 | Выполнил: Кажахметов А. Е. | ПИНб-25-1";

Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #1                                                               *");
Console.WriteLine("* Тема: Базовые навыки работы в С#                                        *");
Console.WriteLine("* Задание #6                                                              *");
Console.WriteLine("* Вариант #15                                                             *");
Console.WriteLine("* Выполнил: Кажахметов Амир Ерболович | ПИНб-25-1                         *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ                                                                 *");
Console.WriteLine("* Написать программу: пользователь вводит текст.                          *");
Console.WriteLine("* Проверить, что в строке больше букв, чем знаков.                        *");
Console.WriteLine("*                                                                         *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");

Console.WriteLine("Введите слово:");
string x = Console.ReadLine();

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

if (ds.CheckLettersCount(x))
{
    Console.WriteLine("Букв больше");
}
else
{
    Console.WriteLine("Символов больше");
}
Console.ReadKey();
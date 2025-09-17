// See https://aka.ms/new-console-template for more information
using Tyuiu.Kazhahmetov.Sprint1.Task2.V26.Lib;
DataService ds = new DataService();

Console.Title = "Спринт #1 | Выполнил: Кажахметов А. Е. | ПИНб-25-1";

Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #1                                                               *");
Console.WriteLine("* Тема: Базовые навыки работы в С#                                        *");
Console.WriteLine("* Задание #2                                                              *");
Console.WriteLine("* Вариант #26                                                             *");
Console.WriteLine("* Выполнил: Кажахметов Амир Ерболович | ПИНб-25-1                         *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ                                                                 *");
Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные  *");
Console.WriteLine("* выполняет указанные расчёты и печатает результат на экране.             *");
Console.WriteLine("*                                                                         *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");

int value, valueTwo;

Console.WriteLine("Введите часы:");
value = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите минуты:");
valueTwo = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

Console.WriteLine(ds.CalculateMinutesSinceStart(value, valueTwo));

Console.ReadLine();

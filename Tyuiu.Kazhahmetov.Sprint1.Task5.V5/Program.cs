using System.Security.Cryptography.X509Certificates;
using Tyuiu.Kazhahmetov.Sprint1.Task5.V5.Lib;

DataService ds = new DataService();

Console.Title = "Спринт #1 | Выполнил: Кажахметов А. Е. | ПИНб-25-1";

Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #1                                                               *");
Console.WriteLine("* Тема: Базовые навыки работы в С#                                        *");
Console.WriteLine("* Задание #5                                                              *");
Console.WriteLine("* Вариант #5                                                              *");
Console.WriteLine("* Выполнил: Кажахметов Амир Ерболович | ПИНб-25-1                         *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ                                                                 *");
Console.WriteLine("* Написать программу, которая решает следующую задачу: Присвоить целой    *");
Console.WriteLine("* переменной d первую цифру из дробной части положительного               *");
Console.WriteLine("* вещественного числа x                                                   *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");

double x = 32.597;
Console.WriteLine(x);

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

Console.WriteLine(ds.Calculate(x));
Console.ReadKey();
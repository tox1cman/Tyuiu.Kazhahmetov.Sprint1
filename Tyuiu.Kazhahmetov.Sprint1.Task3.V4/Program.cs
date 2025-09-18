using Tyuiu.Kazhahmetov.Sprint1.Task3.V4.Lib;

DataService ds = new DataService();

Console.Title = "Спринт #1 | Выполнил: Кажахметов А. Е. | ПИНб-25-1";

Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #1                                                               *");
Console.WriteLine("* Тема: Базовые навыки работы в С#                                        *");
Console.WriteLine("* Задание #3                                                              *");
Console.WriteLine("* Вариант #4                                                              *");
Console.WriteLine("* Выполнил: Кажахметов Амир Ерболович | ПИНб-25-1                         *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ                                                                 *");
Console.WriteLine("* Написать программу вычисления стоимости покупки, состоящей из           *");
Console.WriteLine("* нескольких тетрадей и такого же количества обложек к ним.               *");
Console.WriteLine("*                                                                         *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");

double x = 2.75;
double y = 0.5;
int z = 7;

Console.WriteLine("Цена тетради - " + x);
Console.WriteLine("Цена обложки - " + y);
Console.WriteLine("Количество комплектов - " + z);

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

Console.WriteLine(ds.PurchaseAmount(x, y, z));
Console.ReadKey();
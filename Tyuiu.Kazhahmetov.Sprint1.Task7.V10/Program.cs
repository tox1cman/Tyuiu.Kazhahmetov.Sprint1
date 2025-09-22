using Tyuiu.Kazhahmetov.Sprint1.Task7.V10.Lib;

DataService ds = new DataService();

Console.Title = "Спринт #1 | Выполнил: Кажахметов А. Е. | ПИНб-25-1";

Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #1                                                               *");
Console.WriteLine("* Тема: Базовые навыки работы в С#                                        *");
Console.WriteLine("* Задание #7                                                              *");
Console.WriteLine("* Вариант #10                                                             *");
Console.WriteLine("* Выполнил: Кажахметов Амир Ерболович | ПИНб-25-1                         *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ                                                                 *");
Console.WriteLine("* Написать программу, которая вычисляет математическое выражение по       *");
Console.WriteLine("* исходным значениям данных, вводимых пользователем.                      *");
Console.WriteLine("*                                                                         *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("*                ln cos x                                                 *");
Console.WriteLine("* z = 2ctg(3x) - ---------                                                *");
Console.WriteLine("*                ln(1+x^2)                                                *");
Console.WriteLine("***************************************************************************");


double x = 0;
Console.WriteLine("Введите X:");
x = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

Console.WriteLine(ds.Calculate(x));
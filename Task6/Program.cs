﻿class Task6
{
    /* Задание 6
Используя Visual Studio, создайте проект по шаблону Console Application.
Создайте две целочисленные переменные и задайте им некоторые значения.
Применяя технику вложенных циклов, нарисуйте прямоугольник из звездочек.
Используйте значения ранее созданных переменных для указания высоты и ширины прямоугольника.*/

    static void Main()
    {
        int high = 5;
        int width = 18;
        for (int a = 0; a < high; a++)
        {
            for (int b = 0; b < width; b++)
            {
                Console.Write("*");
            }
            Console.WriteLine("*");
        }
    }
}

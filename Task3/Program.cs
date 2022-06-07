class Task3
{
    /* Задание 3
Используя Visual Studio, создайте проект по шаблону Console Application.
Используя циклы и метод: Console.Write("*"), Console.Write(" "), Console.Write("\n")
(для перехода на новую строку). Выведите на экран:
прямоугольник
прямоугольный треугольник
равносторонний треугольник
ромб  */

    static void Main()
    {
        //Прямоугольник
        for (int a = 0; a < 5; a++)
        {
            for (int b = 0; b < 15; b++)
            {
                Console.Write("*");
            }
            Console.WriteLine("*");
        }

        //Прямоугольный треугольник
        for (int c = 0; c < 7; c++)
        {
            for (int d = 0; d < c; d++)
            {
                Console.Write("*");
            }
            Console.WriteLine("*");
        }

        //Равносторонний треугольник
        for (int c = 0; c < 7; c++)
        {
            for (int d = 0; d <= 7 - c; d++)
            {
                Console.Write(" ");
            }
            for (int e = 0; e <= 2 * c - 1; e++)
            {
                Console.Write("*");
            }
            Console.WriteLine("");
        }

        //Ромб
        for (int f = 1; f <= 7; f += 2)
        {
            for (int g = 7; g >= f; g -= 2)
            {
                Console.Write(" ");
            }
            for (int h = 1; h <= f; h++)
            {
                Console.Write("*");
            }
            Console.WriteLine("");
        }
        for (int f = 1; f <= 7; f += 2)
        {
            for (int g = 1; g <= f; g += 2)
            {
                Console.Write(" ");
            }
            for (int h = 7; h >= f; h--)
            {
                Console.Write("*");
            }
            Console.WriteLine("");
        }
    }
}

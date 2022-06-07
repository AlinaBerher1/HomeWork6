class Task2
{
    /* Задание 2
    Используя Visual Studio, создайте проект по шаблону Console Application.
    Дано два числа A и B (A<B) выведите суму всех чисел расположенных между данными числами на экран.
    Дано два числа A и B (A<B) выведите все нечетные значения, расположенные между данными числами. */

    static void Main()
    {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.InputEncoding = System.Text.Encoding.Unicode;
            Console.WriteLine("Пожалуйста введите первое число");
            int A = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Пожалуйста введите второе число");
            int B = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
        if (A < B)
        {
            for (int counter = A + 1; counter < B; counter++)
            {
                while (counter % 2 != 0)
                {
                    Console.WriteLine("Нечётные числа - " + counter);
                    break;
                }
                sum += counter;
                if (counter == B - 1)
                {
                    Console.WriteLine("Ответ - " + sum);
                }
            }
        }
        else
        {
            Console.WriteLine("Первое число должно быть меньше второго");
        }
    }
}
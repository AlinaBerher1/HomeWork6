class Task4
{
    /* Задание 4
Имеется N клиентов, которым компания производитель должна доставить товар.
Сколько существует возможных маршрутов доставки товара, с учетом того,
что товар будет доставлять одна машина?
Используя Visual Studio, создайте проект по шаблону Console Application.
Напишите программу, которая будет рассчитывать, и выводить на экран количество возможных вариантов доставки товара.
Для решения задачи, используйте факториал N!, рассчитываемый с помощью цикла do-while.*/

    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.Unicode;
        Console.InputEncoding = System.Text.Encoding.Unicode;
        Console.WriteLine("Пожалуйста, введите число клиентов");
        int N = Convert.ToInt32(Console.ReadLine());
        int d = 1;
        int i = 1;
        do
        {
            d = i * d;
            i++;
        }
        while (i <= N);
        Console.WriteLine("Количество возможных вариантов доставки товара " + d);
    }
}
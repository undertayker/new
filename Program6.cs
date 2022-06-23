using System;

namespace Exercise_7
{
    class Program6
    {
        static void Main(string[] args)
        {
            int timeOfReceipt = 10;
            Console.WriteLine("Введите количество людей в очереди : ");
            int peoply = int.Parse(Console.ReadLine());
            int a = timeOfReceipt;
            int b = peoply;
            int time = a * b;
            int minutes = 60;
            int hour;

            Console.WriteLine("Время ожидания");
            Console.WriteLine("Осталось часов\t:{0}", time / minutes );
            Console.WriteLine("Осталось минут\t:{0}", time % minutes );
        }
    }
}
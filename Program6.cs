using System;

namespace Exercise_7
{
    class Program6
    {
        static void Main(string[] args)
        {
            int timeOfReceipt = 10;
            Console.WriteLine("Введите количество людей в очереди : ");
            int people = int.Parse(Console.ReadLine());
            int timeInMinutes = 60;
            int allMinutes = timeOfReceipt * people;
            int hour = allMinutes / timeInMinutes;
            int minutes = allMinutes % timeInMinutes;

            Console.WriteLine("Вы должны отстоять в очереди {0} часов и {1} минут ", hour, minutes);
        }
    }
}
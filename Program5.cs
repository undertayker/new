using System;

namespace Exercise_7
{
    class Program5
    {
        static void Main(string[] args)
        {
            int priceOfCrystal = 10;
            Console.WriteLine("Добро пожаловать!");
            Console.WriteLine($"Стоймость одного кристалла : {priceOfCrystal} ");
            Console.WriteLine("Введите ваше количество золота :");
            int gold = int.Parse(Console.ReadLine());
            Console.WriteLine("Сколько хотите купить кристалов?");
            int numberOfCrystals = int.Parse(Console.ReadLine());

            gold -= priceOfCrystal * numberOfCrystals;
            Console.WriteLine($"Осталось золота : {gold}");
            Console.WriteLine($"куплено кристалов : {numberOfCrystals}");
        }
    }
}
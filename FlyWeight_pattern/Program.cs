using System;
using System.Collections.Generic;
using FlyWeight_pattern.Shops;

namespace FlyWeight_pattern
{
    class Program
    {
        static void Main()
        {
            int number, avaliable;
            ShopFactory factory = new ShopFactory();
            Console.WriteLine("Input shops number:");
            number = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Input how many products item is avaliable");
            avaliable = Int32.Parse(Console.ReadLine());

            switch (number)
            {
                case 1:
                    {
                        Shop shop1 = factory.GetShop(number);
                        Console.WriteLine(shop1.check(avaliable));
                        break;
                    }
                case 2:
                    {
                        Shop shop2 = factory.GetShop(number);
                        Console.WriteLine(shop2.check(avaliable));
                        break;
                    }
                case 3:
                    {
                        Shop shop3 = factory.GetShop(number);
                        Console.WriteLine(shop3.check(avaliable));
                        break;
                    }
            }
            Console.ReadKey();
        }

    }
}

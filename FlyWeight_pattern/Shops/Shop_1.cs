using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyWeight_pattern.Shops
{
    class Shop_1 : Shop
    {
        public Shop_1()
        {
            average = 12;
        }

        string output;

        public override string check(int avaliable)
        {
            if (average >= avaliable)
            {
                output = "You do not need to buy new product's items";
                return (output);
            }
            else
            {
                int tmp = avaliable - average;
                output = ("You need to buy aditional " + tmp + " items of product");
                return (output);
            }
        }
    }
}

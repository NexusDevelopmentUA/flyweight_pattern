using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlyWeight_pattern.Shops;

namespace FlyWeight_pattern
{
    class ShopFactory
    {
        Dictionary<int, Shop> shops = new Dictionary<int, Shop>();
        public ShopFactory()
        {
            shops.Add(1, new Shop_1());
            shops.Add(2, new Shop_2());
            shops.Add(3, new Shop_3());
        }

        public Shop GetShop(int key)
        {
            if (shops.ContainsKey(key))
            {
                return (shops[key]);
            }
            else
            {
                return (null);
            }
        }
    }
}

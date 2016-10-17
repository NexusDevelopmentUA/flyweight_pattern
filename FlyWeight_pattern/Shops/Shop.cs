using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyWeight_pattern.Shops
{
    abstract class Shop
    {
        protected int average;
        public abstract string check(int avaliable);
    }
}

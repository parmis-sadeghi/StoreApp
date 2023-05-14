using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreApp.Classes
{
    public class Customer
    {
        public int CustomerPhone { get; set; }
        public List<Goods> CustomerGoods = new List<Goods>();


    }
}

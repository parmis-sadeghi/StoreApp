using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StoreApp.Classes;
using StoreApp.Enums;

var Customers = new List<Customer>();
var Sellers = new List<Seller>();
namespace StoreApp.Helper
{
    public class ConsoleHelper
    {
        public static void Start()
        {
            Console.WriteLine("Please enter your choice ...");
            Console.WriteLine("1.Login (customers)");
            Console.WriteLine("2.Register (customers)");
            Console.WriteLine("3.Login (seller)");
            Console.WriteLine("4.Register (seller)");
            Services firstMenuOptions = (Services)Enum.Parse(typeof(Services), Console.ReadLine());

            switch(firstMenuOptions)
            {
                case Services.SellerLogin:
            }

        }

    }
}

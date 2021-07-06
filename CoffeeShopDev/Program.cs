using CoffeeShopDev.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoffeeShopDev.Concrete;
using CoffeeShopDev.Entities;
using CoffeeShopDev.Adapters;

namespace CoffeeShopDev
{
   class Program
    { 
    static void Main(string[] args)
    {
            BaseCustomerManager customerManager = new StarbucksCustomerManager(new MernisServiceAdapter()) ;

            //mernis sadece dogum yılı alır ve diğerleride büyük olmak zorunda 

        customerManager.Save(new Customer { DateOfBirth = new DateTime(1996, 3, 21), FirstName = "UFUK", LastName = "YAVUZ", NationalityId = "15977373866" });
            Console.ReadLine();

    }
    }

}

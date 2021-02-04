using System;
using System.Collections.Generic;
using System.Text;

namespace GameHomework
{
    class OrderManager : IOrderService
    {
        public void MakeSale(Products products)
        {
            Console.WriteLine("Satış işlemi başarı ile tamamlandı");
            Console.WriteLine("Satın alınan ürün: " + products.ProductName);
        }
    }
}

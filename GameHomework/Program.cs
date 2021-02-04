using System;

namespace GameHomework
{
    class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManager = new GamerManager(new NewEStateUserValidationManager());
            gamerManager.Add(new Gamer 
            {     Id = 1, 
                  BirthYear = 1996,
                  FirstName = "TOLGA", 
                  LastName = "DÖNMEZ", 
                  IdentityNumber = 12345 }
            );
            Console.WriteLine("****************************************************");

            CampaignManager campaignManager = new CampaignManager();
            campaignManager.Add(new Campaign
            {
                CampaignId = 1,
                CampaignName = "Bu ürünü alana İkincisi %75 indirimli",
                CampaignDetail = "Bu Kampanya 2021 Şubat sonuna kadar devam edecektir."
            });
            Console.WriteLine("****************************************************");

            OrderManager orderManager = new OrderManager();
            orderManager.MakeSale(new Products
            {
                ProductId = 1,
                ProductName = "Leauge of Legends",
                UnitPrice = 100,
                Stock = 250
            });
        }
    }
}

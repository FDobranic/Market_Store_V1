using MarketStore.Model;
using System;

namespace MarketStore
{
    class Program
    {
        static void Main(string[] args)
        {
            DiscountCard bronzeCard = new DiscountCard(0, CardType.Bronze);

            double purchaseValue = 1300;

            Console.WriteLine("Bronze card: ");
            Console.WriteLine("Purchase value: ${0}", purchaseValue);
            Console.WriteLine("Discount rate: {0}%", bronzeCard.calculateRate());
            Console.WriteLine("Discount: ${0}", bronzeCard.calculateDiscount(purchaseValue));
            Console.WriteLine("Total: ${0}", bronzeCard.calculateTotal(purchaseValue));

            Console.WriteLine();

            DiscountCard silverCard = new DiscountCard(600, CardType.Silver);

            Console.WriteLine("Silver card: ");
            Console.WriteLine("Purchase value: ${0}", purchaseValue);
            Console.WriteLine("Discount rate: {0}%", silverCard.calculateRate());
            Console.WriteLine("Discount: ${0}", silverCard.calculateDiscount(purchaseValue));
            Console.WriteLine("Total: ${0}", silverCard.calculateTotal(purchaseValue));

            Console.WriteLine();

            DiscountCard goldCard = new DiscountCard(500, CardType.Gold);

            Console.WriteLine("Gold card: ");
            Console.WriteLine("Purchase value: ${0}", purchaseValue);
            Console.WriteLine("Discount rate: {0}%", goldCard.calculateRate());
            Console.WriteLine("Discount: ${0}", goldCard.calculateDiscount(purchaseValue));
            Console.WriteLine("Total: ${0}", goldCard.calculateTotal(purchaseValue));
        }
    }
}

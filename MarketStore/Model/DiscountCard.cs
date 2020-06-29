using System;
using System.Collections.Generic;
using System.Text;

namespace MarketStore.Model
{
    public enum CardType { Bronze, Silver, Gold}
    class DiscountCard
    {
        public string OwnerInfo { get; set; }
        public double Turnover { get; set; }
        private double DiscountRate { get; set; }

        public CardType Type { get; set; }

        public DiscountCard(double Turnover, CardType Type)
        {
            this.Turnover = Turnover;
            this.Type = Type;
        }

        public double calculateDiscount(double purchaseValue)
        {
            return purchaseValue * DiscountRate / 100;
        }

        public double calculateTotal(double purchaseValue)
        {
            return purchaseValue - calculateDiscount(purchaseValue);
        }

        public double calculateRate()
        {
            if(Type == CardType.Bronze)
            {
                if(Turnover < 100)
                {
                    DiscountRate = 0;
                }
                else if(Turnover >= 100 && Turnover <= 300)
                {
                    DiscountRate = 1;
                }
                else
                {
                    DiscountRate = 2.5;
                }
            }
            else if(Type == CardType.Silver)
            {
                if(Turnover > 300)
                {
                    DiscountRate = 3.5;
                }
                else
                {
                    DiscountRate = 2;
                }
            }
            else
            {
                if(Turnover >= 800)
                {
                    DiscountRate = 10;
                }
                else if(Turnover >= 100)
                {
                    DiscountRate = (Turnover + 200) / 100;
                }
                else
                {
                    DiscountRate = 2;
                }
            }
            return DiscountRate;
        }
    }
}

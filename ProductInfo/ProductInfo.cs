using System;
using System.Collections.Generic;
using System.Text;

namespace Product
{
    internal class ProductInfo
    {
        public string Name { get; set; }
        public double Price { get; set; }
        private double _discountPercent;
        public double DiscountPercent
        {
            get { return _discountPercent; }
            set
            {
                if (value < 0)
                    _discountPercent = 0;
                else if (value > 100)
                    _discountPercent = 100;
                else
                    _discountPercent = value;
            }
        }
        public double FinalPrice => Price - DiscountAmount;
        public double DiscountAmount => Price * DiscountPercent / 100;

        public ProductInfo(string name, int price)
        {
            Name = name;
            Price = price;
            DiscountPercent = 0;
        }
        public ProductInfo(string name, int price, int discountPercent)
        {
            Name = name;
            Price = price;
            DiscountPercent = discountPercent;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"[상품 정보] {Name} - 가격 : {Price}원, 할인 : {DiscountPercent}% (-{DiscountAmount}원), 최종가 : {FinalPrice}원");
        }
    }
}

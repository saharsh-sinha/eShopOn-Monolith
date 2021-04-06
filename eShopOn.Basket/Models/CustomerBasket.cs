﻿using System.Collections.Generic;

namespace eShopOn.Basket.Models
{
    public class CustomerBasket
    {
        public string BuyerId { get; set; }

        public List<BasketItem> Items { get; set; } = new List<BasketItem>();

        public CustomerBasket()
        {
        }

        public CustomerBasket(string customerId)
        {
            BuyerId = customerId;
        }
    }
}
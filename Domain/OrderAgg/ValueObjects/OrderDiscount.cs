﻿using Common.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.OrderAgg.ValueObjects
{
    public class OrderDiscount : BaseValueObject
    {
        public OrderDiscount(string discountTitle, int discountAmount)
        {
            DiscountTitle = discountTitle;
            DiscountAmount = discountAmount;
        }

        public string DiscountTitle { get; private set; }
        public int DiscountAmount { get; private set; }
    }
}
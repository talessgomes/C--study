﻿using System;
using OrderApp.Entities.Enums;

namespace OrderApp.Entities
{
    internal class Order
    {
        public int Id { get; set; }
        public DateTime Moment { get; set; }
        public int MyProperty { get; set; }
        public OrderStatus Status { get; set; }

        public override string ToString()
        {
            return Id
                 + ", "
                 + Moment
                 +", "
                 + Status;
        }
    }
}

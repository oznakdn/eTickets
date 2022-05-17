﻿using System.Collections.Generic;

namespace eTickets.Web.Models.Entities
{
    public class Order
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string UserId { get; set; }

        public List<OrderItem> OrderItems { get; set; }


    }
}

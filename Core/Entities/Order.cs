using System;

namespace Core.Entities
{
    public class Order
    {
        public Guid Id { get; set; }
        public string CustomerId { get; set; }
    }
}
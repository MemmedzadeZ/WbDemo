﻿namespace WbDemo.Entities
{
    public class Customer
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Surname { get; set; }
        public virtual ICollection<Order> Orders { get; set; }

    }
}

using System.Collections.Generic;

namespace Task2
{
    public class Shop
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Customer> Customers { get; set; } = new List<Customer>();
        public override string ToString()
        {
            return $"Id={Id}, Name={Name}";
        }
    }
}

using System.Collections.Generic;

namespace Task2
{
    public class Item
    {
        public int Id { get; set; }
        public string Name { set; get; }
        public List<Customer> Customers { get; set; } = new List<Customer>();
        public override string ToString()
        {
            return $"Id={Id}, Name={Name}";
        }
    }
}

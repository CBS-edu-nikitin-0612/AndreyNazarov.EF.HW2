using System.Collections.Generic;

namespace Task2
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public List<Item> Items { get; set; } = new List<Item>();

        public override string ToString()
        {
            return $"Id={Id}, Name={Name}, Address={Address}";
        }
    }
}

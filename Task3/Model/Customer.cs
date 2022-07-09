namespace Task3.Model
{
    internal class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public HashSet<Order> Orders { get; set; }
    }
}
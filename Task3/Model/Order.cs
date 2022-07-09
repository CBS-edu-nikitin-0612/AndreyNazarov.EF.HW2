namespace Task3.Model
{
    internal class Order
    {
        public int Id { get; set; }
        public int Amount { get; set; }
        public Customer Customer { get; set; }
    }
}
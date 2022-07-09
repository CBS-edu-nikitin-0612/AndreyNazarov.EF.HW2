using Task3.Model;

namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (ShopDBContext context = new ShopDBContext())
            {
                Customer customer1 = new Customer() { Name = "Вася", LastName = "Васин" };
                Customer customer2 = new Customer() { Name = "Оля", LastName = "Олина" };
                context.Customers.Add(customer1);
                context.Customers.Add(customer2);
                context.SaveChanges();

                Order order1 = new Order() { Amount = 1000, Customer = customer1 };
                Order order2 = new Order() { Amount = 2000, Customer = customer1 };
                Order order3 = new Order() { Amount = 1000, Customer = customer1 };
                Order order4 = new Order() { Amount = 1000, Customer = customer2 };
                Order order5 = new Order() { Amount = 3000, Customer = customer2 };
                context.AddRangeAsync(order1, order2, order3, order4, order5);
                context.SaveChanges();
            }

            using (ShopDBContext context = new ShopDBContext())
            {
                Console.WriteLine("Покупатели");
                foreach(Customer customer in context.Customers)
                {
                    Console.WriteLine($"{customer.Name} {customer.LastName} {customer.Id}");
                }
                Console.WriteLine("\nЗаказы");
                foreach (Order order in context.Orders)
                {
                    Console.WriteLine($"Покупатель {order.Customer.Id} Сумма {order.Amount}");
                }
            }
        }
    }
}
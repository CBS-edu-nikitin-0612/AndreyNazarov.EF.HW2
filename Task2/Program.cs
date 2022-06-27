using System;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Database.SetInitializer(new DropCreateDatabaseAlways<Model>());
            using (Model model = new Model())
            {
                Customer customer1 = model.Customers.Add(new Customer() { Address = "Address 1", Name = "Вова" });
                Customer customer2 = model.Customers.Add(new Customer() { Address = "Address 2", Name = "Петя" });
                Customer customer3 = model.Customers.Add(new Customer() { Address = "Address 3", Name = "Катя" });
                Customer customer4 = model.Customers.Add(new Customer() { Address = "Address 4", Name = "Лена" });

                Item item1 = model.Items.Add(new Item() { Name = "Плеер" });
                Item item2 = model.Items.Add(new Item() { Name = "Чайник" });
                Item item3 = model.Items.Add(new Item() { Name = "Плита" });
                Item item4 = model.Items.Add(new Item() { Name = "Телевизор" });

                Shop shop1 = model.Shops.Add(new Shop() { Name = "Магазин 1" });
                Shop shop2 = model.Shops.Add(new Shop() { Name = "Магазин 2" });
                model.SaveChanges();

                model.Customers.Find(1).Items.AddRange(new Item[] { item1, item3 });
                model.Customers.Find(2).Items.AddRange(new Item[] { item1, item2 });
                model.Customers.Find(3).Items.AddRange(new Item[] { item1, item3, item4 });
                model.Customers.Find(4).Items.AddRange(new Item[] { item1, item4 });

                model.Items.Find(1).Customers.AddRange(new Customer[] { customer1, customer2, customer3, customer4 });
                model.Items.Find(2).Customers.AddRange(new Customer[] { customer2 });
                model.Items.Find(3).Customers.AddRange(new Customer[] { customer1, customer3 });
                model.Items.Find(4).Customers.AddRange(new Customer[] { customer3, customer4 });

                model.Shops.Find(1).Customers.AddRange(new Customer[] { customer1, customer2 });
                model.Shops.Find(2).Customers.AddRange(new Customer[] { customer3, customer4 });
                model.SaveChanges();

                Console.WriteLine("Customers");

                foreach (var customer in model.Customers)
                {
                    Console.WriteLine(customer);
                }
                Console.WriteLine("Shops");
                foreach (var shop in model.Shops)
                {
                    Console.WriteLine(shop);
                }
                Console.WriteLine("Items");
                foreach (var item in model.Items)
                {
                    Console.WriteLine(item);
                }
            }
            Console.ReadKey();
        }
    }
}

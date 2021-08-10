using System;
using System.Linq;

namespace DatabaseFirstEF
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new NorthwindContext())
            {
                Console.WriteLine(db.ContextId);
                foreach (var c in db.Customers)
                {
                    Console.WriteLine($"Customers {c.ContactName} has ID {c.CustomerId} and live in {c.City}");
                    Console.WriteLine(c);
                }
                db.Customers.ToList().ForEach(c => Console.WriteLine(c));

                //ADD
                //var newCustomer = new Customer { CustomerId = "BLOGG", ContactName = "Joe Bloggs", CompanyName = "ToysRUs" };
                //db.Customers.Add(newCustomer);
                

                //var selectedCustomer = db.Customers.Where(c => c.CustomerId == "BLOGG").FirstOrDefault();
                //selectedCustomer.City = "Paris";
                



                var p = db.Customers.Find("BLOGG");
                var selectedCustomer = db.Customers.Where(c => c.CustomerId == "BLOGG").FirstOrDefault();
                db.Customers.Remove(selectedCustomer);

                db.SaveChanges();

                p = db.Customers.Find("BLOGG");
            }
        }
    }
    public partial class Customer
    {
        public override string ToString()
        {
            return $"{CustomerId} - {ContactName} - {City}";
        }
    }
}

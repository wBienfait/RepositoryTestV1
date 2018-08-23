using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
	class Program
	{
		static void Main(string[] args)
		{
			Company company1 = new Company();
			Repository<Customer> repo1 = new Repository<Customer>(company1);
			Customer customer1 = new Customer(new SmsSend(), "hello", "world");
			Customer customer2 = new Customer(new SmsSend(), "william", "blekdd");
			Customer customer3 = new Customer(new SmsSend(), "alice", "sqdfgjyqdf");
			Customer customer4 = new Customer(new SmsSend(), "Chèvre", "world");
			repo1.Create(customer1);
			repo1.Create(customer2);
			repo1.Create(customer3);
			repo1.Create(customer4);
			repo1.Delete(customer2);
			Customer customer5 = new Customer(new SmsSend(), "Chèvre", "salée");
			repo1.Create(customer5);
			repo1.PrintRepo();
			Console.ReadLine();
		}
	}
}

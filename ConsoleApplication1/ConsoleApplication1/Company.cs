using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
	class Company : IContext <Customer>
	{
		private List<Customer> _customers;
		public List<Customer> EntityList()
		{
			return _customers;
		}

		public Company()
		{
			_customers = new List<Customer>();
		}
	}
}

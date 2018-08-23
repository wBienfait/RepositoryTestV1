using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
	class Customer : EntityBase
	{
		string _name;
		string _lastName;
		ISender _messageSender;
		public void SendMessage()
		{
			_messageSender.SendMessage();
		}

		public override void Print()
		{
			Console.WriteLine(_name + " " + _lastName + " " + Id);
		}

		public Customer(ISender sender, string name, string lastName)
		{
			_name = name;
			_lastName = lastName;
			_messageSender = sender;
		}
	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
	public abstract class EntityBase
	{
		public int Id { get; set; }
		public abstract void Print();
	}
}

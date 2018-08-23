using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
	public interface IContext <T> where T : EntityBase
	{
		List<T> EntityList();
	}
}

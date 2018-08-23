using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
	public interface IRepositoty <T> where T : EntityBase
	{
		T GetById(int id);
		void Create(T entity);
		void Delete(T entity);
		void Update(T entity);
		int GetNewId();
	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProject1
{
	public class ClassToTest
	{
		static ITestObject _testObject;
		static public ITestObject TestObject { set { _testObject = value; } }
		public ClassToTest(ITestObject objectTest)
		{
			_testObject = objectTest;
		}
		public static int Factorielle(int a)
		{
			if (a <= 1)
				return 1;
			return a * Factorielle(a - 1);
		}

		public static bool IsEnabled()
		{
			return _testObject.IsEnabled();
		}

		public static bool IsEnabled(ITestObject objectTotest)
		{
			return objectTotest.IsEnabled();
		}
	}

	public class TestObject : ITestObject
	{
		public bool IsEnabled()
		{
			return true;
		}
	}

	public class TestObject2 : ITestObject
	{
		public bool IsEnabled()
		{
			return false;
		}
	}

	public interface ITestObject
	{
		bool IsEnabled();
	}
}

using System;
using UnitTestProject1;
using Moq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestUnits
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void Factorial_Value3_ExpResult6()
		{
			int valeur = 3;
			int ExpResult = 6;
			int result = ClassToTest.Factorielle(valeur);
			Assert.AreEqual(ExpResult, result);

		}

		[TestMethod]
		public void Factorial_Value3_ExpResult8()
		{
			int valeur = 3;
			int ExpResult = 8;
			int result = ClassToTest.Factorielle(valeur);
			Assert.AreEqual(ExpResult, result);

		}

		[TestMethod]
		public void Dependecy_ValueObject_ExpTrue()
		{
			ITestObject valeur = new TestObject();
			ClassToTest.TestObject = valeur;
			bool ExpResult = true;
			bool result = ClassToTest.IsEnabled();
			Assert.AreEqual(ExpResult, result);
		
		}

		[TestMethod]
		public void Dependecy_ValueObject2_ExpFalse()
		{
			ITestObject valeur = new TestObject2();
			ClassToTest.TestObject = valeur;
			bool ExpResult = false;
			bool result = ClassToTest.IsEnabled();
			Assert.AreEqual(ExpResult, result);

		}

		//[TestMethod]
		//public void Dependecy_Moq_ExpFalse()
		//{
		//	var mockClass = new Mock<ITestObject>();
		//	mockClass.Setup(mock => mock.IsEnabled());
		//	ClassToTest classTotest = new ClassToTest(mockClass.);
		//	ClassToTest.TestObject = valeur;
		//	bool ExpResult = false;
		//	bool result = ClassToTest.IsEnabled();
		//	Assert.AreEqual(ExpResult, result);
		//
		//}
	}
}

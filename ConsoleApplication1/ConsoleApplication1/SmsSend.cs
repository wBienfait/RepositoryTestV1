using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
	class SmsSend : ISender
	{
		public string SendMessage()
		{
			return "New Sms";
		}
	}
}

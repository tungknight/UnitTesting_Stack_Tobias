using System;
using System.Runtime.Serialization;

namespace Stack
{
	[Serializable]
	internal class ExpenditureProhibitedException : Exception
	{
		public ExpenditureProhibitedException()
		{
		}

		public ExpenditureProhibitedException(string message) : base(message)
		{
		}

		public ExpenditureProhibitedException(string message, Exception innerException) : base(message, innerException)
		{
		}

		protected ExpenditureProhibitedException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}
	}
}
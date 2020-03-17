using System;
using System.Runtime.Serialization;

namespace Stack
{
	[Serializable]
	internal class ExceededSizeException : Exception
	{
		public ExceededSizeException()
		{
		}

		public ExceededSizeException(string message) : base(message)
		{
		}

		public ExceededSizeException(string message, Exception innerException) : base(message, innerException)
		{
		}

		protected ExceededSizeException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}
	}
}
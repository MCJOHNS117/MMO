using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MMO.Framework;

namespace MMO.Photon.Application
{
	public class PhotonEvent : IMessage
	{
		private readonly byte _code;
		private readonly Dictionary<byte, object> _parameters;
		private readonly int? _subCode;

		public byte Code { get { return _code; } }

		public Dictionary<byte, object> Parameters { get { return _parameters; } }

		public int? SubCode { get { return _subCode; } }

		public MessageType Type { get { return MessageType.Async; } }

		public PhotonEvent(byte code, Dictionary<byte, object> parameters, int? subCode)
		{
			_code = code;
			_parameters = parameters;
			_subCode = subCode;
		}
	}
}

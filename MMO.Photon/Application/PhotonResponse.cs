using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MMO.Framework;

namespace MMO.Photon.Application
{
	public class PhotonResponse : IMessage
	{
		private readonly byte _code;
		private readonly Dictionary<byte, object> _parameters;
		private readonly int? _subCode;
		private readonly string _debugMessage;
		private readonly short _returnCode;

		public byte Code { get { return _code; } }

		public Dictionary<byte, object> Parameters { get { return _parameters; } }

		public int? SubCode { get { return _subCode; } }

		public string DebugMessage { get { return _debugMessage; } }

		public short ReturnCode { get { return _returnCode; } }

		public MessageType Type { get { return MessageType.Response; } }

		public PhotonResponse(byte code, Dictionary<byte, object> parameters, int? subCode, string debugMessage, short returnCode)
		{
			_code = code;
			_parameters = parameters;
			_subCode = subCode;
			_debugMessage = debugMessage;
			_returnCode = returnCode;
		}
	}
}

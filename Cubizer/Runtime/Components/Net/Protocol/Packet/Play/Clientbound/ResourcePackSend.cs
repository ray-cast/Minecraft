﻿using Cubizer.Net.Protocol.Serialization;

namespace Cubizer.Net.Protocol.Play.Clientbound
{
	[Packet(Packet)]
	public class ResourcePackSend : IPacketSerializable
	{
		public const int Packet = 0x33;

		public uint packetId
		{
			get
			{
				return Packet;
			}
		}

		public object Clone()
		{
			return new ResourcePackSend();
		}

		public void Deserialize(NetworkReader br)
		{
			throw new System.NotImplementedException();
		}

		public void Serialize(NetworkWrite bw)
		{
			throw new System.NotImplementedException();
		}
	}
}
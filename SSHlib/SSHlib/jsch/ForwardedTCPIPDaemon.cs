using System;
using SharpSSH.java.lang;

namespace SharpSSH.jsch
{
	public interface ForwardedTCPIPDaemon : Runnable
	{
		void setChannel(ChannelForwardedTCPIP channel);
		void setArg(Object[] arg);
	}
}

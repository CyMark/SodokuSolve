using System;

namespace SharpSSH.jsch
{
	/// <summary>
	/// Summary description for JSchException.
	/// </summary>
	public class JSchException : java.Exception
	{
		public JSchException() : base()
		{
			//
			// TODO: Add constructor logic here
			//
		}

		public JSchException(string msg) : base (msg)
		{
		}
	}
}
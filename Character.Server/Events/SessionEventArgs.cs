using System;
using JetBrains.Annotations;
using StreetlifeRP.Character.Server.Models;

namespace StreetlifeRP.Character.Server.Events
{
	[PublicAPI]
    public class SessionEventArgs : EventArgs
    {
		public Session Session { get; }

		public SessionEventArgs(Session session)
        {
            Session = session;
        }
    }
}
